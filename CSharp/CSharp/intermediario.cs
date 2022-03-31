using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharp
{
    public class Intermediario
    {
        /// contar quantos 'a' tem em uma frase (maiúsculas e Minúsculas)
        /// ex: eu fui no mercado comprar pão
        /// r: 3
        public int ContarCaracteresA(string str){
            var regex = new Regex("[^aàáâãäå]*");
            return regex.Replace(str.ToLower(), "").Length;
        }

        /// contar quantos 'a' e 'o' tem em uma frase (maiúsculas e Minúsculas)
        /// retornar true caso tenha a mesma quantidade de 'a' e 'o'
        /// ex: eu fui no mercado comprar pão -> a: 3 o: 4
        /// r: false
        public bool ContarECompararCaracteresAO(string str){
            var array = str.ToCharArray();
            var a = array.Count(e => e == 'a');
            var o = array.Count(e => e == 'o');
            return a == o;
        }

        /// retornar a posição dos caracteres 'a' e 'o'
        /// ex: eu fui no mercado comprar pão
        /// r: [8, 14, 16 ,19 ,23 ,28]
        public int[] ObterIndexAO(string str){
            var lst = new List<int>();
            var array = str.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == 'a' || array[i] == 'o')
                {
                    lst.Add(i);
                }
            }
            return lst.ToArray();
        }

        /// Inverta as palavras que tem mais de 4 caracteres
        /// ex: oi menu nome é guilherme
        /// r: oi meu nome é emrehliug
        public string InverterParteDaString(string str){
            var array = str.Split(" ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > 4)
                {
                    array[i] = string.Join("", array[i].ToCharArray().Reverse());
                }
            }
            return string.Join(" ", array);
        }

        /// mascara até os 4 ultimos caracteres ignorando os espaços
        /// ex: 123456780
        /// r: #####6780
        /// ex: 1234 56780
        /// r: #### #6780
        public string MascararString(string str){
            var array = str.ToCharArray();
            var maxIndexMask = array.Length - 4;
            for (int i = 0; i < array.Length; i++)
            {
                if(i < maxIndexMask && array[i] != ' ')
                {
                    array[i] = '#';
                }
            }
            return string.Join("", array);
        }

        /// trocar a posição de um item dentro do array, 
        /// caso o array tenha itens repetidos ou não exita o valor dentro o array
        /// retornalo sem modificar
        /// ex: [1,2,3,4,5] value: 2 newPosition: 0
        /// r: [2,1,3,4,5]
        /// ex: [2,3,1,0,10] value: 10 newPosition: 1
        /// r: [1,10,3,1,0]
        /// ex: [2, 2, 1, 3] value: 2 newPosition: 1
        /// r: [2, 2, 1, 3]
        public int[] TrocarPosicaoItem(int[] array, int value, int newPosition){
            var list = array.ToList();
            var item = list.First(e => e == value);
            list.Remove(item);
            list.Insert(newPosition, item);

            return list.ToArray();
        }

        /// reduzir os digitos de uma string até chegar a 1 digito
        /// ex: 942
        /// calc: 9 + 4 + 2 = 15  -->  1 + 5 = 6
        /// r: 6
        public int ReduzirNumerosDaString(string str){
            var arrayInt = str.ToCharArray().Select(e => int.Parse(e.ToString()));
            var result = arrayInt.Sum(e=> e);
            if (result > 9)
            {
                result = ReduzirNumerosDaString(result.ToString());
            }
            return result;
        }
    }
}
