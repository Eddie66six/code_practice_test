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
    }
}
