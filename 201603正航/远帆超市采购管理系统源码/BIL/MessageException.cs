using System;
using System.Collections.Generic;
using System.Text;

namespace BIL
{
    public class MessageException:Exception
    {
        public MessageException(string str):base(str)
        {
            
        }
    }
}
