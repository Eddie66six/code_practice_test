using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Test
{
    [TestClass]
    public class AvancadoTest
    {
        private readonly Avancado objTest = new Avancado();
        private readonly Shared shared = new Shared();

        [TestMethod]
        public void UrlYoutube()
        {
            var str = "https://www.youtube.com/watch?v=xvQeQFfXk44";
            var strR = "xvQeQFfXk44";
            Assert.IsTrue(objTest.ObterIdVideoYouTube(str) == strR, shared.FormatarErro(str, strR));

            str = "https://youtu.be/yfl8G7FnHeA";
            strR = "yfl8G7FnHeA";
            Assert.IsTrue(objTest.ObterIdVideoYouTube(str) == strR, shared.FormatarErro(str, strR));

            str = "https://youtu.be/xvQeQFfXk44?t=143";
            strR = "xvQeQFfXk44";
            Assert.IsTrue(objTest.ObterIdVideoYouTube(str) == strR, shared.FormatarErro(str, strR));

            str = "https://www.youtube.com/embed/7KLWpzHAtmc";
            strR = "7KLWpzHAtmc";
            Assert.IsTrue(objTest.ObterIdVideoYouTube(str) == strR, shared.FormatarErro(str, strR));

            str = "https://www.youtube.com/embed/YXsT2waDg7U?start=143";
            strR = "YXsT2waDg7U";
            Assert.IsTrue(objTest.ObterIdVideoYouTube(str) == strR, shared.FormatarErro(str, strR));
        }

        [TestMethod]
        public void ParametroUrl()
        {
            var str = "https://urlQualquer?parametro=1&p=2&nome=guilherme";
            var strR = new Dictionary<string, string>() {
                {"parametro", "1"}, {"p", "2"}, {"nome", "guilherme"}
            };
            Assert.IsTrue(shared.EqualsDictionary(objTest.ObterParametrosQueryString(str), strR), shared.FormatarErro(str, JsonConvert.SerializeObject(strR)));
        }

        [TestMethod]
        public void AgrupamentoObj()
        {
            var lstObj = new []{
                new { nome= "a", idade= 19, dataNascimento= "23/05/1991" },
                new { nome= "b", idade= 18, dataNascimento= "23/06/1991" },
                new { nome= "c", idade= 18, dataNascimento= "23/05/1991" }
            };
            var field = "idade";
            var strR = new Dictionary<string, object>(){
                {
                    "19", new List<Dictionary<string, object>>() {
                        new Dictionary<string, object>(){{"nome","a" }, {"idade", 19}, {"dataNascimento", "23/05/1991"}}
                    }
                },
                {
                   "18", new List<Dictionary<string, object>>() {
                        new Dictionary<string, object>(){{"nome","b" }, {"idade", 18}, {"dataNascimento", "23/06/1991"}},
                        new Dictionary<string, object>(){{"nome","c" }, {"idade", 18}, {"dataNascimento", "23/05/1991"}}
                    } 
                }
            };
            Assert.IsTrue(shared.EqualsDictionary(objTest.AgruparObjetosPorCampo(lstObj, field), strR), shared.FormatarErro(JsonConvert.SerializeObject(lstObj), JsonConvert.SerializeObject(strR)));
        }

        [TestMethod]
        public void IndexObj()
        {
            var lstObj = new []{
                new { a= 1, b = 2},
                new { a= 5, b = 10},
            };
            var objBusca = new { a= 5, b = 10};
            var strR = 1;
            Assert.IsTrue(objTest.ObterIndexListaObj(lstObj, objBusca) == strR, shared.FormatarErro(JsonConvert.SerializeObject(lstObj), strR.ToString()));
        }
    }
}
