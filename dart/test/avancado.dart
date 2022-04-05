import 'dart:convert';

import 'package:dart/avancado.dart';
import 'package:test/test.dart';

import 'shared.dart';

void main() {
  group('url youtube', () {
    test('teste 1', () {
        var str = 'https://www.youtube.com/watch?v=xvQeQFfXk44';
        var strR = 'xvQeQFfXk44';
        expect(obterIdVideoYouTube(str), strR, reason: formatarErro(str, strR));
    });
    test('teste 2', () {
        var str = 'https://youtu.be/yfl8G7FnHeA';
        var strR = 'yfl8G7FnHeA';
        expect(obterIdVideoYouTube(str), strR, reason: formatarErro(str, strR));
    });
    test('teste 3', () {
        var str = 'https://youtu.be/xvQeQFfXk44?t=143';
        var strR = 'xvQeQFfXk44';
        expect(obterIdVideoYouTube(str), strR, reason: formatarErro(str, strR));
    });
    test('teste 4', () {
        var str = 'https://www.youtube.com/embed/7KLWpzHAtmc';
        var strR = '7KLWpzHAtmc';
        expect(obterIdVideoYouTube(str), strR, reason: formatarErro(str, strR));
    });
    test('teste 5', () {
        var str = 'https://www.youtube.com/embed/YXsT2waDg7U?start=143';
        var strR = 'YXsT2waDg7U';
        expect(obterIdVideoYouTube(str), strR, reason: formatarErro(str, strR));
    });
});

group('parametro url', () {
    test('teste 1', () {
        var str = 'https://urlQualquer?parametro=1&p=2&nome=guilherme';
        var strR = {'parametro': '1', 'p': '2', 'nome': 'guilherme'};
        expect(equalsObj(obterParametrosQueryString(str), strR), true,
            reason: formatarErro(str, json.encode(strR)));
    });

    test('teste 2', () {
        var str = "https://urlQualquer?novoParametro=1&p=2&nome=guilherme";
        var strR = {"nome": "guilherme", "novoParametro": "1", "p": "2"};
        expect(equalsObj(obterParametrosQueryString(str), strR), true,
            reason: formatarErro(str, json.encode(strR)));
    });
});

group('agrupamento obj', () {
    test('teste 1', () {
        var lstObj = [
            {'nome':'a', 'idade': 19, 'dataNascimento': '23/05/1991'},
            {'nome':'b', 'idade': 18, 'dataNascimento': '23/06/1991'},
            {'nome':'c', 'idade': 18, 'dataNascimento': '23/05/1991'}
        ];
        var field = 'idade';
        var strR = {
                '19': [
                    {'nome':'a', 'idade': 19, 'dataNascimento': '23/05/1991'},
                ],
                '18': [
                    {'nome':'b', 'idade': 18, 'dataNascimento': '23/06/1991'},
                    {'nome':'c', 'idade': 18, 'dataNascimento': '23/05/1991'}
                ]
            };

        expect(equalsObj(agruparObjetosPorCampo(lstObj, field), strR), true, reason: formatarErro(json.encode(lstObj), json.encode(strR)));
    });

    test('teste 2', () {
        var lstObj = [
            {'nome':'a', 'idade': 19, 'dataNascimento': '23/05/1991'},
            {'nome':'b', 'idade': 18, 'dataNascimento': '23/06/1991'},
            {'nome':'c', 'idade': 18, 'dataNascimento': '23/05/1991'}
        ];
        var field = 'dataNascimento';
        var strR = {
                '23/05/1991': [
                    {'nome':'a', 'idade': 19, 'dataNascimento': '23/05/1991'},
                    {'nome':'c', 'idade': 18, 'dataNascimento': '23/05/1991'}
                ],
                '23/06/1991': [
                    {'nome':'b', 'idade': 18, 'dataNascimento': '23/06/1991'},
                ]
            };

        expect(equalsObj(agruparObjetosPorCampo(lstObj, field), strR), true, reason: formatarErro(json.encode(lstObj), json.encode(strR)));
    });
});

group('index do obj', () {
    test('teste 1', () {
        var lstObjs = [
            {'a':1, 'b':2},
            {'a':5, 'b':10}
        ];
        var objBusca = {'a':5, 'b':10};
        var strR = 1;
        expect(obterIndexListaObj(lstObjs, objBusca), strR,
            reason: formatarErro(json.encode(lstObjs), json.encode(strR)));
    });

    test('teste 2', () {
        var lstObjs = [
            {'a':1, 'b':2},
            {'a':5, 'b':10}
        ];
        var objBusca = {'b':10};
        var strR = -1;
        expect(obterIndexListaObj(lstObjs, objBusca), strR,
            reason: formatarErro(json.encode(lstObjs), json.encode(strR)));
    });
});

group("url dentro da string", () {
    test("teste 1", () {
        var str = "uma macaco aqui https://imgpt.hellokids.com/_uploads/_tiny_galerie/20091044/how-to-draw-monkey-source_1a7.jpg";
        var strR = ["https://imgpt.hellokids.com/_uploads/_tiny_galerie/20091044/how-to-draw-monkey-source_1a7.jpg"];
        expect(equalsList(obterUrlDentroDaString(str), strR), true, reason: formatarErro(str, json.encode(strR)));
    });

    test("teste 2", () {
        var str = "um macaco aqui https://imgpt.hellokids.com/_uploads/_tiny_galerie/20091044/how-to-draw-monkey-source_1a7.jpg e outro aqui https://media.istockphoto.com/vectors/cartoon-evil-monkey-vector-id511526813?s=612x612";
        var strR = ["https://imgpt.hellokids.com/_uploads/_tiny_galerie/20091044/how-to-draw-monkey-source_1a7.jpg", "https://media.istockphoto.com/vectors/cartoon-evil-monkey-vector-id511526813?s=612x612"];
        expect(equalsList(obterUrlDentroDaString(str), strR), true, reason:  formatarErro(str, json.encode(strR)));
    });
});
}