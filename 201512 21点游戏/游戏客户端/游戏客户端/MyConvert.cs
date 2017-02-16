using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsApplication1
{
    class MyConvert
    {
        public static int[] StringToArray(string str)
        {
            
            string[] arrayStr = str.Split(' ');

            int[] arrayInt = new int[arrayStr.Length];
            for (int i=0;i<arrayStr.Length;i++)
            {
                arrayInt[i] = int.Parse(arrayStr[i]);
            }

            return arrayInt;
        }
        public static int sumArray(int []arrayInt)
        {
            int sum=0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                sum += arrayInt[i];
            }
            return sum;
        }
    }

}
