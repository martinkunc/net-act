using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [TestFixture]
    public class Test
    {
        [TestCase(1, 2, 3)]
        public void TestCalculate(int a, int b, int c ) {
            Assert.AreEqual(c, Calculator.Calculate(a, b));
        }
    }
}
