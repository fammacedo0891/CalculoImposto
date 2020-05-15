using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoImposto.Entities;

namespace CalculoImposto.Entities
{
    class PessoaFisica : Rendimentos
    {

        public double DespesaSaude { get; set; }


        public PessoaFisica()
        {

        }

        public PessoaFisica(double despesaSaude, string nome, double faturamento)
            : base(nome, faturamento)
        {
            DespesaSaude = despesaSaude;
        }

        
        public override double TotalImposto()
        {
            if (Faturamento > 20.000)
            {

                return (Faturamento * 0.25) - (DespesaSaude * 0.50);

            }
            else
            {
                return (Faturamento * 0.15) - (DespesaSaude * 0.50);
            }
        }

        //public override double TotalImposto()
        //{
        //    return TotalImposto;
        //}

    }



}
