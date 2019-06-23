using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;

namespace ArpScanner
{
    class Program
    {
        static void Main(string[] args)
        {


            NetTable netTable = new NetTable();
            netTable.GetArpAddresses();
            Console.ReadKey();
        }
    }
}
