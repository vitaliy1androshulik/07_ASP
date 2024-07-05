namespace _03_SecondHomeWorkViewModel.Entities
{
    public class Mercedes
    {
        public int Id { get; set; }

        public int BrandOfCarId { get; set; }
        public BrandOfCar BrandOfCar { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Class { get; set; }
        public int Year { get; set; }
        public double Volume { get; set; }
        public int HorsePower { get; set; }
        public int Discount { get; set; }
    }
}
