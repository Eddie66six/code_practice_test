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
});
}