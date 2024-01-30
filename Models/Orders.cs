namespace AppWeb.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public string? Country { get; set; }
        public double? Price { get; set; }
        public int? OrderQuantity { get; set; }  
    }
}
