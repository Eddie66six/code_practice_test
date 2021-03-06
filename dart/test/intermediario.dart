import "package:dart/intermediario.dart";
import "package:test/test.dart";

import "shared.dart";

void main() {
  //group("", () {});
  group("contar caracteres", () {
    test("teste 1", () {
      var str = "um macaco come banana";
      var strR = 5;
      expect(contarCaracteresA(str), strR, reason: formatarErro(str, strR.toString()));
    });
    test("teste 2", () {
      var str = "um macaco come bananaaa";
      var strR = 7;
      expect(contarCaracteresA(str), strR, reason: formatarErro(str, strR.toString()));
    });
  });

  group("contar caracteres repetidos", () {
    test("teste 1", () {
      var str = "Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo";
      var strR = false;
      expect(contarECompararCaracteresAO(str), strR, reason: formatarErro(str, strR.toString()));
    });
    test("teste 2", () {
      var str = "ao";
      var strR = true;
      expect(contarECompararCaracteresAO(str), strR, reason: formatarErro(str, strR.toString()));
    });
  });

  group("index char", () {
    test("teste 1", () {
      var str = "Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo";
      var strR = [4, 7, 12, 15, 24, 27, 40, 43, 48, 59, 62, 66, 70, 75, 81, 87, 90, 93, 95, 101, 103];
      expect(obterIndexAO(str).join("-"), strR.join("-"), reason: formatarErro(str, strR.join(",")));
    });
    test("teste 2", () {
      var str = "a";
      var strR = [0];
      expect(obterIndexAO(str).join("-"), strR.join("-"), reason: formatarErro(str, strR.join(",")));
    });
  });

  group("inversão de string", () {
    test("test 1", () {
      var str = "um macaco come banana";
      var strR = "um ocacam come ananab";
      expect(inverterParteDaString(str), strR, reason: formatarErro(str, strR));
    });
    test("test 2", () {
      var str = "Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo";
      var strR = "atseD ,arienam o onemônef da tenretnI não pode mais se raicossid do ossecorp de oãçacinumoc como um todo";
      expect(inverterParteDaString(str), strR, reason: formatarErro(str, strR));
    });
    test("test 3", () {
      var str = "só mais esse teste para garantir";
      var strR = "só mais esse etset para ritnarag";
      expect(inverterParteDaString(str), strR, reason: formatarErro(str, strR));
    });
  });

  group("mascarar string até os ultimos 4 digitos", (){
    test("test 1", () {
      var str = "123456780";
      var strR = "#####6780";
      expect(mascararString(str), strR, reason: formatarErro(str, strR));
    });
    test("trocar posicao de um item", () {
      var str = "1234 56780";
      var strR = "#### #6780";
      expect(mascararString(str), strR, reason: formatarErro(str, strR));
    });
  });

  group("trocar posicao de um item", () {
    test("teste 1", () {
      var array = [1,2,3,4,5];
      var value = 2;
      var newPosition = 0;
      var strR = [2,1,3,4,5];
      expect(trocarPosicaoItem(array,value, newPosition).join("-"), strR.join("-"), reason: formatarErro(array.join(","), strR.join(",")));
    });
    test("teste 2", () {
      var array = [1,2,3,4,5];
      var value = 5;
      var newPosition = 0;
      var strR = [5,1,2,3,4];
      expect(trocarPosicaoItem(array,value, newPosition).join("-"), strR.join("-"), reason: formatarErro(array.join(","), strR.join(",")));
    });
  });

  group("reduzir digitos de uma string", () {
    test("teste 1", () {
      var str = "942";
      var strR = 6;
      expect(reduzirNumerosDaString(str), strR, reason: formatarErro(str, strR.toString()));
    });
    test("teste 2", () {
      var str = "16";
      var strR = 7;
      expect(reduzirNumerosDaString(str), strR, reason: formatarErro(str, strR.toString()));
    });
  });
}