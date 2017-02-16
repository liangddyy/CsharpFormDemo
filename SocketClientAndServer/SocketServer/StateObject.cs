using System.Net.Sockets;
using System.Text;

namespace SocketServer
{
    public class StateObject
    {
        public Socket workSocket = null;
        public const int BufferSize = 65535;
        public byte[] buffer = new byte[BufferSize];
        public StringBuilder sb = new StringBuilder();
    }
}
