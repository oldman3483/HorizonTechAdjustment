using System;
using readfile;
using UnifyApproach;
using System.IO;

namespace _0628
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            /*
            string fname = "case 1_Input.txt";
            ReadFile reader = new ReadFile();
            var content = reader.reader(fname);
            
            Console.WriteLine(content.Length);
            int i = 0;
            try
            {
                while (content != null)
                {
                    
                    if(content[i] == null)
                    {
                        Console.WriteLine("break!!!!");
                        break;
                    }
                    string[] subs = content[i].Split(' ', '.');
                    foreach (var sub in subs)
                    {
                        //Console.WriteLine($"Substring: {sub}");
                    }
                    //Console.WriteLine(content[i]);


                    i++;
                }
                i=0;
                int j=0;
                var con_split = reader.spliter(content);
                int row_sp = reader.Split_row;
                Console.WriteLine($"Sub2: {con_split[20, 3]}");
                for(i=0; i<row_sp; i++) 
                {
                    for (j=0; j<6; j++)
                    {
                        Console.WriteLine($"Sub2: {con_split[i, j]}");                        
                    }
                    Console.WriteLine($"----------{i}----------------");
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
            */
            int row = 9;
            int col = 10;
            equation equat = new equation();
            string [,] a = new string[row, col];
            a =  equat.A_m(row, col);
        
            /*
            foreach (var sub in a)
            {
                Console.WriteLine(sub);
            }
            */
            for(int i=0; i<row; i++)
            {
                for(int j=0; j<col; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(' ');
                }
                Console.Write('\n');
            }
            float [,] value = new float[100,100];
            equat.Substitute(a, a.Length/a.GetLength(1), a.GetLength(1), value);
        }
    }
}
