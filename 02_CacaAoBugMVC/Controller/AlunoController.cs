using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_CacaAoBugMVC.Model;

namespace _02_CacaAoBugMVC.Controller
{
    public class AlunoController
    {
        // Construtor
        private readonly ValidaService validaService; // readonly garante atribuição apenas no construtor
        private readonly AlunoService alunoService;
        private readonly List<Aluno> alunos; // lista para armazenar os alunos cadastrados

        // Construtor da classe
        public AlunoController()
        {
            // Cria as instâncias dos serviços
            validaService = new ValidaService();
            alunoService = new AlunoService();
            alunos = new List<Aluno>();
        }

        // Método para adicionar aluno
        public bool AdicionaAluno(Aluno aluno, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            // Se o nome for inválido 
            if (!validaService.ValidaNome(aluno.Nome, out string erroNome))
            {
                mensagemErro = $"Nome inválido: {erroNome}";
                return false;
            }

            // Valida e converte as notas
            aluno.Media = alunoService.CalcularMedia(aluno.Nota1, aluno.Nota2, aluno.Nota3);

            // Obtém a situação do aluno com base na média
            aluno.situacao = alunoService.ObterSituacao(aluno.Media);

            // Adiciona o aluno à lista
            alunos.Add(aluno);

            return true;
        }

        // Método para obter a lista de alunos cadastrados (somente leitura)
        public IReadOnlyList<Aluno> ObterAlunos() => alunos.AsReadOnly();

        public double ObterTaxaAprovacao()
        {
            int totalAlunos = alunos.Count;
            int totalAprovados = alunos.FindAll(a => a.situacao == "Aprovado").Count; 
            return alunoService.CalcularTaxaAprovacao(totalAlunos, totalAprovados);
        }
        
        public ValidaService GetValidaService() => validaService;
    }
}
