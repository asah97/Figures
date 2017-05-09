using System;
using NUnit.Framework;
using Figures;


namespace UnitTests.FiguresTests
{
    /// <summary>
    /// Набор тестов для класса Circle
    /// </summary>
    [TestFixture]
    public class CircleTest
    {
        /// <summary>
        /// Тестирование свойства Radius
        /// </summary>
        /// <param name="radius"> Радиус </param>
        /// <returns></returns>
        [Test]
        [TestCase(4.4, TestName = "Тестирование свойства Radius при присваивании значения с дробной частью")]
        [TestCase(4, TestName = "Тестирование свойства Radius при присваивании целого числа")]
        [TestCase(null, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства Radius при присваивании нулевого значения")]
        [TestCase(100.001, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства Radius при присваивании значения, находящегося за пределами допустимых значений")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства Radius при присваивании отрицательного значения")]
        public void RadiusTest(double radius)
        {
            var circle = new Circle();
            circle.Radius = radius;
        }

        /// <summary>
        /// Тестирование правильности расчета площади через метод GetArea
        /// </summary>
        /// <param name="radius"> Радиус </param>
        [Test]
        [TestCase(44.4, TestName = "Тестирование метода GetArea при значении радиуса равного 44.4")]
        public void GetAreaTest(double radius)
        {
            var circle = new Circle();
            circle.Radius = radius;
            Assert.AreEqual(circle.GetArea(), 6190.07);
        }

    }
}
