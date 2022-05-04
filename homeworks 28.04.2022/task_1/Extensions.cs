using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    static class Extensions
    {
        public static bool customContain(this string mainStr, string searchedStr)
        {
            bool result = false;

            for (int i = 0; i < mainStr.Length; i++)
            {
                if (mainStr.Length - i < searchedStr.Length)
                    break;
                else
                {
                    if (mainStr.Substring(i, searchedStr.Length).ToLower() == searchedStr.ToLower())
                       result = true;                        
                    
                }
            }

            return result;
        }
    }
}
