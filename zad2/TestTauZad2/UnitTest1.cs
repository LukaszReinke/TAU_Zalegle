using TAU_Web_Api.Models;
using TAU_Web_Api.Services;

namespace TestTauZad2
{
    public class Tests
    {
        private TauService _tauService;
        

        [SetUp]
        public void Setup()
        {
            _tauService = new TauService();
        }

        [Test]
        public void Test1()
        {
            var result = _tauService.AddTwoNumbers(7, 20);
                Assert.That(result, Is.EqualTo(27));
        }

        [Test]
        public void Test2()
        {
            var result = _tauService.ChooseColorByNumber(4);
            Assert.That(result, Is.SameAs("pink"));
        }


        [Test]
        public void Test3()
        {
            var car = new CarModel()
            {
                age = 10,
                Brand = "Volvo",
                Model = "S60",
                CreatedYear = 2010,
                Color = "Gold"
            };

            var cars = new List<CarModel>();

            cars = _tauService.AddCarToList(cars,car);

            CollectionAssert.Contains(cars, car);
        }

        [Test]
        public void Test4()
        {
            var car = new CarModel()
            {
                Brand = "Volvo",
                Model = "S60",
                CreatedYear = 2010,
                Color = "Gold",
                Mileage = 210000
            };

            var result = _tauService.CalculateCarAge(car);

            var age = DateTime.Now.Year - result.CreatedYear;

            Assert.That(result.age, Is.EqualTo(age));
        }

        [Test]
        public void Test5()
        {
            // jeœli liczba przekazana do metody bêdzie wiêksza od 5, z tefaultu zostanie zwrócony kolor "Black"
            var result1 = _tauService.ChooseColorByNumber(6);
            var result2 = _tauService.ChooseColorByNumber(10);
            var result3 = _tauService.ChooseColorByNumber(23);
            var expected = "black";

            Assert.That(result1, Is.SameAs(expected));
            Assert.That(result2, Is.SameAs(expected));
            Assert.That(result3, Is.SameAs(expected));
        }

        [Test]
        public void Test6()
        {
            
        }
    }
}