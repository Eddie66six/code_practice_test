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
    }
}
