namespace CSharp
{
    public class Intermediario
    {
        /// contar quantos 'a' tem em uma frase (maiúsculas e Minúsculas)
        /// ex: eu fui no mercado comprar pão
        /// r: 3
        public int ContarCaracteresA(string str){
            return 0;
        }

        /// contar quantos 'a' e 'o' tem em uma frase (maiúsculas e Minúsculas)
        /// retornar true caso tenha a mesma quantidade de 'a' e 'o'
        /// ex: eu fui no mercado comprar pão -> a: 3 o: 4
        /// r: false
        public bool ContarECompararCaracteresAO(string str){
            return false;
        }

        /// retornar a posição dos caracteres 'a' e 'o'
        /// ex: eu fui no mercado comprar pão
        /// r: [8, 14, 16 ,19 ,23 ,28]
        public int[] ObterIndexAO(string str){
            return new int[0];
        }

        /// Inverta as palavras que tem mais de 4 caracteres
        /// ex: oi menu nome é guilherme
        /// r: oi meu nome é emrehliug
        public string InverterParteDaString(string str){
            return "";
        }

        /// mascara até os 4 ultimos caracteres ignorando os espaços
        /// ex: 123456780
        /// r: #####6780
        /// ex: 1234 56780
        /// r: #### #6780
        public string MascararString(string str){
            return "";
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
            return new int[0];
        }

        /// reduzir os digitos de uma string até chegar a 1 digito
        /// ex: 942
        /// calc: 9 + 4 + 2 = 15  -->  1 + 5 = 6
        /// r: 6
        public int ReduzirNumerosDaString(string str){
            return -1;
        }
    }
}
