using System;
using System.Collections.Generic;
using CalculoImposto.Entities;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rendimentos> list = new List<Rendimentos>();

            Console.Write("Informe a qtd de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            
            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Ccontribuinte #{i}");

                Console.Write("Informe o tipo de contribuinte (PF/PJ): ");
                string pessoa = Console.ReadLine();
                
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Rendimento anual: ");
                double faturamento = double.Parse(Console.ReadLine());

                if ( (pessoa == "PF") || (pessoa == "pf") )
                {
                    Console.Write("Informe as despesa com plano de saúde: ");
                    double planoSaude = double.Parse(Console.ReadLine());

                    list.Add(new PessoaFisica(planoSaude, nome, faturamento));
                }
                else if  ( (pessoa == "PJ") || (pessoa == "pj") )
                {
                    Console.Write("Informe o número de empregados: ");
                    int empregados = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(empregados, nome, faturamento));

                }

            }

            Console.WriteLine();

            Console.WriteLine("Imposto pago anualmente por contribuinte");

            Console.WriteLine();

            double totImpArrecadado = 0;

            foreach (Rendimentos rend in list)
            {
                Console.WriteLine("Contribuinte: " + rend.Nome + " - " + "Imposto: " + 
                    rend.TotalImposto().ToString("F2", CultureInfo.InvariantCulture));

                              
                totImpArrecadado += rend.TotalImposto();


            }

            Console.WriteLine();

            Console.WriteLine("Arrecadação de Imposto anualmente");

            Console.WriteLine();

            Console.WriteLine("Arrecadação de Imposto: " + totImpArrecadado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
