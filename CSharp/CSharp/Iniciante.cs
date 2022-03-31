using System.Linq;

namespace CSharp
{
    public class Iniciante
    {
        /// concatenar os 2 parametros
        /// ex: str1: moran, str2: go
        /// r: morango
        public string Concatenar(string str1, string str2)
        {
            return str1 + str2;
        }

        /// gerar um array separando as palavras por espaço
        /// ex: mercado livre
        /// r: ['mercado', 'livre']
        public string[] GerarArraySeparandoTextoPorEspaco(string str)
        {
            return str.Split(' ');
        }

        /// verificar se um texto tem mais de 10 caracteres ignorando os espaços
        /// ex: eu fui no mercado comprar pão
        /// r: true
        public bool ContarCaracteresIgnorandoEspaco(string str)
        {
            return str.Replace(" ", "").Length > 10;
        }

        /// adicionar item no array
        /// ex: array: ['a', 'b'], str: 'h'
        /// r: ['a', 'b', 'h']
        public string[] AdicionarItemNoArray(string[] array, string str)
        {
            var nArray = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                nArray[i] = array[i];
            }
            nArray[nArray.Length - 1] = str;
            return nArray;
        }

        /// remover item do array
        /// ex: array: ['a', 'b', 'h'], str: 'h'
        /// r: ['a', 'b']
        public string[] RemoverItemDoArray(string[] array, string str){
            var nArray = new string[array.Length -1];
            var indexAdd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] != str)
                {
                    nArray[indexAdd] = array[i];
                    indexAdd++;
                }
            }
            return nArray;
        }

        ///
        /// alterar a primeira letra da palavra para maiuscula
        /// ex: guilherme
        /// r: Guilherme
        ///
        public string CaptalizarSimples(string str){
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }

        ///
        /// alterar todas sa primeiras letras das palavras para maiuscula
        /// ex: guilherme vai para o mercado
        /// r: Guilherme Vai Para O Mercado
        ///
        public string CaptalizarAvancada(string str){
            var array = str.Split(" ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].Substring(0, 1).ToUpper() + array[i].Substring(1);
            }
            return string.Join(" ", array);
        }
    }
}
