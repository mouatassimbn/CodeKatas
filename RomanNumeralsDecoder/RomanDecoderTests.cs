using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsDecoderTests
{
    [TestFixture]
    internal class RomanDecoderTests
    {
        [Test]
        public void Decode_When_Null_Argument_Returns_Zero()
        {
            Assert.AreEqual(0, RomanNumeralsDecoder.RemanDecoder.Decode(null));
        }

        [Test]
        public void Decode_When_MCMXC_Argument_Returns_1990()
        {
            Assert.AreEqual(1990, RomanNumeralsDecoder.RemanDecoder.Decode("MCMXC"));
        }

        [Test]
        public void Decode_When_MMVIII_Argument_Returns_2008()
        {
            Assert.AreEqual(2008, RomanNumeralsDecoder.RemanDecoder.Decode("MMVIII"));
        }

        [Test]
        public void Decode_When_MDCLXVI_Argument_Returns_1666()
        {
            Assert.AreEqual(1666, RomanNumeralsDecoder.RemanDecoder.Decode("MDCLXVI"));
        }

    }
}
