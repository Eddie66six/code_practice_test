import 'package:dart/iniciante.dart';
import 'package:test/test.dart';

import 'shared.dart';

void main() {
  test('concatenar', () {
    var str1 = 'um macaco';
    var str2 = ' come banana';
    var strR = str1 + str2;
    expect(concatenar(str1, str2), strR, reason: formatarErro(str1 + ',' + str2, strR.toString()));
  });

  test('separar palavras', () {
    var str = 'Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo';
    var strR = ['Desta', 'maneira,', 'o', 'fenômeno', 'da', 'Internet', 'não', 'pode', 'mais', 'se', 'dissociar', 'do', 'processo', 'de', 'comunicação', 'como', 'um', 'todo'];
    expect(gerarArraySeparandoTextoPorEspaco(str), strR, reason: formatarErro(str, strR.join(',')));
  });

  test('contar caracteres ignorando espaço', () {
    var str = 'Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo';
    var strR = true;
    expect(contarCaracteresIgnorandoEspaco(str), strR, reason: formatarErro(str, strR.toString()));
  });

  test('adicionar item a um array', () {
    var array = ['a', 'b'];
    var str = 'hhh';
    var strR = ['a', 'b', 'hhh'];
    expect(adicionarItemNoArray(array, str).join('-'), strR.join('-'), reason: formatarErro(array.join(',') + '-' + str, strR.join(',')));
  });
}