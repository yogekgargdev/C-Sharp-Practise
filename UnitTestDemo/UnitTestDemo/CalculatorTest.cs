using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using CalculatorDemo;

namespace UnitTestDemo
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator c = null;
        public CalculatorTest()
        {
            Console.WriteLine("Constructor Executed");
        }

        [SetUp]
        public void Init()
        {
            c= new Calculator();
        }

        [TestCase(25,4,29)]
        [TestCase(25, 1, 26)]
        [TestCase(2, 1, 4)]
        public void AddTest(int input1,int input2,int expectedOutput)
        {
            //Arrange             
            int actualOutput = 0;
            

            //Act

            actualOutput=c.Add(input1, input2);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);

            //-> multiple input output check


        }


        [TestCase(25, 5, 5)]
        [TestCase(2, 0, 4)]
        public void DivideTest(int input1, int input2, int expectedOutput)
        {
            //Arrange 
            int actualOutput = 0;


            //Act

            actualOutput = c.Divide(input1, input2);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);

            //-> multiple input output check
            //-> (imp note) if exception comes then will face an error in unit testing 

        }

        [TestCase(10, 0, 0)]
        [TestCase(25,5,5)]
 
        public void DivideTestThrowsException(int input1, int input2, int expectedOutput)
        {
            //Arrange 
            int actualOutput = 0;

            //Act
            Assert.Throws<DivideByZeroException>(delegate
            {
                c.Divide(input1, input2);
            });

            //Assert

            //-> this thing is only confined to checking the exception nothing else


            //-> multiple input output check

           


        }
        [TearDown]
        public void DeInitilize()
        {
            c = null;
        }

    }
}
