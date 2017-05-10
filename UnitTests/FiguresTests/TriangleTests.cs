using System;
using NUnit.Framework;
using Figures;

namespace UnitTests.FiguresTests
{
    /// <summary>
    /// Набор тестов для класса Triangle 
    /// </summary>
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        [TestCase(4.4, 5.67, 4.55, TestName = "Тестирование метода присваивания значений сторон треугольника")]
        [TestCase(-4.4, 5.67, 4.55, ExpectedException = typeof(ArgumentException), TestName = "Тестирование метода присваивания значений сторон треугольника с отрицательным значением одной из сторон")]
        [TestCase(106.66, 5.67, 4.55, ExpectedException = typeof(ArgumentException), TestName = "Тестирование метода присваивания значений сторон треугольника со стороной, значение которой выходит за пределы области допустимых значений")]
        [TestCase(4.4, 5.67, 20.95, ExpectedException = typeof(ArgumentException), TestName = "Тестирование метода присваивания значений сторон треугольника со стороной, значение которой больше суммы двух других сторон")]
        public void SetSidesTest(double a, double b, double c)
        {
            var triangle = new Triangle();
            triangle.SetSides(a, b, c);
        }

        [Test]
        [TestCase(4.4, TestName = "Тестирование свойства SideB при присваивании значения с дробной частью")]
        [TestCase(4, TestName = "Тестирование свойства SideB при присваивании целого числа")]
        [TestCase(null, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства SideA при присваивании нулевого значения")]
        [TestCase(100.001, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства SideA при присваивании значения, находящегося за пределами допустимых значений")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства SideA при присваивании отрицательного значения")]
        public void SideATest(double sideA)
        {
            var triangle = new Triangle();
            triangle.SideA = sideA;
        }

        [Test]
        [TestCase(4.4, TestName = "Тестирование свойства SideB при присваивании значения с дробной частью")]
        [TestCase(4, TestName = "Тестирование свойства SideB при присваивании целого числа")]
        [TestCase(null, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства SideB при присваивании нулевого значения")]
        [TestCase(100.001, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства SideB при присваивании значения, находящегося за пределами допустимых значений")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства SideB при присваивании отрицательного значения")]
        public void SideBTest(double sideB)
        {
            var triangle = new Triangle();
            triangle.SideA = sideB;
        }

        [Test]
        [TestCase(4.4, TestName = "Тестирование свойства SideC при присваивании первой стороне треугольника значения с дробной частью")]
        [TestCase(4, TestName = "Тестирование свойства SideC при присваивании значения с дробной частью")]
        [TestCase(null, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства SideС при присваивании нулевого значения")]
        [TestCase(100.001, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства SideС при присваивании значения, находящегося за пределами допустимых значений")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства SideС при присваивании отрицательного значения")]
        public void SideCTest(double sideC)
        {
            var triangle = new Triangle();
            triangle.SideA = sideC;
        }
        [Test]
        [TestCase(21.5, 24.3, 23.5, Result = 229.31,  TestName = "Тестирование метода GetArea при сторонах треугольника равных 21.5, 24.3, 23.5.")]
        public double GetAreaTest(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle();
            triangle.SideA = sideA;
            triangle.SideB = sideB;
            triangle.SideC = sideC;
            return triangle.GetArea();
        }
    }

}
