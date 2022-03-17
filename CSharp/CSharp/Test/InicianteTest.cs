﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CSharp.Test
{
    [TestClass]
    public class InicianteTest
    {
        private readonly Iniciante objTest = new Iniciante();
        private readonly Shared shared = new Shared();

        [TestMethod]
        public void Concatenar()
        {
            var str1 = "um macaco";
            var str2 = " come banana";
            var strR = str1 + str2;
            Assert.IsTrue(objTest.Concatenar(str1, str2) == strR, shared.FormatarErro(str1 + "," + str2, strR));
        }

        [TestMethod]
        public void SepararPalavras()
        {
            var str = "Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo";
            var strR = new string[] { "Desta", "maneira,", "o", "fenômeno", "da", "Internet", "não", "pode", "mais", "se", "dissociar", "do", "processo", "de", "comunicação", "como", "um", "todo" };
            Assert.IsTrue(string.Join(",",objTest.GerarArraySeparandoTextoPorEspaco(str)) == string.Join(",", strR), shared.FormatarErro(str, string.Join(",", strR)));
        }

        [TestMethod]
        public void ContarCaracteresIgnorandoEspaco()
        {
            var str = "Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo";
            var strR = true;
            Assert.IsTrue(objTest.ContarCaracteresIgnorandoEspaco(str) == strR, shared.FormatarErro(str, strR.ToString()));
        }

        [TestMethod]
        public void AdicionarItemAUmArray()
        {
            var array = new string[] { "a", "b" };
            var str = "hhh";
            var strR = new string[] { "a", "b", "hhh" };
            Assert.IsTrue(string.Join(",", objTest.AdicionarItemNoArray(array, str)) == string.Join(",", strR),
                shared.FormatarErro(string.Join(",", array) + '+' + str, string.Join(",", strR)));
        }

        [TestMethod]
        public void RemoverItemDoArray()
        {
            var array = new string[] { "a", "b", "hhh" };
            var str = "hhh";
            var strR = new string[] { "a", "b" };
            Assert.IsTrue(string.Join(",", objTest.RemoverItemDoArray(array, str)) == string.Join(",", strR),
                shared.FormatarErro(string.Join(",", array) + '+' + str, string.Join(",", strR)));
        }

        [TestMethod]
        public void CaptalizarSimples()
        {
            var str1 = "guilherme";
            var strR = "Guilherme";
            Assert.IsTrue(objTest.CaptalizarSimples(str1) == strR, shared.FormatarErro(str1, strR));
        }

        [TestMethod]
        public void CaptalizarAvancada()
        {
            var str1 = "guilherme vai para o mercado";
            var strR = "Guilherme Vai Para O Mercado";
            Assert.IsTrue(objTest.CaptalizarAvancada(str1) == strR, shared.FormatarErro(str1, strR));
        }
    }
}
