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
    public class Sq
    {
        [SetUp]
        public void SqTestStart()
        {
        }
        static object[] SqVariables =
        {
            new object []  {0},
            new object []  {1},
            new object []  {2},
            new object []  {3},
            new object []  {4},
            new object []  {5},
            new object []  {6},
            new object []  {7},
            new object []  {8},
            new object []  {9},
            new object []  {10},
            new object []  {11},
            new object []  {12},
            new object []  {13},
            new object []  {14},
            new object []  {15},
            new object []  {16},
            new object []  {17},
            new object []  {18},
            new object []  {19},
            new object []  {20},
            new object []  {21},
            new object []  {22},
            new object []  {23},
            new object []  {24},
            new object []  {25},
            new object []  {26},
            new object []  {27},
            new object []  {28},
            new object []  {29},
            new object []  {30},

        };
        static object[] SqNegVariables =
       {
            new object [] { -10 },
        };

        [Test, TestCaseSource("SqVariables")]

        public void TestSqS(int a)
        {
            Square aa = new Square(a);
            Assert.AreEqual(aa.getAreaSquare(), Math.Pow(a, 2), 0.01, "Using  positive int number.Result differs from the expected one.Formula S for Square is incorrect.");
        }

        [Test, TestCaseSource("SqVariables")]
        public void TestSqP(int a)
        {
            Square aa = new Square(a);
            Assert.AreEqual(aa.getLengthSquare(), (4 * a), 0.01, "Using  positive int number.Result differs from the expected one.Formula P for Square is incorrect.");
        }
        [Test, TestCaseSource("SqNegVariables")]

        public void NegTestSqS(int a)
        {
            Square aa = new Square(a);
            Assert.AreEqual(aa.getAreaSquare(), Math.Pow(a, 2), 0.01, "Using  negative int number.The program shouldn`t accept negative numbers");
        }

        [Test, TestCaseSource("SqNegVariables")]
        public void NegTestSqP(int a)
        {
            Square aa = new Square(a);
            Assert.AreEqual(aa.getLengthSquare(), (4 * a), 0.01, "Using  negative int number.The program shouldn`t accept negative numbers");
        }
    }
}