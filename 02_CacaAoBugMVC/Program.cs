using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CacaAoBugMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("*** Passagem de Parâmetro por Valor ***");
            //passa o conteudo da variável de Origem para a variável de Destino 
            double valor = 10;
            if (PassagemParametroValor(valor))
                Console.WriteLine($"Valor do método Main--> PassagemParametroValor {valor}");

            Console.WriteLine("\n\n*** Passagem de Parâmetro por Referência REF ***");
            //passa o endereço de memória da variável de Origem para a variável de Destino
            //variavel de de Origem pode estar inicializada
            //o mérodo de Destino pode alterar o valor variável do método de Origem
            double valor1 = 10;
            if (PassagemParametroReferenciaRef(ref valor1))
            { 
            Console.WriteLine($"Valor do método Main--> PassagemParametroReferenciaRef {valor1}");
            }

            Console.WriteLine("\n\n*** Passagem de Parâmetro por Referência OUT ***");
            //passa o endereço de memória da variável de Origem para a variável de Destino
            //variavel de Origem pode não estar inicializada
            //o método de Destino deve obrigatoriamente inicializar a variável do método de Origem
            // o método de Destino pode alterar o valor variável do método de Origem
            double valor2;
            if (PassagemParametroReferenciaOut(out valor2))
            {
                Console.WriteLine($"Valor do método Main--> PassagemParametroReferenciaOut {valor2}");
            }

            Console.WriteLine("\n\n*** Passagem de Parâmetro por Referência IN ***");
            //passa o endereço de memória da variável de Origem para a variável de Destino
            //variavel de de Origem deve estar inicializada
            //o método de Destino não deve alterar o valor variável do método de Origem
            double valor3 = 100;
            if (PassagemParametroReferenciaIN(in valor3))
            {
                Console.WriteLine($"Valor do método Main--> PassagemParametroReferenciaIN {valor3}");
            }
        }

        //método para testar passagem de parâmetro por valor
        public static bool PassagemParametroValor(double valor)
        {
            valor = valor * 10;
            Console.WriteLine($"Valor de método PassagemParametroValor {valor}");
            return true;
        }


        //método para testar passagem de parâmetro por referência REF
        public static bool PassagemParametroReferenciaRef(ref double valor1)
        {
            valor1 = valor1 * 10;
            Console.WriteLine($"Valor de método PassagemParametroReferenciaRef {valor1}");
            return true;
        }


        //método para testar passagem de parâmetro por referência OUT
        public static bool PassagemParametroReferenciaOut(out double valor2)
        {
            valor2 = 10;
            valor2 =  valor2 * 10;
            Console.WriteLine($"Valor de método PassagemParametroReferenciaRef {valor2}");
            return true;
        }

        //método para testar passagem de parâmetro por referência IN
        public static bool PassagemParametroReferenciaIN(in double valor3)
        {
            Console.WriteLine($"Valor de método PassagemParametroReferenciaRef {valor3}");
            return true;
        }


    }
}
