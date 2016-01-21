using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{

    public static class rule
    {
        /// <summary>
        /// check number  
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool CheckNumber(string number)
        {


            // check number

            for (int i = 0; i < number.Length; i++)
            {
                try
                {
                    int a = int.Parse(number[i].ToString());
                }
                catch (Exception e)
                {
                    return false;
                }
            }
                
           

            return true;
        }
        /// <summary>
        /// check lengh
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int CheckLengh(string text)
        {
            return text.Length;
            
        }
        /// <summary>
        /// check phone
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool CheckPhone(string number)
        {
            if (CheckNumber(number) == true && CheckLengh(number) > 9 && CheckLengh(number) <12)
            {
                if(int.Parse(number[0].ToString())==0)
                     return true;
            }
               
            return false;
        }
        public static bool CheckNumberID(string numberId)
        {
            if (CheckNumber(numberId) == true && CheckLengh(numberId) > 8 && CheckLengh(numberId) < 13)
            {
                 
                    return true;
            }

            return false;
        }
        public static string parrtToMonney(string input)
        {
            input = input + " ";
            while(lengh1(input)>3)
            {
                for(int i= lengh1(input); i>=0; i--)
                {
                    if ((lengh1(input) - i) % 3 == 0 && (lengh1(input) - i)!=0)
                    {
                        input = input.Insert(i, " ");
                        break;
                    }
                }
            }
            return input;
        }

        public static string partToInt(string input)
        {
            input = input.Replace(" ", "");
            return input;
        }
        public static int lengh1(string input)
        {
            for(int i=0; i<input.Length; i++)
            {
                if(input[i]==' ')
                {
                    return i;
                }
            }
            return 0;
        }

    }

   
}
