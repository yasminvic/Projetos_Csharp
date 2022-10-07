using Classes.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Utils
{
    public class Mocks
    {
        public List<Voo> ListaVoo { get; set; }

        public Mocks()
        {
            ListaVoo = new List<Voo>();
            CargaMock();
        }

        public void CargaMock()
        {
            CargaVoo();
        }

        public void CargaVoo()
        {
            for (int i = 0; i < 10; i++)
            {
                Voo voo = new Voo(i, $"{i}/{i+1}/2022");
                ListaVoo.Add(voo);
            }
            

        }
    }
}
