using System;
using System.IO;

namespace readfile
{

    class ReadFile
    {
        public int Split_row = 0;
        public String[] reader(string fileName)
        {
            String line;
            String [] content = new String[1000];
            StreamReader sr = new StreamReader(fileName);
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            int i = 0;
            while (line != null)
            {
            //write the lie to console window
                content[i] = line;
                //Console.WriteLine(line);
                        //Read the next line
                line = sr.ReadLine();
                i++;
            }
            //close the file
            sr.Close();
            //Console.ReadLine();
            return content;
        }

        public String[,] spliter(String[] content)
        {
            String[,] content_split = new String[1000, 100];

            int j = 0;
            
            
            while (content[j] != null)
            {    
                int k = 0;
                string[] subs = content[j].Split(' ','\t');
                foreach (var sub in subs)
                {                    
                    
                    content_split[j, k] = sub;
                    //Console.WriteLine($"Sub2: {content_split[j, k]}");
                    k++;
                    
                }
                //Console.WriteLine($"----------{j}----------------");
                j++;
                
            }
            Split_row = j-1;
            String[,] content_split2 = new String[Split_row, 6];
            for(int i=0; i<Split_row; i++) 
                {
                    for (j=0; j<6; j++)
                    {
                        content_split2[i, j] = content_split[i, j];
                    }
                    
                }
            return content_split2;
        }
    }
    
    
}
