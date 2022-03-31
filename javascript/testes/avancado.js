var assert = require("assert");
var shared = require("./shared.js");
var objTest = require("../codes/avancado.js");

describe("url youtube", function() {
    it("teste 1", function() {
        let str = "https://www.youtube.com/watch?v=xvQeQFfXk44";
        let strR = "xvQeQFfXk44";
        assert.ok(objTest.obterIdVideoYouTube(str) == strR, shared.formatarErro(str, strR));
    })
    it("teste 2", function() {
        let str = "https://youtu.be/yfl8G7FnHeA";
        let strR = "yfl8G7FnHeA";
        assert.ok(objTest.obterIdVideoYouTube(str) == strR, shared.formatarErro(str, strR));
    })
    it("teste 3", function() {
        let str = "https://youtu.be/xvQeQFfXk44?t=143";
        let strR = "xvQeQFfXk44";
        assert.ok(objTest.obterIdVideoYouTube(str) == strR, shared.formatarErro(str, strR));
    })
    it("teste 4", function() {
        let str = "https://www.youtube.com/embed/7KLWpzHAtmc";
        let strR = "7KLWpzHAtmc";
        assert.ok(objTest.obterIdVideoYouTube(str) == strR, shared.formatarErro(str, strR));
    })
    it("teste 5", function() {
        let str = "https://www.youtube.com/embed/YXsT2waDg7U?start=143";
        let strR = "YXsT2waDg7U";
        assert.ok(objTest.obterIdVideoYouTube(str) == strR, shared.formatarErro(str, strR));
    })
})

describe("parametro url", function() {
    it("teste 1", function() {
        let str = "https://urlQualquer?parametro=1&p=2&nome=guilherme";
        let strR = {nome: "guilherme", parametro: "1", p: "2"};
        assert.ok(shared.equalsObj(objTest.obterParametrosQueryString(str), strR),
            shared.formatarErro(str, JSON.stringify(strR)));
    })

    it("teste 2", function() {
        let str = "https://urlQualquer?novoParametro=1&p=2&nome=guilherme";
        let strR = {nome: "guilherme", novoParametro: "1", p: "2"};
        assert.ok(shared.equalsObj(objTest.obterParametrosQueryString(str), strR),
            shared.formatarErro(str, JSON.stringify(strR)));
    })
})

describe("agrupamento obj", function() {
    it("teste 1", function() {
        let lstObj = [
            {"nome":"a", "idade": 19, "dataNascimento": "23/05/1991"},
            {"nome":"b", "idade": 18, "dataNascimento": "23/06/1991"},
            {"nome":"c", "idade": 18, "dataNascimento": "23/05/1991"}
        ];
        let field = "idade";
        let strR = {
                "19": [
                    {"nome":"a", "idade": 19, "dataNascimento": "23/05/1991"},
                ],
                "18": [
                    {"nome":"b", "idade": 18, "dataNascimento": "23/06/1991"},
                    {"nome":"c", "idade": 18, "dataNascimento": "23/05/1991"}
                ]
            };
        assert.ok(shared.equalsObj(objTest.agruparObjetosPorCampo(lstObj, field), strR), shared.formatarErro(JSON.stringify(lstObj), JSON.stringify(strR)));
    })

    it("teste 2", function() {
        let lstObj = [
            {"nome":"a", "idade": 19, "dataNascimento": "23/05/1991"},
            {"nome":"b", "idade": 18, "dataNascimento": "23/06/1991"},
            {"nome":"c", "idade": 18, "dataNascimento": "23/05/1991"}
        ];
        let field = "dataNascimento";
        let strR = {
                "23/05/1991": [
                    {"nome":"a", "idade": 19, "dataNascimento": "23/05/1991"},
                    {"nome":"c", "idade": 18, "dataNascimento": "23/05/1991"}

                ],
                "23/06/1991": [
                    {"nome":"b", "idade": 18, "dataNascimento": "23/06/1991"},
                ]
            };
        assert.ok(shared.equalsObj(objTest.agruparObjetosPorCampo(lstObj, field), strR), shared.formatarErro(JSON.stringify(lstObj), JSON.stringify(strR)));
    })
})

describe("index do obj", function() {
    it("teste 1", function() {
        let lstObjs = [
            {"a":1, "b":2},
            {"a":5, "b":10}
        ];
        let objBusca = {"a":5, "b":10};
        let strR = 1;
        assert.ok(objTest.obterIndexListaObj(lstObjs, objBusca) == strR,
            shared.formatarErro(JSON.stringify(lstObjs), strR));
    })

    it("teste 2", function() {
        let lstObjs = [
            {"a":1, "b":2},
            {"a":5, "b":10}
        ];
        let objBusca = {"b":10};
        let strR = -1;
        assert.ok(objTest.obterIndexListaObj(lstObjs, objBusca) == strR,
            shared.formatarErro(JSON.stringify(lstObjs), strR));
    })
})