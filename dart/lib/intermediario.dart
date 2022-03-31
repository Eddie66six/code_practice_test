///
/// contar quantos 'a' tem em uma frase (maiúsculas e Minúsculas)
/// ex: eu fui no mercado comprar pão
/// r: 3
///
int contarCaracteresA(String str){
  return str.toLowerCase().replaceAll(r"[àáâãäå]","a").split('').where((e) => e == 'a').length;
}

///
/// contar quantos 'a' e 'o' tem em uma frase (maiúsculas e Minúsculas)
/// retornar true caso tenha a mesma quantidade de 'a' e 'o'
/// ex: eu fui no mercado comprar pão -> a: 3 o: 4
/// r: false
///
bool contarECompararCaracteresAO(String str){
  var a = str.split('').where((e) => e == 'a').length;
  var o = str.split('').where((e) => e == 'o').length;
  return a == o;
}

///
/// retornar a posição dos caracteres 'a' e 'o'
/// ex: eu fui no mercado comprar pão
/// r: [8, 14, 16 ,19 ,23 ,28]
///
List<int> obterIndexAO(String str){
  var array = str.split('');
  var result = <int>[];
  for (var i = 0; i < array.length; i++) {
    var item = array[i];
    if(item == 'a' || item == 'o'){
      result.add(i);
    }
    
  }
  return result;
}

///
/// Inverta as palavras que tem mais de 4 caracteres
/// ex: oi menu nome é guilherme
/// r: oi meu nome é emrehliug
///
String inverterParteDaString(String str){
  return str.split(' ').map((e) => e.length > 4 ? e.split('').reversed.join('') : e).join(' ');
}

///
/// mascara até os 4 ultimos caracteres ignorando os espaços
/// ex: 123456780
/// r: #####6780
/// ex: 1234 56780
/// r: #### #6780
///
String mascararString(String str){
  var array = str.split('');
  var maxIndex = array.length-4;
  var result = "";
  for (var i = 0; i < array.length; i++) {
    var item = array[i];
    if(i < maxIndex && item != " "){
      result += "#";
    }
    else{
      result += item;
    }
  }
  return result;
}

///
/// trocar a posição de um item dentro do array, 
/// caso o array tenha itens repetidos ou não exita o valor dentro o array
/// retornalo sem modificar
/// ex: [1,2,3,4,5] value: 2 newPosition: 0
/// r: [2,1,3,4,5]
/// ex: [2,3,1,0,10] value: 10 newPosition: 1
/// r: [1,10,3,1,0]
/// ex: [2, 2, 1, 3] value: 2 newPosition: 1
/// r: [2, 2, 1, 3]
///
List<int> trocarPosicaoItem(List<int> array, int value, int newPosition){
    var item = array.firstWhere((e) => e == value);
    array.remove(item);
    array.insert(newPosition, item);
    return array;
}

///
/// reduzir os digitos de uma string até chegar a 1 digito
/// ex: 942
/// calc: 9 + 4 + 2 = 15  -->  1 + 5 = 6
/// r: 6
///
int reduzirNumerosDaString(String str){
  var arrayInt = str.split('').map((e) => int.parse(e));
    var result = arrayInt.reduce((p, c) => p + c);
    if(result > 9){
        result = reduzirNumerosDaString(result.toString());
    }
    return result;
}