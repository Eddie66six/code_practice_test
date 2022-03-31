/**
 * concatenar os 2 parametros
 * ex: str1: moran, str2: go
 * r: morango
*/
function concatenar(str1, str2){
    return str1 + str2;
}

/**
 * gerar um array separando as palavras por espaço
 * ex: mercado livre
 * r: ['mercado', 'livre']
*/
function gerarArraySeparandoTextoPorEspaco(str){
    return str.split(' ');
}

/**
 * verificar se um texto tem mais de 10 caracteres ignorando os espaços
 * ex: eu fui no mercado comprar pão
 * r: true
*/
function contarCaracteresIgnorandoEspaco(str){
    return str.replace(' ', '').split('').length > 10;
}

/**
 * adicionar item no array
 * ex: array: ['a', 'b'], str: 'h'
 * r: ['a', 'b', 'h']
*/
function adicionarItemNoArray(array, str){
    array.push(str);
    return array;
}

/**
 * remover item do array
 * ex: array: ['a', 'b', 'h'], str: 'h'
 * r: ['a', 'b']
*/
function removerItemDoArray(array, str){
    var index = array.indexOf(str);
    if(index > -1) array.splice(index, 1);
    return array;
}

/**
 * alterar a primeira letra da palavra para maiuscula
 * ex: guilherme
 * r: Guilherme
*/
function captalizarSimples(str){
    return str.substring(0, 1).toUpperCase() + str.substring(1);
}

/**
 * alterar todas as primeiras letras das palavras para maiuscula
 * ex: guilherme vai para o mercado
 * r: Guilherme Vai Para O Mercado
*/
function captalizarAvancada(str){
    var array = str.split(' ');
    for (let index = 0; index < array.length; index++) {
        array[index] = array[index].substring(0, 1).toUpperCase() + array[index].substring(1);
    }
    return array.join(' ');
}


exports.concatenar = concatenar;
exports.gerarArraySeparandoTextoPorEspaco = gerarArraySeparandoTextoPorEspaco;
exports.contarCaracteresIgnorandoEspaco = contarCaracteresIgnorandoEspaco;
exports.adicionarItemNoArray = adicionarItemNoArray;
exports.removerItemDoArray = removerItemDoArray;
exports.captalizarSimples = captalizarSimples;
exports.captalizarAvancada = captalizarAvancada;