using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImposto.Entities
{
    class PessoaJuridica : Rendimentos
    {

        public int Empregados { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(int empregados, string nome, double faturamento)
          : base(nome, faturamento)
        {
            Empregados = empregados;
        }

        public override double TotalImposto()
        {
            if (Empregados > 10)
            {

                return Faturamento * 0.14;

            }
            else
            {
                return Faturamento * 0.16;
            }
        }

        
    }
}
