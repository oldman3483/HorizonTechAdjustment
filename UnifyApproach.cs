using System;
using System.IO;

namespace UnifyApproach
{
    class equation
    {
        public string[,] A_m(int ObsNum, int ParaNum)
        {
            string[,] A_coff = new string [ObsNum,ParaNum] ;

            return A_coff;
        }

        public string[,] B_m(int ObsNum, int ParaNum)
        {
            string[,] B_coff = new string [ObsNum,ParaNum] ;

            return B_coff;
        }

        public float[,] Substitute(string[,] coff_s, int ObsNum, int ParaNum, float[] l_obs, float[] param)
        {
            float[,] coff_data = new float[ObsNum,ParaNum] ;

            return coff_data;
        }
    }
}