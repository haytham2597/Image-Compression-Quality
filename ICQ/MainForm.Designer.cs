namespace ICQ
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Quality = new System.Windows.Forms.Panel();
            this.checkBox_WithPolynomialRegression = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_MinDiff = new System.Windows.Forms.NumericUpDown();
            this.label_Quality = new System.Windows.Forms.Label();
            this.trackBar_Quality = new System.Windows.Forms.TrackBar();
            this.checkBox_Auto = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_After = new System.Windows.Forms.PictureBox();
            this.label_After = new System.Windows.Forms.Label();
            this.label_Before = new System.Windows.Forms.Label();
            this.pictureBox_Before = new System.Windows.Forms.PictureBox();
            this.treeView_Files = new System.Windows.Forms.TreeView();
            this.imageListTreeNode = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_Quality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MinDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Quality)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_After)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Before)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.cerrarTodoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // cerrarTodoToolStripMenuItem
            // 
            this.cerrarTodoToolStripMenuItem.Name = "cerrarTodoToolStripMenuItem";
            this.cerrarTodoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.cerrarTodoToolStripMenuItem.Text = "Cerrar todo";
            this.cerrarTodoToolStripMenuItem.Click += new System.EventHandler(this.cerrarTodoToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel_Quality, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 437);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel_Quality
            // 
            this.panel_Quality.Controls.Add(this.checkBox_WithPolynomialRegression);
            this.panel_Quality.Controls.Add(this.label1);
            this.panel_Quality.Controls.Add(this.numericUpDown_MinDiff);
            this.panel_Quality.Controls.Add(this.label_Quality);
            this.panel_Quality.Controls.Add(this.trackBar_Quality);
            this.panel_Quality.Controls.Add(this.checkBox_Auto);
            this.panel_Quality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Quality.Location = new System.Drawing.Point(3, 3);
            this.panel_Quality.Name = "panel_Quality";
            this.panel_Quality.Size = new System.Drawing.Size(724, 78);
            this.panel_Quality.TabIndex = 0;
            // 
            // checkBox_WithPolynomialRegression
            // 
            this.checkBox_WithPolynomialRegression.AutoSize = true;
            this.checkBox_WithPolynomialRegression.Location = new System.Drawing.Point(243, 4);
            this.checkBox_WithPolynomialRegression.Name = "checkBox_WithPolynomialRegression";
            this.checkBox_WithPolynomialRegression.Size = new System.Drawing.Size(140, 17);
            this.checkBox_WithPolynomialRegression.TabIndex = 5;
            this.checkBox_WithPolynomialRegression.Text = "Con regresión polinomial";
            this.checkBox_WithPolynomialRegression.UseVisualStyleBackColor = true;
            this.checkBox_WithPolynomialRegression.CheckedChanged += new System.EventHandler(this.checkBox_WithPolynomialRegression_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mínima diferencia en %";
            // 
            // numericUpDown_MinDiff
            // 
            this.numericUpDown_MinDiff.Location = new System.Drawing.Point(192, 3);
            this.numericUpDown_MinDiff.Name = "numericUpDown_MinDiff";
            this.numericUpDown_MinDiff.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown_MinDiff.TabIndex = 3;
            this.numericUpDown_MinDiff.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_MinDiff.ValueChanged += new System.EventHandler(this.numericUpDown_MinDiff_ValueChanged);
            // 
            // label_Quality
            // 
            this.label_Quality.Location = new System.Drawing.Point(3, 23);
            this.label_Quality.Name = "label_Quality";
            this.label_Quality.Size = new System.Drawing.Size(74, 36);
            this.label_Quality.TabIndex = 2;
            this.label_Quality.Text = "Calidad: 100%";
            this.label_Quality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBar_Quality
            // 
            this.trackBar_Quality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Quality.Location = new System.Drawing.Point(83, 23);
            this.trackBar_Quality.Maximum = 100;
            this.trackBar_Quality.Name = "trackBar_Quality";
            this.trackBar_Quality.Size = new System.Drawing.Size(632, 45);
            this.trackBar_Quality.TabIndex = 1;
            this.trackBar_Quality.Value = 100;
            this.trackBar_Quality.Scroll += new System.EventHandler(this.trackBar_Quality_Scroll);
            // 
            // checkBox_Auto
            // 
            this.checkBox_Auto.AutoSize = true;
            this.checkBox_Auto.Location = new System.Drawing.Point(3, 3);
            this.checkBox_Auto.Name = "checkBox_Auto";
            this.checkBox_Auto.Size = new System.Drawing.Size(48, 17);
            this.checkBox_Auto.TabIndex = 0;
            this.checkBox_Auto.Text = "Auto";
            this.checkBox_Auto.UseVisualStyleBackColor = true;
            this.checkBox_Auto.CheckedChanged += new System.EventHandler(this.checkBox_Auto_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox_After, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_After, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_Before, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox_Before, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 87);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(724, 347);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox_After
            // 
            this.pictureBox_After.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_After.Location = new System.Drawing.Point(365, 23);
            this.pictureBox_After.Name = "pictureBox_After";
            this.pictureBox_After.Size = new System.Drawing.Size(356, 321);
            this.pictureBox_After.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_After.TabIndex = 3;
            this.pictureBox_After.TabStop = false;
            // 
            // label_After
            // 
            this.label_After.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_After.Location = new System.Drawing.Point(365, 0);
            this.label_After.Name = "label_After";
            this.label_After.Size = new System.Drawing.Size(356, 20);
            this.label_After.TabIndex = 1;
            this.label_After.Text = "Después";
            this.label_After.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Before
            // 
            this.label_Before.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Before.Location = new System.Drawing.Point(3, 0);
            this.label_Before.Name = "label_Before";
            this.label_Before.Size = new System.Drawing.Size(356, 20);
            this.label_Before.TabIndex = 0;
            this.label_Before.Text = "Antes";
            this.label_Before.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Before
            // 
            this.pictureBox_Before.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Before.Location = new System.Drawing.Point(3, 23);
            this.pictureBox_Before.Name = "pictureBox_Before";
            this.pictureBox_Before.Size = new System.Drawing.Size(356, 321);
            this.pictureBox_Before.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Before.TabIndex = 2;
            this.pictureBox_Before.TabStop = false;
            // 
            // treeView_Files
            // 
            this.treeView_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Files.HideSelection = false;
            this.treeView_Files.Location = new System.Drawing.Point(3, 3);
            this.treeView_Files.Name = "treeView_Files";
            this.treeView_Files.Size = new System.Drawing.Size(124, 431);
            this.treeView_Files.StateImageList = this.imageListTreeNode;
            this.treeView_Files.TabIndex = 2;
            this.treeView_Files.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Files_AfterSelect);
            this.treeView_Files.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Files_NodeMouseClick);
            // 
            // imageListTreeNode
            // 
            this.imageListTreeNode.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeNode.ImageStream")));
            this.imageListTreeNode.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTreeNode.Images.SetKeyName(0, "CheckIcon.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView_Files);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(864, 437);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 3;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ICQ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_Quality.ResumeLayout(false);
            this.panel_Quality.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MinDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Quality)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_After)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Before)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_Quality;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox_After;
        private System.Windows.Forms.Label label_After;
        private System.Windows.Forms.Label label_Before;
        private System.Windows.Forms.PictureBox pictureBox_Before;
        private System.Windows.Forms.Label label_Quality;
        private System.Windows.Forms.TrackBar trackBar_Quality;
        private System.Windows.Forms.CheckBox checkBox_Auto;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_MinDiff;
        private System.Windows.Forms.TreeView treeView_Files;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem cerrarTodoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_WithPolynomialRegression;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListTreeNode;
    }
}

