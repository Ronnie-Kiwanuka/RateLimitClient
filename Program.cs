using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Processor proc = new Processor();
            string response = proc.CallApi();

            Console.WriteLine("Response: " + response);
        }
    }
}
