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
        public Dictionary<string, object> AgruparObjetosPorCampo(object[] lstObj, string campo){
        return null;
        }

        ///
        /// retornar um array com os parametro(querystring) de um url
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
    }
}