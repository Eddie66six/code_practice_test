using System.Collections.Generic;

namespace CSharp
{
    public class Avancado
    {

        ///
        /// validar e retornar o id do video do youtube, retornor null caso a url seja invalida
        /// ex: https://www.youtube.com/watch?v=xvQeQFfXk44
        /// r: xvQeQFfXk44
        ///
        /// tipo de url
        /// https://www.youtube.com/watch?v=xvQeQFfXk55
        /// https://youtu.be/yfl8G7FnHeB
        /// https://youtu.be/xvQeQFfXk44?t=142
        /// https://www.youtube.com/embed/7KLWpzHAtnn
        /// https://www.youtube.com/embed/YXsT2waDg7U?start=123
        ///
        public string ObterIdVideoYouTube(string str){
            return "";
        }

        ///
        /// retornar um array com os parametro(querystring) de um url
        /// ex: https://urlQualquer?parametro=1&p=2&nome=guilherme
        /// r: {parametro: '1',nome: '2',nome: 'guilherme'}
        ///
        public Dictionary<string, string> ObterParametrosQueryString(string str){
            return null;
        }

        ///
        /// retornar agrupamento de obj por campo
        /// Dictionary com lista de Dictionary
        /// ex: 
        /// agrupar por anoDeNascimento
        /// [{
        ///  id: 1,
        ///  nome: 'guilherme',
        ///  anoDeNascimento: 1991,
        ///  mesNascimento: 5
        /// },
        /// {
        ///  id: 2,
        ///  nome: 'guilherme 2',
        ///  anoDeNascimento: 1990,
        ///  mesNascimento: 2
        /// },
        /// {
        ///  id: 2,
        ///  nome: 'guilherme 5',
        ///  anoDeNascimento: 1990,
        ///  mesNascimento: 5
        /// },
        /// ]
        /// r: {
        ///  1991: {
        ///      [{
        ///          id: 1,
        ///          nome: 'guilherme',
        ///          anoDeNascimento: 1991,
        ///          mesNascimento: 5
        ///      }]
        ///  }
        ///  1990: {
        ///      [{
        ///       id: 2,
        ///       nome: 'guilherme 2',
        ///       anoDeNascimento: 1990,
        ///       mesNascimento: 2
        ///      },
        ///      {
        ///       id: 2,
        ///       nome: 'guilherme 5',
        ///       anoDeNascimento: 1990,
        ///       mesNascimento: 5
        ///      }]
        ///  }
        /// }
        ///
        public Dictionary<string, object[]> AgruparObjetosPorCampo(object[] lstObj, string campo){
            return null;
        }



        ///
        /// retornar o index de um objeto no array
        /// retornar -1 caso não encontre o objeto
        /// ex: [
        ///  {a:1:b:2}
        ///  {a:5:b:10}
        /// ]
        /// objBusca: {a:1:b:2}
        /// r: 0
        ///
        public int ObterIndexListaObj(object[] lstObj, object objBusca){
            return -1;
        }

        ///
        ///retorna uma lista de url encontradas dentro de uma string
        ///ex: uma macaco aqui https://imgpt.hellokids.com/_uploads/_tiny_galerie/20091044/how-to-draw-monkey-source_1a7.jpg
        ///r: ["https://imgpt.hellokids.com/_uploads/_tiny_galerie/20091044/how-to-draw-monkey-source_1a7.jpg"]
        ///
        public string[] ObterUrlDentroDaString(string str){
            return new string[0];
        }
    }
}