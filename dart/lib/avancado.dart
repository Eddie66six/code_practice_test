///
/// validar e retornar o id do video do youtube, retornor null caso a url seja invalida
/// ex: https://www.youtube.com/watch?v=xvQeQFfXk44
/// r: xvQeQFfXk44
/// tipo de url
/// https://www.youtube.com/watch?v=xvQeQFfXk55
/// https://youtu.be/yfl8G7FnHeB
/// https://youtu.be/xvQeQFfXk44?t=142
/// https://www.youtube.com/embed/7KLWpzHAtnn
/// https://www.youtube.com/embed/YXsT2waDg7U?start=123
///
///
String obterIdVideoYouTube(String str){
  var id = str.replaceAll(RegExp(r'http[s|]?:\/\/((youtu\.be\/)|www\.youtube\.com\/)(watch\?v\=)?(embed\/)?'), '')
    .replaceAll(RegExp(r'\?.*'), '');
  return id;
}

///
/// retornar um array com os parametro(querystring) de um url
/// ex: https://urlQualquer?parametro=1&p=2&nome=guilherme
/// r: {parametro: '1',nome: '2',nome: 'guilherme'}
///
Map<String, dynamic> obterParametrosQueryString(String str){
  var param = str.replaceAll(RegExp(r'.*\?'), '').split('&');
    var result = <String, dynamic>{};
    for (var p in param) {
        var arrayP = p.split('=');
        result[arrayP[0]] = arrayP[1];
    }
    return result;
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
Map<String, dynamic> agruparObjetosPorCampo(List<Map<String, dynamic>> lstObj, String campo){
  var result = <String, dynamic>{};
  for (var item in lstObj) {
    if(result[item[campo].toString()] == null){
      result[item[campo].toString()] = [item];
    }
    else{
      var currentList = (result[item[campo].toString()] as List<Map<String, dynamic>>);
      result[item[campo].toString()] = [
        ...currentList, item];
    }
  }
  return result;
}

///
/// retornar o index de um objeto no array
/// retornar -1 caso não encontre o objeto
/// ex: [
///  {a:1,b:2}
///  {a:5,b:10}
/// ]
/// objBusca: {a:1,b:2}
/// r: 0
///
int obterIndexListaObj(List<Map<String, dynamic>> lstObj, Map<String, dynamic> objBusca){
  var index = -1;
  for (var i = 0; i < lstObj.length; i++) {
    var item = lstObj[i];
    if(item.keys.length != objBusca.keys.length) continue;
    var equal = true;
    for (var key in item.keys) {
      if(item[key] != objBusca[key]){
        equal = false;
        break;
      }
    }
    if(equal){
      index = i;
      break;
    }
  }
  return index;
}