using Main.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Program
    {
        public static Mocks Mock { get; set; }
        static void Main(string[] args)
        {
            Mock = new Mocks();
        }
    }
}
