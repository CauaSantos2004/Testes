using System.Net.NetworkInformation;

namespace _02_CacaAoBugMVC.Model
{
    public class Aluno
    {
        /*
        private string nome = string.Empty;

        //métodos acessadores
        public string getNome() //método getter
        {
            return nome;
        }
        
        public void setNome(string nome) //método setter
        {
            this.nome = nome;
        }   
        */

        //declaração de propiedades
        public string Nome { get; set; } = string.Empty;
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double Media { get; set; }
        public string situacao { get; set; } = string.Empty;

    }
}
