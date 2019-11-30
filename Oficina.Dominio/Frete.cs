using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    public class Frete
    {
        public Frete(decimal valor, UF uf)
        {
            this.Valor = valor;
            this.UF = uf;
            Calcular();
        }

        public Cliente Cliente { get; set; }
        public decimal Valor { get; private set; }
        public UF UF { get; private set; }
        public decimal Percentual { get; private set; }
        public decimal Total { get; private set; }

        private void Calcular()
        {
            switch (UF)
            {
                case UF.SP:
                    Percentual = 0.2M;
                    break;
                case UF.RJ:
                    Percentual = 0.3M;
                    break;
                case UF.MG:
                    Percentual = 0.35M;
                    break;
                case UF.AM:
                    Percentual = 0.6M;
                    break;
                default:
                    Percentual = 0.7M;
                    break;
            }

            Total = (1 + Percentual) * Valor;
        }
    }
}
