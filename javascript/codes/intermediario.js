/**
 * contar quantos 'a' tem em uma frase (maiúsculas e Minúsculas)
 * ex: eu fui no mercado comprar pão
 * r: 3
*/
function contarCaracteresA(str){
}

/**
 * contar quantos 'a' e 'o' tem em uma frase (maiúsculas e Minúsculas)
 * retornar true caso tenha a mesma quantidade de 'a' e 'o'
 * ex: eu fui no mercado comprar pão -> a: 3 o: 4
 * r: false
*/
function contarECompararCaracteresAO(str){
}

/**
 * retornar a posição dos caracteres 'a' e 'o'
 * ex: eu fui no mercado comprar pão
 * r: [8, 14, 16 ,19 ,23 ,28]
*/
function obterIndexAO(str){
}

/**
 * Inverta as palavras que tem mais de 4 caracteres
 * ex: oi menu nome é guilherme
 * r: oi meu nome é emrehliug
*/
function inverterParteDaString(str){
}

/**
 * mascara até os 4 ultimos caracteres ignorando os espaços
 * ex: 123456780
 * r: #####6780
 * ex: 1234 56780
 * r: #### #6780
*/
function mascararString(str){
}


/**
 * trocar a posição de um item dentro do array, 
 * caso o array tenha itens repetidos ou não exita o valor dentro o array
 * retornalo sem modificar
 * ex: [1,2,3,4,5] value: 2 newPosition: 0
 * r: [2,1,3,4,5]
 * ex: [2,3,1,0,10] value: 10 newPosition: 1
 * r: [1,10,3,1,0]
 * ex: [2, 2, 1, 3] value: 2 newPosition: 1
 * r: [2, 2, 1, 3]
*/
function trocarPosicaoItem(array, value, newPosition){
}




exports.contarCaracteresA = contarCaracteresA;
exports.contarECompararCaracteresAO = contarECompararCaracteresAO;
exports.obterIndexAO = obterIndexAO;
exports.inverterParteDaString = inverterParteDaString;
exports.mascararString = mascararString;