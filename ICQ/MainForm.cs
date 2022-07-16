using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Statistics.Models.Regression.Linear;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using ICQ.Libs;

namespace ICQ
{
    public partial class MainForm : Form
    {
        private readonly Stopwatch sw = new Stopwatch();
        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;
                if (ofd.FileNames.Length == 0)
                    return;

                for (int i = 0; i < ofd.FileNames.Length; i++)
                {
                    TreeNode tn = new TreeNode();
                    tn.Text = Path.GetFileNameWithoutExtension(ofd.FileNames[i]);
                    tn.Tag = new Property.ImgQuality()
                    {
                        ImgBefore = new Image<Bgr, byte>(ofd.FileNames[i]),
                        ImgAfter = new Image<Bgr, byte>(ofd.FileNames[i]),
                        FileInput = new FileInfo(ofd.FileNames[i])
                    };
                    treeView_Files.Nodes.Add(tn);
                }
                treeView_Files.SelectedNode = treeView_Files.Nodes[0];
            }
        }
        private void treeView_Files_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!(e.Node.Tag is Property.ImgQuality imgQ))
                return;

            pictureBox_Before.Image = imgQ.ImgBefore.Bitmap;
            pictureBox_After.Image = imgQ.ImgAfter.Bitmap;
            trackBar_Quality.Value = imgQ.Quality;
            label_Before.Text = $"Antes: {string.Format("{0:0.0000}", (double)imgQ.FileInput.Length / 1024f / 1024f)} MB (Resolución: {imgQ.ImgBefore.Width}x{imgQ.ImgBefore.Height})";
            label_After.Text = $"Después: {string.Format("{0:0.0000}", (double)imgQ.AfterBytes/1024f/1024f)} MB (Se ahorró: {string.Format("{0:0.0000}", 100 - (double)(imgQ.AfterBytes * 100) / imgQ.FileInput.Length)}%)";
            label_Quality.Text = $"Calidad: {trackBar_Quality.Value}%";
        }

        private void ChangeQuality(int quality)
        {
            if (!(treeView_Files.SelectedNode.Tag is Property.ImgQuality imgQ))
                return;
            if (imgQ.ImgBefore == null)
                return;
            trackBar_Quality.Value = quality;
            if (quality == 100)
            {
                imgQ.ImgAfter = imgQ.ImgBefore;
                label_Quality.Text = $"Calidad: {100}%";
                label_After.Text = $"Después";
                return;
            }
            using (Bitmap bmp = imgQ.ImgBefore.Bitmap)
            {
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                EncoderParameters myEncoderParameters = new EncoderParameters(1);
                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, Convert.ToInt64(quality));
                myEncoderParameters.Param[0] = myEncoderParameter;
                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms, jpgEncoder, myEncoderParameters);
                    ms.Position = 0;
                    //ms.Seek(0, SeekOrigin.Begin);
                    using (Bitmap bit = new Bitmap(ms))
                    {
                        imgQ.ImgAfter = new Image<Bgr, byte>(bit);
                        using (MemoryStream msImg = new MemoryStream(imgQ.ImgAfter.ToJpegData(quality)))
                        {
                            imgQ.AfterBytes = msImg.Length;
                            this.Invoke(new Action(() =>
                            {
                                double saved = (double) (msImg.Length * 100) / imgQ.FileInput.Length;
                                double savedPrint = (double)(0 > saved ? saved : 100 - saved);
                                label_After.Text = savedPrint >= 0 ? $"Después: {string.Format("{0:0.0000}", (double)msImg.Length / 1024f / 1024f)} MB (Se ahorró: {string.Format("{0:0.0000}", savedPrint)}%)" : $"Después: {string.Format("{0:0.0000}", (double)msImg.Length / 1024f / 1024f)} MB (No ahorra)";
                            }));
                            //label_After.Text = $"Después: {(double) msImg.Length / 1024f / 1024f} MB (Se ahorró: {100 - (double) (msImg.Length * 100) / imgQ.FileInput.Length}%)";
                        }
                    }
                }
            }
            imgQ.Quality = trackBar_Quality.Value;
            treeView_Files.SelectedNode.Text = $"{Path.GetFileNameWithoutExtension(imgQ.FileInput.Name)} ({imgQ.Quality}%)";
            GC.Collect();
        }

        private Image<Bgr, byte> ChangeQualityImg(int quality)
        {
            if (!(treeView_Files.SelectedNode.Tag is Property.ImgQuality imgQ))
                return null;
            using (Bitmap bmp1 = imgQ.ImgBefore.Bitmap)
            {
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                EncoderParameters myEncoderParameters = new EncoderParameters(1);
                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, Convert.ToInt64(quality));
                myEncoderParameters.Param[0] = myEncoderParameter;
                using (MemoryStream ms = new MemoryStream())
                {
                    bmp1.Save(ms, jpgEncoder, myEncoderParameters);
                    ms.Position = 0;
                    using (Bitmap bit = new Bitmap(ms))
                        return new Image<Bgr, byte>(bit);
                }
            }
        }

        private void trackBar_Quality_Scroll(object sender, EventArgs e)
        {
            if (!(treeView_Files.SelectedNode.Tag is Property.ImgQuality imgQ))
                return;
            checkBox_Auto.Checked = false;
            label_Quality.Text = $"Calidad: {((TrackBar) sender).Value}%";
            ChangeQuality(((TrackBar)sender).Value);
            pictureBox_After.Image = imgQ.ImgAfter.Bitmap;
        }
        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
                if (codec.FormatID == format.Guid)
                    return codec;
            return null;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < treeView_Files.Nodes.Count; i++)
            {
                if (!(treeView_Files.Nodes[i].Tag is Property.ImgQuality imgQ))
                    continue;
                if (imgQ.Quality == 100)
                    continue;
                if (treeView_Files.Nodes[i].StateImageIndex == 0)
                    continue;
                using (MemoryStream msImg = new MemoryStream(imgQ.ImgAfter.ToJpegData(imgQ.Quality)))
                using (var fileStream = File.Create(Path.Combine(imgQ.FileInput.DirectoryName, Path.GetFileNameWithoutExtension(imgQ.FileInput.Name) + "_Compress.jpg")))
                    msImg.CopyTo(fileStream);
                treeView_Files.Nodes[i].StateImageIndex = 0;
            }
        }

        public static readonly CancellationTokenSource s_cts = new CancellationTokenSource();
        
        //WARNING: High ram consumption
        private Task<Property.ImageQuality> imgProcess(int quality)
        {
            return Task.Run(() =>
            {
                if (!(treeView_Files.SelectedNode.Tag is Property.ImgQuality imgQ))
                    return new Property.ImageQuality() { Img = null, Quality = quality };
                if (s_cts.Token.IsCancellationRequested)
                {
                    Console.WriteLine("Task cancellation requested");
                    return new Property.ImageQuality(){Img = null, Quality=quality};
                }
                var qual = ChangeQualityImg(quality);
                using (Mat m = new Mat())
                {
                    CvInvoke.AbsDiff(imgQ.ImgBefore, qual, m);
                    CvInvoke.CvtColor(m, m, ColorConversion.Bgr2Gray);
                    int nonZero = CvInvoke.CountNonZero(m);
                    int size = imgQ.ImgBefore.Width * imgQ.ImgBefore.Height;
                    double diff = (double)(nonZero * 100) / size;
                    if (0 > diff)
                        s_cts.Cancel();
                    if (diff >= 100 - Convert.ToInt32(numericUpDown_MinDiff.Value))
                        s_cts.Cancel();
                    GC.Collect();
                }
                return new Property.ImageQuality(){Img=qual, Quality = quality};
            }, s_cts.Token);
        }
        
        private void checkBox_Auto_CheckedChanged(object sender, EventArgs e)
        {
            ProcessAuto();
        }

        private void ProcessAuto()
        {
            if (!(treeView_Files.SelectedNode.Tag is Property.ImgQuality imgQ))
                return;
            if (imgQ.ImgBefore == null)
                return;
            if (!checkBox_Auto.Checked)
            {
                ChangeQuality(100);
                pictureBox_After.Image = imgQ.ImgAfter.Bitmap;
                return;
            }

            if (imgQ.ImgBefore.Width > 1920 || imgQ.ImgBefore.Height > 1080)
            {
                if (MessageBox.Show("¿Seguro? Tu imágen es muy grande y este proceso puede llegar a tardar dependiendo de tu equipo", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    checkBox_Auto.Checked = false;
                    return;
                }
            }

            this.Cursor = Cursors.WaitCursor;
            sw.Start();
            bool multithreading = false;
            if (multithreading) //WARNING: High ram consumption
            {
                List<Task<Property.ImageQuality>> imgTasks = new List<Task<Property.ImageQuality>>();
                for (int i = 100; i >= 50; i--)
                    imgTasks.Add(imgProcess(i));
                while (true)
                    if (imgTasks.Any(x => x.IsCanceled))
                        break;
                imgTasks.RemoveAll(x => !x.IsCanceled && x.Result.Img == null);
                var res = imgTasks.Last(x => !x.IsCanceled).Result;
                imgQ.ImgAfter = res.Img;
                pictureBox_After.Image = imgQ.ImgAfter.Bitmap;
                trackBar_Quality.Value = res.Quality;
                label_Quality.Text = $"Calidad: {res.Quality}%";
                imgTasks.Clear();
                GC.Collect();
                sw.Stop();
                //Console.WriteLine(sw.Elapsed.ToString());
                //Console.WriteLine("Holy shit");
                this.Text = $"{this.Text} {sw.Elapsed.ToString()}";
                return;
            }

            sw.Restart();
            int cnt = 0;
            //TODO: Add a press key and get fuck out loop while running
            //double[] diffBetweenTwoStep = new double[2];
            int step = 0;
            List<double> diffList = new List<double>();
            List<double> stepList = new List<double>();
            for (int i = 100; i >= 50; i--) //[100,50]
            {
                if (i == 100)
                    continue;
                //TODO: IF Difference is not so much gen jump
                ChangeQuality(i);
                using (Mat m = new Mat())
                {
                    //TODO: Researh Diff with split img channel
                    CvInvoke.AbsDiff(imgQ.ImgBefore, imgQ.ImgAfter, m);
                    CvInvoke.CvtColor(m, m, ColorConversion.Bgr2Gray);
                    int nonZero = CvInvoke.CountNonZero(m);
                    int size = imgQ.ImgBefore.Width * imgQ.ImgBefore.Height;
                    double diff = (double)(nonZero * 100) / size;

                    cnt = i;

                    if (checkBox_WithPolynomialRegression.Checked)
                    {
                        diffList.Add(diff);
                        stepList.Add(step++);

                        if (diffList.Count >= 3)
                        {
                            double[] inputs = diffList.ToArray(); // X
                            double[] outputs = stepList.ToArray(); // Y
                            var ls = new PolynomialLeastSquares() {Degree = 1};
                            PolynomialRegression poly = ls.Learn(inputs, outputs);
                            string str = poly.ToString("N1"); // "y(x) = 1.0x^2 + 0.0x^1 + 0.0"
                            Debug.WriteLine(str);
                            
                            double pred = poly.Transform(100 - Convert.ToInt32(numericUpDown_MinDiff.Value));
                            if (0 > pred)
                                break;
                            i -= Convert.ToInt32(pred);
                            continue;
                        }
                    }

                    if (0 > diff)
                        break;
                    if (diff >= 100 - Convert.ToInt32(numericUpDown_MinDiff.Value))
                        break;
                    Debug.WriteLine(diff);
                    GC.Collect();
                }
            }
            this.Cursor = Cursors.Default;
            sw.Stop();
            Debug.WriteLine(sw.Elapsed.ToString());
            Debug.WriteLine($"Calidad óptima: {cnt}%");
            pictureBox_After.Image = imgQ.ImgAfter.Bitmap;
            label_Quality.Text = $"Calidad: {cnt}%";
            this.Text = $"ICQ {sw.Elapsed.ToString()}";
        }

        private void numericUpDown_MinDiff_ValueChanged(object sender, EventArgs e)
        {
            ProcessAuto();
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            //WARNING: High ram consumption
            /*pictureBox_After.Image = ImgAfter.Copy().Resize(pictureBox_After.Width, pictureBox_After.Height, Inter.Cubic).Bitmap;
            pictureBox_Before.Image = ImgBefore.Copy().Resize(pictureBox_Before.Width, pictureBox_Before.Height, Inter.Cubic).Bitmap;*/
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(treeView_Files.SelectedNode.Tag is Property.ImgQuality imgQ))
                return;
            if (e.KeyCode == Keys.D)
            {
                using (Mat m = new Mat())
                {
                    CvInvoke.AbsDiff(imgQ.ImgBefore, imgQ.ImgAfter, m);
                    pictureBox_After.Image = m.Clone().Bitmap;
                }
                GC.Collect();
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(treeView_Files.SelectedNode.Tag is Property.ImgQuality imgQ))
                return;
            if (e.KeyCode == Keys.D)
                pictureBox_After.Image = imgQ.ImgAfter.Bitmap;
        }

        private void cerrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView_Files.Nodes.Count == 0)
                return;
            for (int i = 0; i < treeView_Files.Nodes.Count; i++)
            {
                if (treeView_Files.Nodes[i].StateImageIndex != -1)
                    continue;
                if (MessageBox.Show("¿Seguro que desea cerrar todo? Hay imágenes sin guardar", "Advertencia", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                break;
            }
            treeView_Files.Nodes.Clear();
            SetDefault();
        }

        private void SetDefault()
        {
            label_Before.Text = "Antes";
            label_After.Text = "Después";
            label_Quality.Text = "Calidad: 100%";
            trackBar_Quality.Value = 100;
            pictureBox_After.Image = null;
            pictureBox_Before.Image = null;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView_Files.SelectedNode.Remove();
            if (treeView_Files.Nodes.Count != 0)
            {
                treeView_Files.SelectedNode = treeView_Files.Nodes[0];
            }
            else
            {
                SetDefault();
            }
        }

        private void treeView_Files_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            treeView_Files.SelectedNode = e.Node;
            contextMenuStrip.Show(treeView_Files, e.Location);
        }

        private void checkBox_WithPolynomialRegression_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Auto.Checked)
                ProcessAuto();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.About().ShowDialog();
        }
    }
}
