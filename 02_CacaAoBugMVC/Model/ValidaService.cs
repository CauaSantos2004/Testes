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
    class ValidaService
    {
        //padrão
        //- minimo 3 caracteres
        //- não pode ter 3 letras iguais consecutivas
        //- não pode ter duplo espaço
        private readonly string padraoNome = @"^(?!.*([A-Za-zÀ-ÖØ-öø-ÿ])\1\1)(?!.* {2,})(?=.{3,}).+$";

        //padrão
        //- valida nota entre 0 e 10
        //- aceita decimais com ponto ou vírgula
        private readonly string padraoNota = @"^(?:10(?:[.,]0+)?|[0-9](?:[.,][0-9]+)?)$";


        //método para validar nome
        public bool ValidaNome(string nome, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            if (string.IsNullOrEmpty(nome))
            {
                mensagemErro = "O nome não pode ser vazio.";
                return false;
            }

            //verifica se o nome corresponde a expressão regular
            if (Regex.IsMatch(nome.Trim(), padraoNome))
            { 
                
                mensagemErro = "Minimo 3 caracteres\n- não pode ter 3 letras iguais consecutivas\n- não pode ter duplo espaço";
                return false;
            }
            return true;
        }
    }
}
