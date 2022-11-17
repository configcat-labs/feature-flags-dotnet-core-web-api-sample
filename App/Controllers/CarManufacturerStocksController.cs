using ConfigCat.Client;
using Microsoft.AspNetCore.Mvc;

namespace ConfigCatAPIDemo.Controllers
{
    [ApiController]
    [Route("/api/[controller]/24h/usd")]
    public class CarManufacturerStocksController : ControllerBase
    {
        private readonly IConfigCatClient configCatClient;

        public CarManufacturerStocksController(IConfigCatClient configCatClient)
        {
            this.configCatClient = configCatClient;
        }

        private static readonly string[] CarBrands = new[]
        {
         "Abarth",
          "Alfa Romeo",
          "Aston Martin",
          "Audi",
          "Bentley",
          "BMW",
          "Bugatti",
          "Cadillac",
          "Chevrolet",
          "Chrysler",
          "Citroën",
          "Dacia",
          "Daewoo",
          "Daihatsu",
          "Dodge",
          "Donkervoort",
          "DS",
          "Ferrari",
          "Fiat",
          "Fisker",
          "Ford",
          "Honda",
          "Hummer",
          "Hyundai",
          "Infiniti",
          "Iveco",
          "Jaguar",
          "Jeep",
          "Kia",
          "KTM",
          "Lada",
          "Lamborghini",
          "Lancia",
          "Land Rover",
          "Landwind",
          "Lexus",
          "Lotus",
          "Maserati",
          "Maybach",
          "Mazda",
          "McLaren",
          "Mercedes-Benz",
          "MG",
          "Mini",
          "Mitsubishi",
          "Morgan",
          "Nissan",
          "Opel",
          "Peugeot",
          "Porsche",
          "Renault",
          "Rolls-Royce",
          "Rover",
          "Saab",
          "Seat",
          "Skoda",
          "Smart",
          "SsangYong",
          "Subaru",
          "Suzuki",
          "Tesla",
          "Toyota",
          "Volkswagen",
          "Volvo"
        };

        [HttpGet]
        public IEnumerable<CarManufacturerStock> Get()
        {
            // Defining a user 
            var userObject = new User("<Some UserID>")
            {
                Email = "example@mail.com",
                Country = "USA",
                Custom = new Dictionary<string, string>
                {
                    {"Account", "Premium"},
                }
            };

            // Getting the ConfigCat's flag value and storing it localy 
            bool isFlagOn = this.configCatClient.GetValue("myfeatureflag", false, userObject);

            // Feature Data for demo purposes 
            static object[] Stock () {
                object[] stock = {
                new { key = "change", value =  Random.Shared.Next(-20, 30) },
                new { key = "multiplier", value = Random.Shared.Next(0, 20) },
                new { key = "spread", value =  Random.Shared.Next(0, 100) },
                };
                return stock;
            };
     
            return Enumerable.Range(1, 5).Select(index => new CarManufacturerStock {

                // Standard data in the JSON
                ID = index,
                Date = DateTime.Now.AddDays(index),
                CarBrand = CarBrands[Random.Shared.Next(CarBrands.Length)],
                StockPrice = Random.Shared.Next(2, 350),
                Volume24h = Random.Shared.Next(20000000, 780000000),

                // Conditionaly injecting feature data in JSON depending on the flag value
                Movement = isFlagOn ? Stock() : null
            })
        .ToArray();           
        }
    }
}