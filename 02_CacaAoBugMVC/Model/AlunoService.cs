using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CacaAoBugMVC.Model
{
    //Classe para regras de negócio de cálculos
    class AlunoService
    {
        //Metodos da classe AlunoService

        // Método para calcular a média de três notas
        public double CalcularMedia(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3; // cálculo da média
        }

        // Método para obter a situação do aluno com base na média
        public string ObterSituacao(double media)
        {
            if (media >= 7)
                return "Aprovado";
            else if (media >= 4)
                return "Em Exame Final";
            else
                return "Reprovado";
        }

        // Método para calcular a taxa de aprovação
        public double CalcularTaxaAprovacao(int totalAlunos, int alunosAprovados)
        {
            //transforma a variável do tipo int para double utilizando cast (tipo)/variável
            return (alunosAprovados / (double)totalAlunos) * 100.0;
        }
    
    }
}
