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
            int n = 0;


            for(int i=0; i<ObsNum; i++)
            {
                for(int j=0; j<ParaNum; j++)
                {
                    symbol_id = "F"+j.ToString()+"/l"+i.ToString();
                    A_[i, j] = symbol_id;
                    n = ObsNum/3;
                    if (i%3 ==0)
                    {
                        if(j%3 == 0)
                        {
                            //cos theta1 * S1
                            A_coff[i, j] = "cos_th1-"+n.ToString()+"*S"+n.ToString();
                        }
                        else if(j%3 == 1)
                        {
                            A_coff[i, j] = "sin_th1-"+n.ToString()+"*S"+n.ToString();
                        }
                        else
                        {
                            A_coff[i, j] = "0";
                        }

                    }
                    else if(i%3 == 1)
                    {
                        if(j%3 == 0)
                        {
                            A_coff[i, j] = "0";
                        }
                        else if(j%3 == 1)
                        {
                            A_coff[i, j] = "0";
                        }
                        else
                        {
                            A_coff[i, j] = "cos_th2-"+n.ToString()+"*S"+n.ToString();
                        }
                    }
                    else
                    {
                        if(j%3 == 0)
                        {
                            A_coff[i, j] = "sin_th1-"+n.ToString();
                        }
                        else if(j%3 == 1)
                        {
                            A_coff[i, j] = "cos_th1-"+n.ToString();
                        }
                        else
                        {
                            A_coff[i, j] = "sin_th2-"+n.ToString();
                        }
                    }

                }
            }

            return A_coff;
        }

        public int[,] B_m(int ObsNum, int ParaNum)
        {
            int[,] B_coff = new int [ObsNum,ParaNum] ;
            string[,] B_ = new string [ObsNum,ParaNum];
            string symbol_id;
            int n = 0;

            for(int i=0; i<ObsNum; i++)
            {
                for(int j=0; j<ParaNum; j++)
                {
                    symbol_id = "F"+j.ToString()+"/Delta"+i.ToString();
                    B_[i, j] = symbol_id;
                    n = ObsNum/3;
                    if (i%3 ==0)
                    {
                        if(j%3 == 0)
                        {
                            //cos theta1 * S1
                            B_coff[i, j] = -1;
                        }
                        else if(j%3 == 1)
                        {
                            B_coff[i, j] = 0;
                        }
                        else
                        {
                            B_coff[i, j] = 0;
                        }

                    }
                    else if(i%3 == 1)
                    {
                        if(j%3 == 0)
                        {
                            B_coff[i, j] = 0;
                        }
                        else if(j%3 == 1)
                        {
                            B_coff[i, j] = -1;
                        }
                        else
                        {
                            B_coff[i, j] = 0;
                        }
                    }
                    else
                    {
                        if(j%3 == 0)
                        {
                            B_coff[i, j] = 0;
                        }
                        else if(j%3 == 1)
                        {
                            B_coff[i, j] = 0;
                        }
                        else
                        {
                            B_coff[i, j] = -1;
                        }
                    }

                }
            }
            return B_coff;
        }

        public float[,] Substitute(string[,] coff_s, int ObsNum, int ParaNum, float[,] partial_value)
        {
            /* default Obs equations
            **
            ** f1 = sin(theta1_n)*Sn-Xn = 0
            ** f2 = cos(theta1_n)*Sn-Yn = 0
            ** f3 = sin(theta2_n)*Sn-Zn = 0
            **
            ** partial value [,] each row has [[theta1, theta2, s]]
            */
            
            int rank = coff_s.Rank;
            int col = coff_s.GetLength(1);
            int row = coff_s.GetLength(0);
            Console.WriteLine(col);
            Console.WriteLine(row);
            Console.WriteLine("ObsNum = "+ObsNum.ToString()+" ParaNum = "+ParaNum.ToString());

            float[,] coff_data = new float[ObsNum,ParaNum] ;
            

            return coff_data;
        }
    }
}