using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.AnalisaVoo
{
   public class AnaliseVoo
    {
        public AnaliseVoo()
        {

        }
        public bool Verifica(Int32 numCadeira)
        {
            bool ocupado = true;
            foreach (CadeiraOcupada in Program.Mock.ListaVoo)
            {
                if (numCadeira.Equals(CadeiraOcupada))
                {
                    ocupado = false;
                }
                else
                {
                    ocupado = true;
                }
            }
            return ocupado;
        }

        public bool Ocupa(Int32 numCadeira)
        {
            if (Verifica)
            {
                Program.Mock.ListaVoo.Add(numCadeira);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
