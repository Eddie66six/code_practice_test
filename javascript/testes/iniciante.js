var assert = require('assert');
var shared = require('./shared.js');
var objTest = require('../codes/iniciante.js');

describe('concatenar', function() {
    it('teste 1', function() {
        let str1 = 'um macaco';
        let str2 = ' come banana';
        let strR = str1 + str2;
        assert.ok(objTest.concatenar(str1, str2) == strR, shared.formatarErro(str1 + ',' + str2, strR.toString()));
    })
})

describe('separar palavras', function() {
    it('teste 1', function() {
        let str = 'Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo';
        let strR = ['Desta', 'maneira,', 'o', 'fenômeno', 'da', 'Internet', 'não', 'pode', 'mais', 'se', 'dissociar', 'do', 'processo', 'de', 'comunicação', 'como', 'um', 'todo'];
        assert.ok(objTest.gerarArraySeparandoTextoPorEspaco(str) == strR, shared.formatarErro(str, strR.join(',')));
    })
})

describe('contar caracteres ignorando espaço', function() {
    it('teste 1', function() {
        let str = 'Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo';
        let strR = 87;
        assert.ok(objTest.contarCaracteresIgnorandoEspaco(str) == strR, shared.formatarErro(str, strR.toString()));
    })
})

describe('adicionar item a um array', function() {
    it('teste 1', function() {
        let array = ['a', 'b'];
        let str = 'hhh';
        let strR = ['a', 'b', 'hhh'];
        assert.ok(objTest.adicionarItemNoArray(array, str) == strR, 
            shared.formatarErro(array.join(',') + '-' + str, strR));
    })
})