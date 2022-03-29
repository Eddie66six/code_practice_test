import 'package:dart/iniciante.dart';
import 'package:test/test.dart';

import 'shared.dart';

void main() {
  test('concatenar', () {
    var str1 = 'um macaco';
    var str2 = ' come banana';
    var strR = str1 + str2;
    expect(concatenar(str1, str2), strR, reason: formatarErro(str1 + ',' + str2, strR.toString()));

    str1 = "dois macacos";
    str2 = " comem banana";
    strR = str1 + str2;
    expect(concatenar(str1, str2), strR, reason: formatarErro(str1 + ',' + str2, strR.toString()));
  });

  test('separar palavras', () {
    var str = 'Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo';
    var strR = ['Desta', 'maneira,', 'o', 'fenômeno', 'da', 'Internet', 'não', 'pode', 'mais', 'se', 'dissociar', 'do', 'processo', 'de', 'comunicação', 'como', 'um', 'todo'];
    expect(gerarArraySeparandoTextoPorEspaco(str), strR, reason: formatarErro(str, strR.join(',')));

    str = "Desta maneira";
    strR = ["Desta", "maneira"];
    expect(gerarArraySeparandoTextoPorEspaco(str), strR, reason: formatarErro(str, strR.join(',')));
  });

  test('contar caracteres ignorando espaço', () {
    var str = 'Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo';
    var strR = true;
    expect(contarCaracteresIgnorandoEspaco(str), strR, reason: formatarErro(str, strR.toString()));

    str = "fenômeno";
    strR = false;
    expect(contarCaracteresIgnorandoEspaco(str), strR, reason: formatarErro(str, strR.toString()));
  });

  test('adicionar item a um array', () {
    var array = ['a', 'b'];
    var str = 'hhh';
    var strR = ['a', 'b', 'hhh'];
    expect(adicionarItemNoArray(array, str).join('-'), strR.join('-'), reason: formatarErro(array.join(',') + '-' + str, strR.join(',')));

    array = ["a", "b", "d"];
    str = "hhh";
    strR = ["a", "b", "d", "hhh"];
    expect(adicionarItemNoArray(array, str).join('-'), strR.join('-'), reason: formatarErro(array.join(',') + '-' + str, strR.join(',')));
  });

  test('remover item do array', () {
    var array = ['a', 'b', 'hhh'];
    var str = 'hhh';
    var strR = ['a', 'b'];
    expect(removerItemDoArray(array, str).join('-'),  strR.join('-'),
            reason: formatarErro(array.join(',') + '+' + str, strR.join(',')));
    
    array = ["a", "b", "c", "hhh"];
    str = "hhh";
    strR = ["a", "b", "c"];
    expect(removerItemDoArray(array, str).join('-'),  strR.join('-'),
            reason: formatarErro(array.join(',') + '+' + str, strR.join(',')));
  });

  test('captalizar simples', () {
      var str = 'guilherme';
      var strR = 'Guilherme';
      expect(captalizarSimples(str), strR, reason: formatarErro(str, strR));

      str = "guilerme";
      strR = "Guilerme";
      expect(captalizarSimples(str), strR, reason: formatarErro(str, strR));
  });

  test('captalizar avancada', () {
      var str = 'guilherme vai para o mercado';
      var strR = 'Guilherme Vai Para O Mercado';
      expect(captalizarAvancada(str), strR, reason: formatarErro(str, strR));

      str = "guilherme vai para o mercado 2";
      strR = "Guilherme Vai Para O Mercado 2";
      expect(captalizarAvancada(str), strR, reason: formatarErro(str, strR));
  });
}