namespace CarComparisonApi.Models
{
    public class CarBrand
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<CarModel> Models { get; set; } = new();
    }
}