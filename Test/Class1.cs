using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SQT_CA1;

namespace Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public static void MyTest1()
        {
            //Arrange
            InsuranceService obj = new InsuranceService();

            //Act
            var result = obj.CalcPremium(16, "urban");

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public static void MyTest2()
        {
            //Arrange
            InsuranceService obj = new InsuranceService();

            //Act
            var result = obj.CalcPremium(20, "urban");

            //Assert
            Assert.That(result, Is.EqualTo(50));
        }

        [Test]
        public static void MyTest3()
        {
            //Arrange
            InsuranceService obj = new InsuranceService();

            //Act
            var result = obj.CalcPremium(50, "urban");

            //Assert
            Assert.That(result, Is.EqualTo(12.5));
        }

        [Test]
        public static void MyTest4()
        {
            //Arrange
            InsuranceService obj = new InsuranceService();

            //Act
            var result = obj.CalcPremium(0, "");

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public static void MyTest5()
        {
            //Arrange
            InsuranceService obj = new InsuranceService();

            //Act
            var result = obj.CalcPremium(60, "rural");

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public static void MyTest6()
        {
            //Arrange
            InsuranceService obj = new InsuranceService();

            //Act
            var result = obj.CalcPremium(50, "rural");

            //Assert
            Assert.That(result, Is.EqualTo(50));
        }

        [Test]
        public static void MyTest7()
        {
            //Arrange
            InsuranceService obj = new InsuranceService();

            //Act
            var result = obj.CalcPremium(0, "rural");

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        //[TestCase(0, "", ExpectedResult = 0)]
        //[TestCase(20, "rural", ExpectedResult = 60)]
        //[TestCase(36, "rural", ExpectedResult = 50)]
        //[TestCase(16, "rural", ExpectedResult = 0)]
        //public static void MyTest4to7()
        //{
        //    //Arrange
        //    InsuranceService obj = new InsuranceService(int a, string b);

        //    //Act
        //    var result = obj.CalcPremium(50, "urban");

        //    //Assert
        //    Assert.That(result, Is.EqualTo(expected));
        }
    }

    

