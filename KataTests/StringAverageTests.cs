using Kata;
using NUnit.Framework;

namespace KataTests
{
    public class StringAverageTests
    {
        [Test]
        public void EmptyInput_ReturnNA() 
        {
            Assert.AreEqual("n/a", StringAverage.AverageString(""));
            Assert.AreEqual("n/a", StringAverage.AverageString(null));
            Assert.AreEqual("n/a", StringAverage.AverageString("1234"));
            Assert.AreEqual("n/a", StringAverage.AverageString("ten nine"));
        }
        [Test]
        public void ValidInput_ReturnNumString()
        {
            Assert.AreEqual("four", StringAverage.AverageString("zero nine five two"));
            Assert.AreEqual("three", StringAverage.AverageString("four six two three"));
            Assert.AreEqual("three", StringAverage.AverageString("one two three four five"));
            Assert.AreEqual("four", StringAverage.AverageString("five four"));
            Assert.AreEqual("zero", StringAverage.AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", StringAverage.AverageString("one one eight one"));
        }
    }
}
