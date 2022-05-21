using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTCP
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionServer server = new ConnectionServer();
            server.StartConnectionServerTCP();
        }
    }
}
