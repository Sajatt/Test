using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GeometricFigures;

namespace Tests1
{

    [TestFixture]
    public class Tri
    {
        [SetUp]
        public void TriTestStart()
        {
        }
        static object[] TriVariables =
        {
            new object []  {1, 1, 1 },
            new object []  {2, 2, 2 },
            new object []  {3, 3, 3 },
            new object []  {4, 4, 4 },
            new object []  {5, 5, 5 },
            new object []  {6, 6, 6},
            new object []  {7, 7, 7 },
            new object []  {8, 8, 9 },
            new object []  {10, 10, 10 },
            new object []  {20, 20, 20 },
            new object []  {30, 30, 30 },
            
        };
        static object[] TriNegVariables =
       {
            new object [] { -10, -2, -5 },
        };

        [Test, TestCaseSource("TriVariables")]

        public void TestTriS(int a, int b, int c)
        {
            Triangle aa = new Triangle(a, b, c);
            double p = (a + b + c) / 2;
            Assert.AreEqual(aa.getAreaTriangle(), Math.Pow((p * (p - a) * (p - b) * (p - c)), 0.5), 0.01, "Using 3 equal positive int numbers.Result differs from the expected one. Formula S for Triangle is incorrect.");
        }
        [Test, TestCaseSource("TriVariables")]

        public void TestTriP(int a, int b, int c)
        {
            Triangle aa = new Triangle(a, b, c);
            Assert.AreEqual(aa.getLengthTriangle(), (a + b + c), 0.01, "Using 3 equal positive int numbers.Result differs from the expected one. Formula P for Triangle is incorrect.");
        }

        [Test, TestCaseSource("TriNegVariables")]
        public void NegTestTriP(int a, int b, int c)
        {
            Triangle aa = new Triangle(a, b, c);
            Assert.IsTrue(aa.getLengthTriangle() > 0, "Using 3 negative int numbers. The program shouldn`t accept negative numbers");
        }
        [Test, TestCaseSource("TriNegVariables")]
        public void NegTestTriS(int a, int b, int c)
        {
            Triangle aa = new Triangle(a, b, c);
            Assert.IsTrue(aa.getAreaTriangle() > 0, "Using 3 negative int numbers. The program shouldn`t accept negative numbers");
        }
    }
}
