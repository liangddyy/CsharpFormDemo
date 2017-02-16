using System;

namespace 打字游戏
{
    internal class myRandom
    {
        private static int _i = 1;

        public string getChar(int len)
        {
            string[] _char = new[]
                {
                    "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                    "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
                };
            Random rand;
            string str = "";
            while (true)
            {
                if (str.Length == len)
                    break;
                rand = new Random(DateTime.Now.Millisecond*_i);
                _i++;
                int r = rand.Next(0, 25);

                if (str.IndexOf(_char[r]) != -1)
                {
                    str = "";
                }
                else
                    str += _char[r];
            }
            return str;
        }
    }
}