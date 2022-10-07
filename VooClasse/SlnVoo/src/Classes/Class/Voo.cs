using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Class
{
    public class Voo
    {
        public Int32 NumVoo { get; set; }
        public String Data { get; set; }
        public Int32 PassageirosMax { get; set; }

        public Voo()
        {

        }

        public Voo(Int32 numvoo, String data)
        {
            PassageirosMax = 100;
            Data = data;
            NumVoo = numvoo;
        }
    }
}
