using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANeedleInTheHaystackTests
{
    [TestFixture]
    internal class ANeedleInTheHaystackTests
    {
        [Test]
        public void FindNeedle_When_Null_Argument_Returns_NotFound()
        {
            Assert.AreEqual("needle not found", ANeedleInTheHaystack.Program.FindNeedle(null));
        }

        [Test]
        public void FindNeedle_When_NoNeedle_Argument_Returns_NotFound()
        {
            var haystack = new Object[] { "283497238987234", "a dog", "a cat", "some random junk", "a piece of hay", "something somebody lost a while ago" };
            Assert.AreEqual("needle not found", ANeedleInTheHaystack.Program.FindNeedle(haystack));
        }

        [Test]
        public void FindNeedle_When_Needle3rdIndex_Argument_Returns_Index()
        {
            var haystack = new Object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
            Assert.AreEqual("found the needle at position 3", ANeedleInTheHaystack.Program.FindNeedle(haystack));
        }

        [Test]
        public void FindNeedle_When_Needle5thIndex_Argument_Returns_Index()
        {
            var haystack = new Object[] { "283497238987234", "a dog", "a cat", "some random junk", "a piece of hay", "needle", "something somebody lost a while ago" };
            Assert.AreEqual("found the needle at position 5", ANeedleInTheHaystack.Program.FindNeedle(haystack));
        }

        [Test]
        public void FindNeedle_When_Needle30thIndex_Argument_Returns_Index()
        {
            var haystack = new Object[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 7, 5, 4, 3, 4, 5, 6, 67, 5, 5, 3, 3, 4, 2, 34, 234, 23, 4, 234, 324, 324, "needle", 1, 2, 3, 4, 5, 5, 6, 5, 4, 32, 3, 45, 54 };
            Assert.AreEqual("found the needle at position 30", ANeedleInTheHaystack.Program.FindNeedle(haystack));
        }
    }
}
