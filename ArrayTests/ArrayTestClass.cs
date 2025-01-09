using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using ArrayLibrary;

namespace ArrayTests
{
    [TestClass]
    public class ArrayTestClass
    {
        private readonly ArrayClass _exercises;

        public ArrayTestClass()
        {
            _exercises = new ArrayClass();
        }

        [TestMethod]
        [DataRow()]
        public void Should()
        {

        }
    }
}