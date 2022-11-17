namespace ConfigCatAPIDemo
{
    public class CarManufacturerStock
    {
        public DateTime Date { get; set; }

        public int ID { get; set; }

        public string? CarBrand { get; set; }

        public int StockPrice { get; set; }

        public int Volume24h { get; set; }

        public object[]? Movement { get; internal set; }
    }
}