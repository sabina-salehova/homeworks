using System;
using System.Text;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter modifeded sentences: ");
            string str = Console.ReadLine();
            Console.WriteLine("Result: "+modifiedString(str));
        }
        public static string modifiedString(string str)
        {          
            str = str.ToLower();
            string[] charWordArray = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                charWordArray[i] = str[i].ToString();
            }
            
            string[] charWordArray2 = new string[str.Length];
            charWordArray2[0] = charWordArray[0].ToUpper();
            
            for (int i = 1; i < charWordArray.Length; i++)
            {
                

                if (charWordArray[i-1] == " ")
                {
                    charWordArray2[i] = charWordArray[i].ToUpper();
                }
                else
                    charWordArray2[i] = charWordArray[i];           
              }
            
            string sentences=null; ;
            foreach (string item in charWordArray2)
            {
                sentences+=item;
                
            }           
           
            return sentences;

        }




    }
    }

