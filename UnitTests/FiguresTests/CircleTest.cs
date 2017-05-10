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
        /// <param name="square"> Площадь </param>
        [Test]
        [TestCase(44.4, 6190.07, TestName = "Тестирование метода GetArea при значении радиуса равного 44.4")]
        [TestCase(23.1, 1675.54, TestName = "Тестирование метода GetArea при значении радиуса равного 23.1")]
        [TestCase(35.2, 3890.59, TestName = "Тестирование метода GetArea при значении радиуса равного 35.2")]
        [TestCase(56.8, 10130.39, TestName = "Тестирование метода GetArea при значении радиуса равного 56.8")]
        [TestCase(9.3, 271.58, TestName = "Тестирование метода GetArea при значении радиуса равного 9.3")]
        public void GetAreaTest(double radius, double square)
        {
            var circle = new Circle();
            circle.Radius = radius;
            var result = circle.GetArea();
            Assert.AreEqual(square, result);
        }

        [TestCase(44.4, Result = 6190.07, TestName = "tArea при значении радиуса равного 44.4")]
        public double GetAreaTest2(double radius)
        {
            var circle = new Circle();
            circle.Radius = radius;
            return circle.GetArea();
        }
    }
}
