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

        [Test]
        public void TestMultiplicacion1()
        {
            //Arrange=preparacion
            int num1 = -5;
            int num2 = -2;
            int esperado = 10;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.Multiplicacionp(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestMultiplicacion2()
        {
            //Arrange=preparacion
            int num1 = 4;
            int num2 = -1;
            int esperado = -4;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.Multiplicacionp(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestMultiplicacion3()
        {
            //Arrange=preparacion
            int num1 = 10;
            int num2 = 10;
            int esperado = 100;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.Multiplicacionp(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestMultiplicacion4()
        {
            //Arrange=preparacion
            int num1 = 4;
            int num2 = 4;
            int esperado = 16;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.Multiplicaciong(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestMultiplicacion5()
        {
            //Arrange=preparacion
            int num1 = -8;
            int num2 = 8;
            int esperado = -64;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.Multiplicaciong(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestMultiplicacion6()
        {
            //Arrange=preparacion
            int num1 = -5;
            int num2 = -5;
            int esperado = 25;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.Multiplicaciong(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestDivision1()
        {
            //Arrange=preparacion
            int num1 = 1;
            int num2 = 1;
            int esperado = 1;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.Divisionp(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestDivision2()
        {
            //Arrange=preparacion
            int num1 = 10;
            int num2 = 50;
            int esperado = 5;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.Divisionp(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestDivision3()
        {
            //Arrange=preparacion
            int num1 = 5;
            int num2 = -20;
            int esperado = -4;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.Divisionp(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestDivision4()
        {
            //Arrange=preparacion
            int num1 = 5;
            int num2 = 95;
            float esperado = 19;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.Divisiong(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestDivision5()
        {
            //Arrange=preparacion
            int num1 = 2;
            int num2 = -10;
            int esperado = -5;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.Divisiong(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
        [Test]
        public void TestDivision6()
        {
            //Arrange=preparacion
            int num1 = 10;
            int num2 = 100;
            int esperado = 10;
            CalculadoraController calc = new CalculadoraController();


            //Act=Ejecution
            int resultado = calc.Divisiong(num1, num2);

            //Assert=verification
            Assert.AreEqual(esperado, resultado);


        }
    }
}