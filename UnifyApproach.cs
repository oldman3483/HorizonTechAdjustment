using System;
using System.IO;

namespace UnifyApproach
{
    class equation
    {
        public string[,] A_m(int ObsNum, int ParaNum)
        {
            // return a 2D string array which the elements express the partial derivative formula with string symbolic type
            string[,] A_coff = new string [ObsNum,ParaNum];
            string[,] A_ = new string [ObsNum,ParaNum];
            string symbol_id;


            for(int i=0; i<ObsNum; i++)
            {
                for(int j=0; j<ParaNum; j++)
                {
                    symbol_id = "F"+j.ToString()+"/l"+i.ToString();
                    A_[i, j] = symbol_id;
                    if (i%3 ==0)
                    {
                        if(j%3 == 0)
                        {
                            //cos theta1 * S1
                        }

                    }
                    else if(i%3 == 1)
                    {

                    }
                    else
                    {

                    }

                }
            }

            return A_;//A_coff;
        }

        public string[,] B_m(int ObsNum, int ParaNum)
        {
            string[,] B_coff = new string [ObsNum,ParaNum] ;

            return B_coff;
        }

        public float[,] Substitute(string[,] coff_s, int ObsNum, int ParaNum, float[] partial_value)
        {
            /* default Obs equations
            **
            ** f1 = sin(theta1_n)*Sn-Xn = 0
            ** f2 = cos(theta1_n)*Sn-Yn = 0
            ** f3 = sin(theta2_n)*Sn-Zn = 0
            **
            */
            
            float[,] coff_data = new float[ObsNum,ParaNum] ;
            

            return coff_data;
        }
    }
}