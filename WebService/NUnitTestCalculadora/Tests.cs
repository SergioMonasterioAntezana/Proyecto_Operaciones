using NUnit.Framework;
using WebService.Properties.Controllers;

namespace NUnitTestCalculadora
{
    public class TestCalculadora
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSuma1()
        {
            //Arrange=preparacion
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.Sumap(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSuma2()
        {
            //Arrange=preparacion
            int num1 = 3;
            int num2 = 10;
            int esperado = 13;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.Sumap(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSuma3()
        {
            //Arrange=preparacion
            int num1 = -5;
            int num2 = -12;
            int esperado = -17;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.Sumap(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSuma4()
        {
            //Arrange=preparacion
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.Sumag(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSuma5()
        {
            //Arrange=preparacion
            int num1 = 3;
            int num2 = 10;
            int esperado = 13;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.Sumag(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSuma6()
        {
            //Arrange=preparacion
            int num1 = -5;
            int num2 = -12;
            int esperado = -17;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.Sumag(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);

        }
    }
}