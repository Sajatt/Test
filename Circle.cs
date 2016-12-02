using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using GeometricFigures;

namespace Tests1
{

    [TestFixture]
    public class NUnitTestFixture
    {
        [SetUp]
        public void TestStart()
        {
        }
        static object[] Variables =
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
        static object[] NegVariables =
       {
            new object [] { -2 },
        };

        [Test, TestCaseSource("Variables")]

        public void TestCircleS(int a)
        {
            Circle c = new Circle(a);
            Assert.AreEqual(c.getAreaCircle(), Math.Pow(Math.PI * a, 2), 0.01, "Using  positive int number.Result differs from the expected one.Formula S for Circle is incorrect.");
        }

        [Test, TestCaseSource("Variables")]
        public void TestCircleP(int a)
        {
            Circle c = new Circle(a);
            Assert.AreEqual(c.getLengthCircle(), (Math.PI * a) * 2, 0.01, "Using  positive int number.Result differs from the expected one.Formula P for Circle is incorrect.") ;
        }

        [Test, TestCaseSource("NegVariables")]

        public void NegTestCircleS(int a)
        {
            Circle c = new Circle(a);
            Assert.IsTrue(c.getAreaCircle() > 0, "Using  negative int number.The program shouldn`t accept negative numbers");

        }

        [Test, TestCaseSource("NegVariables")]
        public void NegTestCircleP(int a)
        {
            Circle c = new Circle(a);
            Assert.IsTrue(c.getLengthCircle() > 0, "Using  negative int number.The program shouldn`t accept negative numbers");
            
        }


    }
}

