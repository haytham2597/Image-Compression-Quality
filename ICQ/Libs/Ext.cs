using System;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ICQ.Libs
{
    public static class Ext
    {
        public static double GetDiffBadQuality(this Image<Bgr, byte> imgOrg, Image<Bgr, byte> imgNew)
        {
            double badness = 0;
            /*var imgGrayOrg = imgOrg.Copy().Convert<Gray, byte>();
            var imgGrayNew = imgNew.Copy().Convert<Gray, byte>();
            for (int v = imgOrg.Rows - 1; v >= 0; v--)
            for (int u = imgOrg.Cols - 1; u >= 0; u--)
                badness += Math.Pow(imgGrayOrg.Data[v, u, 0] - imgGrayNew.Data[v, u, 0], 2);*/

            for (int v = imgOrg.Rows-1; v >=0; v--)
            for (int u = imgOrg.Cols-1; u >=0 ; u--)
                badness += Math.Pow(imgOrg.Data[v, u, 0] - imgNew.Data[v, u, 0], 2) + Math.Pow(imgOrg.Data[v, u, 1] - imgNew.Data[v, u, 1], 2) + Math.Pow(imgOrg.Data[v, u, 2] - imgNew.Data[v, u, 2], 2);
            badness /= imgOrg.Width * imgOrg.Height;
            return badness;
        }
    }
}
