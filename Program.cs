using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o Valor do Salario Bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Informe quanto sera pago de Vale Alimentação: ");
            double alimentacao = double.Parse(Console.ReadLine());

            Console.Write("Quantidade de Filhos: ");
            int filhos = int.Parse(Console.ReadLine());

            Console.Write("Informe quanto será pago por filho: ");
            double valorPorFilho = double.Parse(Console.ReadLine());

            Console.Write("Informe o numero de horas extras: ");
            double horasExtras = double.Parse(Console.ReadLine());

            Console.Write("Informe o Valor pago por Hora Extra: ");
            double valorHoraExtra = double.Parse(Console.ReadLine());

            Console.Write("Informe quanto será descontado de INSS: ");
            double inss = double.Parse(Console.ReadLine());

            Console.Write("Informe quanto será descontado de IRPF: ");
            double irpf = double.Parse(Console.ReadLine());

            double salarioLiquido = ( (salarioBruto + alimentacao + (filhos * valorPorFilho ) + (horasExtras * valorHoraExtra )) - inss) -irpf;

            Console.WriteLine("Salario Liquido: R$" + salarioLiquido.ToString("C"));

            Console.Write("\n\n Pressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
