using System.Collections.Generic;
using System.Text.RegularExpressions;

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
            var id = Regex.Replace(
                Regex.Replace(str, @"http[s|]?:\/\/((youtu\.be\/)|www\.youtube\.com\/)(watch\?v\=)?(embed\/)?", ""),
                @"\?.*", ""
            );
            return id;
        }

        ///
        /// retornar um array com os parametro(querystring) de um url
        /// ex: https://urlQualquer?parametro=1&p=2&nome=guilherme
        /// r: {parametro: '1',nome: '2',nome: 'guilherme'}
        ///
        public Dictionary<string, string> ObterParametrosQueryString(string str){
            var param = Regex.Replace(str, @".*\?", "").Split("&");
            var result = new Dictionary<string, string>();
            foreach (var p in param)
            {
                var arrayP = p.Split("=");
                result[arrayP[0]] = arrayP[1];
            }
            return result;
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
            var result = new Dictionary<string, object[]>();
            foreach (var item in lstObj)
            {
                var val = item.GetType().GetProperty(campo).GetValue(item, null).ToString();
                if (result.ContainsKey(val))
                {
                    var lst = new object[result[val].Length + 1];
                    for (int i = 0; i < result[val].Length; i++)
                    {
                        lst[i] = result[val][i];
                    }
                    lst[lst.Length-1] = item;
                    result[val] = lst;
                }
                else
                {
                    result[val] = new object[] { item };
                }
            }
            return result;
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
            var index = -1;
            for (int i = 0; i < lstObj.Length; i++)
            {
                var props = lstObj[i].GetType().GetProperties();
                if (objBusca.GetType().GetProperties().Length != props.Length) continue;
                var equal = true;
                foreach (var prop in props)
                {
                    var valI = prop.GetValue(lstObj[i], null);
                    var valB = objBusca.GetType().GetProperty(prop.Name).GetValue(objBusca, null);
                    if(valI.ToString() != valB.ToString())
                    {
                        equal = false;
                        break;
                    }
                }
                if (equal)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        ///
        ///retorna uma lista de url encontradas dentro de uma string
        ///ex: uma macaco aqui https://imgpt.hellokids.com/_uploads/_tiny_galerie/20091044/how-to-draw-monkey-source_1a7.jpg
        ///r: ["https://imgpt.hellokids.com/_uploads/_tiny_galerie/20091044/how-to-draw-monkey-source_1a7.jpg"]
        ///
        public List<string> ObterUrlDentroDaString(string str){
            return new List<string>();
        }
    }
}