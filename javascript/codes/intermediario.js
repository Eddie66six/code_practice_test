/**
 * contar quantos 'a' tem em uma frase (maiúsculas e Minúsculas)
 * ex: eu fui no mercado comprar pão
 * r: 3
*/
function contarCaracteresA(str){
    return str.toLowerCase().replace(/[àáâãäå]/,"a").split('').filter((e)=> e == 'a').length;
}

/**
 * contar quantos 'a' e 'o' tem em uma frase (maiúsculas e Minúsculas)
 * retornar true caso tenha a mesma quantidade de 'a' e 'o'
 * ex: eu fui no mercado comprar pão -> a: 3 o: 4
 * r: false
*/
function contarECompararCaracteresAO(str){
    var a = str.split('').filter((e) => e == 'a').length;
    var o = str.split('').filter((e) => e == 'o').length;
    return a == o;
}

/**
 * retornar a posição dos caracteres 'a' e 'o'
 * ex: eu fui no mercado comprar pão
 * r: [8, 14, 16 ,19 ,23 ,28]
*/
function obterIndexAO(str){
    return str.split('').map((e, i) => e == 'a' || e == 'o' ? i : undefined).filter((e) => e || e == 0);
}

/**
 * Inverta as palavras que tem mais de 4 caracteres
 * ex: oi menu nome é guilherme
 * r: oi meu nome é emrehliug
*/
function inverterParteDaString(str){
    return str.split(' ').map((e) => e.length > 4 ? e.split('').reverse().join('') : e).join(' ');
}

/**
 * mascara até os 4 ultimos caracteres ignorando os espaços
 * ex: 123456780
 * r: #####6780
 * ex: 1234 56780
 * r: #### #6780
*/
function mascararString(str){
    return str.split('').map((e, i) => i < str.length -4 && e != ' ' ? '#' : e).join('');
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
    var index = array.indexOf(value);
    if(index > -1){
        var item = array[index];
        array.splice(index, 1);
        array.splice(newPosition, 0, item);
    }
    return array;
}

/**
 * reduzir os digitos de uma string até chegar a 1 digito
 * ex: 942
 * r:: 9 + 4 + 2 = 15  -->  1 + 5 = 6
*/
function reduzirNumerosDaString(str){
    var arrayInt = str.split('').map((e) => parseInt(e));
    var result = arrayInt.reduce((p, c) => p + c);
    if(result > 9){
        result = reduzirNumerosDaString(result.toString());
    }
    return result;
}




exports.contarCaracteresA = contarCaracteresA;
exports.contarECompararCaracteresAO = contarECompararCaracteresAO;
exports.obterIndexAO = obterIndexAO;
exports.inverterParteDaString = inverterParteDaString;
exports.mascararString = mascararString;
exports.trocarPosicaoItem = trocarPosicaoItem;
exports.reduzirNumerosDaString = reduzirNumerosDaString;