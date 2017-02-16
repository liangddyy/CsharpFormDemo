using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.model
{
    public class ImgFileMsg
    {
        public String name;

        public String path;
        public String url;
       public ImgFileMsg(String name, String path)
        {
            this.name = name;
            this.path = path;
            this.url = null;
        }
       public ImgFileMsg()
        {
            this.name = null;
            this.path = null;
            this.url = null;
        }
    }
}
