using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTCP
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConnectionUser user = new ConnectionUser();
            user.StartConnectionUserTCP();
        }
    }
}
