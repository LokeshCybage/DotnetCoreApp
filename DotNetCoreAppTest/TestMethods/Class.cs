using System;
using System.Collections.Generic;
using System.Text;
using DotNetCoreApp.BusinessLogic;
using NUnit.Framework;

namespace DotNetCoreAppTest.TestMethods
{
    class Class
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSum()
        {
            var cal = new MathClass();
            int result = cal.Sum(2, 3);
            Assert.IsTrue(result == 5);
        }
    }
}
