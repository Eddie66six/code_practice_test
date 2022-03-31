///
/// concatenar os 2 parametros
/// ex: str1: moran, str2: go
/// r: morango
///
String concatenar(String str1, String str2){
  return str1+str2;
}

///
/// gerar um array separando as palavras por espaço
/// ex: mercado livre
/// r: ['mercado', 'livre']
///
List<String> gerarArraySeparandoTextoPorEspaco(String str){
  return str.split(" ");
}

///
/// verificar se um texto tem mais de 10 caracteres ignorando os espaços
/// ex: eu fui no mercado comprar pão
/// r: true
///
bool contarCaracteresIgnorandoEspaco(String str){
  return str.split(" ").any((e) => e.length > 10);
}

///
/// adicionar item no array
/// ex: array: ['a', 'b'], str: 'h'
/// r: ['a', 'b', 'h']
///
List<String> adicionarItemNoArray(List<String> array, String str){
  return array..add(str);
}

///
/// remover item do array
/// ex: array: ['a', 'b', 'h'], str: 'h'
/// r: ['a', 'b']
///
List<String> removerItemDoArray(List<String >array, String str){
  return array..remove(str);
}

///
/// alterar a primeira letra da palavra para maiuscula
/// ex: guilherme
/// r: Guilherme
///
String captalizarSimples(String str){
  return str.substring(0,1).toUpperCase() + str.substring(1);
}

///
/// alterar todas sa primeiras letras das palavras para maiuscula
/// ex: guilherme vai para o mercado
/// r: Guilherme Vai Para O Mercado
///
String captalizarAvancada(String str){
  return str.split(" ").map((e) => e.substring(0,1).toUpperCase() + e.substring(1)).join(" ");
}