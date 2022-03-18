var assert = require("assert");
var shared = require("./shared.js");
var objTest = require("../codes/intermediario.js");

describe("contar caracteres a", function() {
    it("teste 1", function() {
        let str = "um macaco come banana";
        let strR = 5;
        assert.ok(objTest.contarCaracteresA(str) == strR, shared.formatarErro(str, strR.toString()));
    })
})

describe("contar caracteres repetidos a,o", function() {
    it("teste 1", function() {
        let str = "Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo";
        let strR = false;
        assert.ok(objTest.contarECompararCaracteresAO(str) == strR, shared.formatarErro(str, strR));
    })
})

describe("index char a,o", function() {
    it("teste 1", function() {
        let str = "Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo";
        let strR = [4, 7, 12, 27, 48, 62, 87];
        assert.ok(objTest.obterIndexAO(str).join("-") == strR.join("-"), shared.formatarErro(str, strR.join(",")));
    })
})

describe("inversão de string", function() {
    it("teste 1", function() {
        let str = "um macaco come banana";
        let strR = "um ocacam come ananab";
        assert.ok(objTest.inverterParteDaString(str) == strR, shared.formatarErro(str, strR));
    })
    it("teste 2", function() {
        let str = "Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo";
        let strR = "atseD ,arienam o onemônef da tenretnI não pode mais se raicossid do ossecorp de oãçacinumoc como um todo";
        assert.ok(objTest.inverterParteDaString(str) == strR, shared.formatarErro(str, strR));
    })
    it("teste 3", function() {
        let str = "só mais esse teste para garantir";
        let strR = "só mais esse etset para ritnarag";
        assert.ok(objTest.inverterParteDaString(str) == strR, shared.formatarErro(str, strR));
    })
})

describe("mascarar string até os ultimos 4 digitos", function() {
    it("teste 1", function() {
        let str = "123456780";
        let strR = "#####6780";
        assert.ok(objTest.mascararString(str) == strR, shared.formatarErro(str, strR));
    })
    it("teste 2", function() {
        let str = "1234 56780";
        let strR = "#### #6780";
        assert.ok(objTest.mascararString(str) == strR, shared.formatarErro(str, strR));
    })
})

describe("index char a,o", function() {
    it("teste 1", function() {
        let array = [1,2,3,4,5];
        let value = 2;
        let newPosition = 0;
        let strR = [2,1,3,4,5];
        assert.ok(objTest.trocarPosicaoItem(array,value, newPosition).join("-") == strR.join("-"), shared.formatarErro(array.join(','), strR.join(",")));
    })
})

describe("reduzir digitos de uma string", function() {
    it("teste 1", function() {
        let str = "942";
        let strR = 6;
        assert.ok(objTest.reduzirNumerosDaString(str) == strR, shared.formatarErro(str, strR));
    })
})