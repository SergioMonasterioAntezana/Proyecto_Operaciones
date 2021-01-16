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

        [Test]
        public void TestResta1()
        {
            //Arrange=preparacion
            int num1 = 5;
            int num2 = 3;
            int esperado = 2;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.Restap(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestResta2()
        {
            //Arrange=preparacion
            int num1 = 4;
            int num2 = 8;
            int esperado = -4;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.Restap(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestResta3()
        {
            //Arrange=preparacion
            int num1 = 16;
            int num2 = 16;
            int esperado = 0;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.Restap(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestResta4()
        {
            //Arrange=preparacion
            int num1 = 5;
            int num2 = 3;
            int esperado = 2;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.Restag(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestResta5()
        {
            //Arrange=preparacion
            int num1 = 7;
            int num2 = 10;
            int esperado = -3;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.Restag(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestResta6()
        {
            //Arrange=preparacion
            int num1 = 6;
            int num2 = 6;
            int esperado = 0;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.Restag(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);

        }
    }
}