using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCountTests
{
    [TestFixture]
    public class VowelCountTests
    {
        [Test]
        public void GetVowelCount_When_Null_Argument_Returns_Zero()
        {
            Assert.AreEqual(0, VowelCount.Program.GetVowelCount(null));
        }

        [Test]
        public void GetVowelCount_When_Empty_String_Argument_Returns_Zero()
        {
            Assert.AreEqual(0, VowelCount.Program.GetVowelCount(" "));
        }

        [Test]
        public void GetVowelCount_When_StringWithVowels_Argument_Returns_Count()
        {
            string str = "abracadabra";

            Assert.AreEqual(5, VowelCount.Program.GetVowelCount(str));
        }

        [Test]
        public void GetVowelCount_When_StringWithNoVowels_Argument_Returns_Zero()
        {
            string str = "crwth";

            Assert.AreEqual(0, VowelCount.Program.GetVowelCount(str));
        }
    }
}
