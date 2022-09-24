
namespace TestApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var inputData = new List<Path>
            {
                new Path{From = "Москва", To = "Тюмень"},
                new Path{From = "Тюмень", To = "Сочи"},
                new Path{From = "Ростов-на-Дону", To = "Москва"}
            };

            var expected = "Ростов-на-Дону Москва Тюмень Сочи";
            Assert.AreEqual(expected, RouteFormer.FormRoute(inputData));
        }

        [Test]
        public void Test2()
        {
            var inputData = new List<Path>
            {
                new Path{From = "Moscow", To = "Izhevsk"},
                new Path{From = "Sochi", To = "Moscow"},
            };

            var expected = "Sochi Moscow Izhevsk";
            Assert.AreEqual(expected, RouteFormer.FormRoute(inputData));
        }
    }
}