using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Test
{
    [TestClass]
    public class IntermediarioTest
    {
        private readonly Intermediario objTest = new Intermediario();
        private readonly Shared shared = new Shared();

        [TestMethod]
        public void ContarCaracteres()
        {
            var str = "um macaco come banana";
            var strR = 5;
            Assert.IsTrue(objTest.ContarCaracteresA(str) == strR, shared.FormatarErro(str, strR.ToString()));
        }

        [TestMethod]
        public void ContarCaracteresRepetidos()
        {
            var str = "Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo";
            var strR = false;
            Assert.IsTrue(objTest.ContarECompararCaracteresAO(str) == strR, shared.FormatarErro(str, strR.ToString()));
        }

        [TestMethod]
        public void IndexChar()
        {
            var str = "Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo";
            var strR = new int[]{4, 7, 12, 27, 48, 62, 87};
            Assert.IsTrue(string.Join(",", objTest.ObterIndexAO(str)) == string.Join(",", strR), shared.FormatarErro(str, string.Join(",", strR)));
        }

        [TestMethod]
        public void InversãoDeString()
        {
            var str = "um macaco come banana";
            var strR = "um ocacam come ananab";
            Assert.IsTrue(objTest.InverterParteDaString(str) == strR, shared.FormatarErro(str, strR));

            str = "Desta maneira, o fenômeno da Internet não pode mais se dissociar do processo de comunicação como um todo";
            strR = "atseD ,arienam o onemônef da tenretnI não pode mais se raicossid do ossecorp de oãçacinumoc como um todo";
            Assert.IsTrue(objTest.InverterParteDaString(str) == strR, shared.FormatarErro(str, strR));

            str = "só mais esse teste para garantir";
            strR = "só mais esse etset para ritnarag";
            Assert.IsTrue(objTest.InverterParteDaString(str) == strR, shared.FormatarErro(str, strR));
        }

        [TestMethod]
        public void MascararStringAteOsUltimos4Digitos()
        {
            var str = "123456780";
            var strR = "#####6780";
            Assert.IsTrue(objTest.MascararString(str) == strR, shared.FormatarErro(str, strR));

            str = "1234 56780";
            strR = "#### #6780";
            Assert.IsTrue(objTest.InverterParteDaString(str) == strR, shared.FormatarErro(str, strR));
        }

        [TestMethod]
        public void TrocarPosicaoSeUmItem()
        {
            var array = new int[]{1,2,3,4,5};
            var value = 2;
            var newPosition = 0;
            var strR = new int[]{2,1,3,4,5};
            Assert.IsTrue(string.Join(",", 
                objTest.TrocarPosicaoItem(array, value, newPosition)) == string.Join(",", strR),
                    shared.FormatarErro(string.Join(",", array), string.Join(",", strR)));
        }

        [TestMethod]
        public void ReduzirDigitosDeUmaString()
        {
            var str = "942";
            var strR = 6;
            Assert.IsTrue(objTest.ReduzirNumerosDaString(str) == strR, shared.FormatarErro(str, strR.ToString()));
        }
    }
}
