using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddTests
{
    [TestFixture]
    internal class EvenOrOddTests
    {
        [Test]
        public void EvenOrOdd_When_2_Argument_Returns_Even()
        {
            Assert.AreEqual("Even", EvenOrOdd.Program.EvenOrOdd(2));
        }

        [Test]
        public void EvenOrOdd_When_1_Argument_Returns_Odd()
        {
            Assert.AreEqual("Odd", EvenOrOdd.Program.EvenOrOdd(1));
        }

        [Test]
        public void EvenOrOdd_When_0_Argument_Returns_Even()
        {
            Assert.AreEqual("Even", EvenOrOdd.Program.EvenOrOdd(0));
        }

        [Test]
        public void EvenOrAdd_When_7_Argument_Returns_Odd()
        {
            Assert.AreEqual("Odd", EvenOrOdd.Program.EvenOrOdd(7));
        }

        [Test]
        public void EvenOrAdd_When_Negative1_Argument_Returns_Odd()
        {
            Assert.AreEqual("Odd", EvenOrOdd.Program.EvenOrOdd(-1));
        }
    }
}
