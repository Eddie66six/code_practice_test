using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;

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

            str = "https://urlQualquer?novoParametro=1&p=2&nome=guilherme";
            strR = new Dictionary<string, string>() {
                {"nome", "guilherme"}, {"novoParametro", "1"}, {"p", "2"}
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
            var strR = new Dictionary<string, object[]>(){
                {
                    "19", new [] {
                        new { nome= "a", idade= 19, dataNascimento= "23/05/1991" },
                    }
                },
                {
                   "18", new [] {
                        new { nome= "b", idade= 18, dataNascimento= "23/06/1991" },
                        new { nome= "c", idade= 18, dataNascimento= "23/05/1991" }
                   } 
                }
            };
            Assert.IsTrue(shared.EqualsDictionary(objTest.AgruparObjetosPorCampo(lstObj, field), strR), shared.FormatarErro(JsonConvert.SerializeObject(lstObj), JsonConvert.SerializeObject(strR)));

            field = "dataNascimento";
            strR = new Dictionary<string, object[]>(){
                {
                    "23/05/1991", new [] {
                        new { nome= "a", idade= 19, dataNascimento= "23/05/1991" },
                        new { nome= "c", idade= 18, dataNascimento= "23/05/1991" }
                    }
                },
                {
                   "23/06/1991", new [] {
                        new { nome= "b", idade= 18, dataNascimento= "23/06/1991" },
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

            var objBusca2 = new { b = 10};
            strR = -1;
            Assert.IsTrue(objTest.ObterIndexListaObj(lstObj, objBusca2) == strR, shared.FormatarErro(JsonConvert.SerializeObject(lstObj), strR.ToString()));
        }

        [TestMethod]
        public void UrlDentroDaString(){
            var str = "uma macaco aqui https://imgpt.hellokids.com/_uploads/_tiny_galerie/20091044/how-to-draw-monkey-source_1a7.jpg";
            var strR = new string[]{"https://imgpt.hellokids.com/_uploads/_tiny_galerie/20091044/how-to-draw-monkey-source_1a7.jpg"};
            Assert.IsTrue(shared.EqualsObj(objTest.ObterUrlDentroDaString(str), strR), shared.FormatarErro(str, JsonConvert.SerializeObject(strR)));

            str = "um macaco aqui https://imgpt.hellokids.com/_uploads/_tiny_galerie/20091044/how-to-draw-monkey-source_1a7.jpg e outro aqui https://media.istockphoto.com/vectors/cartoon-evil-monkey-vector-id511526813?s=612x612";
            strR = new string[]{"https://imgpt.hellokids.com/_uploads/_tiny_galerie/20091044/how-to-draw-monkey-source_1a7.jpg", "https://media.istockphoto.com/vectors/cartoon-evil-monkey-vector-id511526813?s=612x612"};
            Assert.IsTrue(shared.EqualsObj(objTest.ObterUrlDentroDaString(str), strR), shared.FormatarErro(str, JsonConvert.SerializeObject(strR)));
        }
    }
}
