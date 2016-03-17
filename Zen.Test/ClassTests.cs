using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Zen.Core.Interfaces;

namespace Zen.Test
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void GetPropertiesTest()
        {
            var testClass = Substitute.For<IZClass>();
            testClass.Properties.Returns(new IZProperty[] { });
            Assert.AreEqual(0, testClass.Properties.Length);
        }
    }
}
