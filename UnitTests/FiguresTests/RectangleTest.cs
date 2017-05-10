using System;
using NUnit.Framework;
using Figures;

namespace UnitTests.FiguresTests
{
    /// <summary>
    /// Набор тестов для класса Recatangle
    /// </summary>
    [TestFixture]
    public class RectangleTest
    {
        /// <summary>
        /// Тестирование свойства Width
        /// </summary>
        /// <param name="width"> Ширина </param>
        [Test]
        [TestCase(4.4, TestName = "Тестирование свойства Width при присваивании значения с дробной частью")]
        [TestCase(4, TestName = "Тестирование свойства Width при присваивании целого числа")]
        [TestCase(null, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства Width при присваивании нулевого значения")]
        [TestCase(100.001, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства Width при присваивании значения, находящегося за пределами допустимых значений")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства Width при присваивании отрицательного значения")]
        public void WidthTest(double width)
        {
            var rectangle = new Rectangle();
            rectangle.Width = width;
        }

        /// <summary>
        /// Тестирование свойства Length
        /// </summary>
        /// <param name="length"> Длина </param>
        [Test]
        [TestCase(4.4, TestName = "Тестирование свойства Length при присваивании значения с дробной частью")]
        [TestCase(4, TestName = "Тестирование свойства Length при присваивании целого числа")]
        [TestCase(null, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства Length при присваивании нулевого значения")]
        [TestCase(100.001, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства Length при присваивании значения, находящегося за пределами допустимых значений")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование свойства Length при присваивании отрицательного значения")]
        public void LengthTest(double length)
        {
            var rectangle = new Rectangle();
            rectangle.Length = length;
        }

        /// <summary>
        /// Тестирование правильности расчета площади через метод GetArea
        /// </summary>
        /// <param name="width"> Ширина </param>
        /// <param name="length"> Длина </param>
        [Test]
        [TestCase(22.14, 44.56, Result = 986.56,  TestName = "Тестирование метода GetArea при значении ширины и длины равных 22.14, 44.56 соответсвенно")]
        public double GetAreaTest(double width, double length)
        {
            var rectangle = new Rectangle();
            rectangle.Width = width;
            rectangle.Length = length;
            return rectangle.GetArea();
        }
    }
}
