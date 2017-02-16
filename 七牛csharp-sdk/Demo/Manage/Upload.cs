using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Manage
{
    class Upload
    {
        public string SendFile(string fileName, Uri uri, string encodingType = "UTF-8")
        {

            WebClient myWebClient = new WebClient();
            byte[] responseArray = myWebClient.UploadFile(uri, "POST", fileName);

            return Encoding.GetEncoding(encodingType).GetString(responseArray);
        }
    }
}
