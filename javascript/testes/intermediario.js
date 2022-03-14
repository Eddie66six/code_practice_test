var assert = require('assert');
var shared = require('./shared.js');
var objTest = require('../codes/intermediario.js');

describe('contar caracteres', function() {
    it('teste 1', function() {
        let str = 'um macaco come banana';
        let strR = 5;
        assert.ok(objTest.contarCaracteresA(str) == strR, shared.formatarErro(str, strR.toString()));
    })
})

describe('contar caracteres repetidos', function() {
    it('teste 1', function() {
        let str = 'Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo';
        let strR = true;
        assert.ok(objTest.contarECompararCaracteresAO(str) == strR, shared.formatarErro(str, strR));
    })
})

describe('index char', function() {
    it('teste 1', function() {
        let str = 'Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo';
        let strR = [4,7,12,15,24,27,40,43,48,59,62,66,70,75,81,87,90,93,95,101,103];
        assert.ok(objTest.obterIndexAO(str).join('-') == strR.join('-'), shared.formatarErro(str, strR.join(',')));
    })
})

describe('inversão de string', function() {
    it('teste 1', function() {
        let str = 'um macaco come banana';
        let strR = 'um ocacam come ananab';
        assert.ok(objTest.inverterParteDaString(str) == strR, shared.formatarErro(str, strR));
    })
    it('teste 2', function() {
        let str = 'Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo';
        let strR = 'atseD ,arienam o onemônef da tenretnI não pode mais se raicossid do ossecorp de oãçacinumoc como um todo';
        assert.ok(objTest.inverterParteDaString(str) == strR, shared.formatarErro(str, strR));
    })
    it('teste 3', function() {
        let str = 'só mais esse teste para garantir';
        let strR = 'só mais esse etset para ritnarag';
        assert.ok(objTest.inverterParteDaString(str) == strR, shared.formatarErro(str, strR));
    })
})