using TAU_Web_Api.Models;

namespace TAU_Web_Api.Services
{
    public class TauService
    {
        public int AddTwoNumbers(int a, int b)
        {
            var sum = a + b;
            return sum;
        }

        public string ChooseColorByNumber(int num)
        {
            string result;

            switch (num)
            {
                case 1:
                    result = "blue";
                    break;
                case 2:
                    result = "yellow";
                    break;
                case 3:
                    result = "green";
                    break;
                case 4:
                    result = "pink";
                    break;
                case 5:
                    result = "red";
                    break;
                default:
                    result = "black";
                    break;
            }

            return result;
        }

        public List<CarModel> AddCarToList(List<CarModel> cars, CarModel car)
        {

            cars.Add(car);
            return cars;
        }

        public CarModel CalculateCarAge(CarModel car)
        {
            car.age = DateTime.Now.Year - car.CreatedYear;
            return car;
        }
    }
}
