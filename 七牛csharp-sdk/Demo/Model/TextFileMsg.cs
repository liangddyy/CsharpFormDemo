using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Conf
{
    class TextFileMsg
    {
        private string name = null;
        private String path = null;
        private String text = null;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
