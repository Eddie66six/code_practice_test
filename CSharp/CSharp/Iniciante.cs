namespace CSharp
{
    public class Iniciante
    {
        /// concatenar os 2 parametros
        /// ex: str1: moran, str2: go
        /// r: morango
        public string Concatenar(string str1, string str2)
        {
            return "";
        }

        /// gerar um array separando as palavras por espaço
        /// ex: mercado livre
        /// r: ['mercado', 'livre']
        public string[] GerarArraySeparandoTextoPorEspaco(string str)
        {
            return new string[0];
        }

        /// verificar se um texto tem mais de 10 caracteres ignorando os espaços
        /// ex: eu fui no mercado comprar pão
        /// r: true
        public bool ContarCaracteresIgnorandoEspaco(string str)
        {
            return false;
        }

        /// adicionar item no array
        /// ex: array: ['a', 'b'], str: 'h'
        /// r: ['a', 'b', 'h']
        public string[] AdicionarItemNoArray(string[] array, string str)
        {
            return new string[0];
        }

        /// remover item do array
        /// ex: array: ['a', 'b', 'h'], str: 'h'
        /// r: ['a', 'b']
        public string[] RemoverItemDoArray(string[] array, string str){
            return new string[0];
        }

        ///
        /// alterar a primeira letra da palavra para maiuscula
        /// ex: guilherme
        /// r: Guilherme
        ///
        public string CaptalizarSimples(string str){
            return "";
        }

        ///
        /// alterar todas sa primeiras letras das palavras para maiuscula
        /// ex: guilherme vai para o mercado
        /// r: Guilherme Vai Para O Mercado
        ///
        public string CaptalizarAvancada(string str){
            return "";
        }
    }
}
