/**
 * validar e retornar o id do video do youtube, retornor null caso a url seja invalida
 * ex: https://www.youtube.com/watch?v=xvQeQFfXk44
 * r: xvQeQFfXk44
 * 
 * tipo de url
 * https://www.youtube.com/watch?v=xvQeQFfXk55
 * https://youtu.be/yfl8G7FnHeB
 * https://youtu.be/xvQeQFfXk44?t=142
 * https://www.youtube.com/embed/7KLWpzHAtnn
 * https://www.youtube.com/embed/YXsT2waDg7U?start=123
 * 
*/
function obterIdVideoYouTube(str){
    return str.replace(/http[s|]?:\/\/((youtu\.be\/)|www\.youtube\.com\/)(watch\?v\=)?(embed\/)?/, '')
    .replace(/\?.*/, '');
}

/**
 * retornar um array com os parametro(querystring) de um url
 * ex: https://urlQualquer?parametro=1&p=2&nome=guilherme
 * r: {parametro: '1',nome: '2',nome: 'guilherme'}
*/
function obterParametrosQueryString(str){
    var param = str.replace(/.*\?/, '').split('&');
    var result = {};
    for (const p in param) {
        var arrayP = p.split('=');
        result[arrayP[0]] = arrayP[1];
    }
    return result;
}

/**
 * retornar agrupamento de obj por campo
 * ex: 
 * agrupar por anoDeNascimento
 * [{
 *  id: 1,
 *  nome: 'guilherme',
 *  anoDeNascimento: 1991,
 *  mesNascimento: 5
 * },
 * {
 *  id: 2,
 *  nome: 'guilherme 2',
 *  anoDeNascimento: 1990,
 *  mesNascimento: 2
 * },
 * {
 *  id: 2,
 *  nome: 'guilherme 5',
 *  anoDeNascimento: 1990,
 *  mesNascimento: 5
 * },
 * ]
 * r: {
 *  1991: {
 *      [{
 *          id: 1,
 *          nome: 'guilherme',
 *          anoDeNascimento: 1991,
 *          mesNascimento: 5
 *      }]
 *  }
 *  1990: {
 *      [{
 *       id: 2,
 *       nome: 'guilherme 2',
 *       anoDeNascimento: 1990,
 *       mesNascimento: 2
 *      },
 *      {
 *       id: 2,
 *       nome: 'guilherme 5',
 *       anoDeNascimento: 1990,
 *       mesNascimento: 5
 *      }]
 *  }
 * }
*/
function agruparObjetosPorCampo(lstObj, campo){
    var group = {};
    for (let index = 0; index < lstObj.length; index++) {
        const obj = lstObj[index];
        let val = obj[campo];
        if(group[val]){
            group[val].push(obj)
        }
        else{
            group[val] = [obj];
        }
        
    }
    return group;
}

/**
 * retornar o index de um objeto no array
 * retornar -1 caso não encontre o objeto
 * ex: [
 *  {a:1:b:2}
 *  {a:5:b:10}
 * ]
 * objBusca: {a:1:b:2}
 * r: 0
*/
function obterIndexListaObj(lstObj, objBusca){
    var keys = Object.keys(objBusca);
    for (let index = 0; index < lstObj.length; index++) {
        const obj = lstObj[index];
        if(Object.keys(obj).length != keys.length) continue;

        let found = true;
        for (let indexK = 0; indexK < keys.length; indexK++) {
            const key = keys[indexK];
            if(objBusca[key] != obj[key]){
                found = false;
                break;
            }
        }
        if(found){
            return index;
        }
    }
    return -1;
}

/**
 * retorna uma lista de url encontradas dentro de uma string
 * ex: uma macaco aqui https://imgpt.hellokids.com/_uploads/_tiny_galerie/20091044/how-to-draw-monkey-source_1a7.jpg
 * r: ["https://imgpt.hellokids.com/_uploads/_tiny_galerie/20091044/how-to-draw-monkey-source_1a7.jpg"]
*/
function obterUrlDentroDaString(str){
    // RegExp regExp = RegExp(
    //     r"(((http|https)\:\/\/)|(www\.)(.+\.)|[a-z\d]+\.)[^\s()]+",
    //     caseSensitive: false,
    //     multiLine: true,
    //   );
    //   var lst = <String>[];
    //   regExp.allMatches(this).forEach((math) => lst.add(substring(math.start, math.end)));
    //   return lst;
}


exports.obterIdVideoYouTube = obterIdVideoYouTube;
exports.obterParametrosQueryString = obterParametrosQueryString;
exports.agruparObjetosPorCampo = agruparObjetosPorCampo;
exports.obterIndexListaObj = obterIndexListaObj;
exports.obterUrlDentroDaString = obterUrlDentroDaString;