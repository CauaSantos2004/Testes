using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_CacaAoBugMVC.Model
{
    public class ValidaService
    {
        //padrão nome
        //- minimo 3 caracteres
        //- não pode ter 3 letras iguais consecutivas
        //- não pode ter duplo espaço
        private readonly string padraoNome = @"^(?!.*([A-Za-zÀ-ÖØ-öø-ÿ])\1\1)(?!.* {2,})(?=.{3,})[A-Za-zÀ-ÖØ-öø-ÿ ]+$";

        //padrão nota
        //- valida nota entre 0 e 10
        //- aceita decimais com ponto ou vírgula
        private readonly string padraoNota = @"^(?:10(?:[.,]0+)?|[0-9](?:[.,][0-9]+)?)$";


        //método para validar nome do aluno
        public bool ValidaNome(string nome, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if (string.IsNullOrWhiteSpace(nome))
            {
                mensagemErro = "O nome não pode ser vazio.";
                return false;
            }

            nome = nome.Trim();

            // nome deve seguir o padrão
            if (!Regex.IsMatch(nome, padraoNome))
            {
                mensagemErro = "O nome é inválido. ";
                mensagemErro += "Regras: mínimo 3 caracteres, sem 3 letras iguais consecutivas e sem espaço duplo.";
                return false;
            }

            return true;
        }


        //método para converter nota string para double
        public bool ConverteNota(string notaEntrada, out double nota)
        {
            nota = -1; 

            if (string.IsNullOrEmpty(notaEntrada)) return false;

            //padroniza a entrada para ponto decimal
            var notaDecimalVirgula = notaEntrada.Trim().Replace(",", ".");

            //verifica se a nota corresponde a expressão regular
            if (!Regex.IsMatch(notaDecimalVirgula, padraoNota)) return false;

            //tenta converter a nota para double
            if (double.TryParse(notaDecimalVirgula, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out nota))
            {
                //verifica se a nota está no intervalo válido
                if (nota < 0 || nota > 10)
                    return false; //nota inválida
                else
                    return true; //nota válida
            }
            return false;

        }

    }
}
