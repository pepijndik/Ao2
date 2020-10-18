using NUnit.Framework;
using toets_testen_opdracht1;

namespace bereken_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void Test1()
        {
            bereken b1 = new bereken("a", 1, 125);
            bereken b2 = new bereken("a", 1, 100);

        

            Assert.AreEqual("55", b1.huur());
            Assert.AreEqual("50", b2.huur());
         
       
        }
  

        [Test]
        public void Test2()
        {
            bereken b3 = new bereken("b", 1, 125);
            bereken b4 = new bereken("b", 1, 100);
            Assert.AreEqual("80", b3.huur());
            Assert.AreEqual("75", b4.huur());
        }

        [Test]
        public void Test3()
        {
            bereken b5 = new bereken("c", 1, 125);
            bereken b6 = new bereken("c", 1, 100);
            Assert.AreEqual("105", b5.huur());
            Assert.AreEqual("100", b6.huur());
        }
    }
}