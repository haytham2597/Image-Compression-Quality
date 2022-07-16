using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ICQ.Libs
{
    public class Property
    {
        public class ImageQuality
        {
            public Image<Bgr, byte> Img { set; get; }
            public int Quality { set; get; }
        }

        public class ImgQuality
        {
            public Image<Bgr, byte> ImgBefore { set; get; }
            public Image<Bgr, byte> ImgAfter { set; get; }
            public int Quality { set; get; } = 100;
            public long AfterBytes { set; get; }
            public FileInfo FileInput { set; get; }
        }
    }
}
