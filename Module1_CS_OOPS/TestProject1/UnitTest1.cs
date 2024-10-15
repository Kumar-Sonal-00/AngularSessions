using NUnitTestingDemoLib;

namespace TestProject1
{
    public class CalculatorTests
    {

        Calculator calc;
        int a, b;

        [SetUp]
        public void Setup()
        {
            //A:- Arrange
            calc = new Calculator();
            a = 10;
            b = 20;
        }

        [Test]
        public void SumTest()
        {
            //A: Arrange 
   
            //A: Act
            int actualResult=calc.Sum(a, b);
            int expectedResult = 30;

            //A: Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SubtractTest()
        {
            //A:- Arrange
            
           
            //A: Act
            int actualResult = calc.Subtract(a, b);
            int expectedResult = -10;

            //A: Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void MultiplyTest()
        {
            //A:- Arrange           

            //A: Act
            int actualResult = calc.Multiply(a, b);
            int expectedResult = 200;

            //A: Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void DivideTest()
        {
            //A:- Arrange           
            b = 0;

            //A: Act
            double actualResult = calc.Divide(a, b);
            double expectedResult = 5;

            //A: Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [Test]
        public void Divide_DivideByZeroExceptionTest()
        {
            //A:- Arrange            
            a = 100;
            b = 0;           

            //A: Act
            DivideByZeroException ex = Assert.Throws<DivideByZeroException>(()=>calc.Divide(a,b));
            string actualErrMsg = ex.Message;

            string expectedErrMsg = "Divide By Zero Error";
            
            //A: Assert
            Assert.AreEqual(expectedErrMsg, actualErrMsg);
        }
    }
}