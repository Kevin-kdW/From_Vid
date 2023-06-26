namespace API.Models
{
    public class Sock
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Brand { get; set; } = default!;
        public List<SockManufacturer> SockManufacturers { get; set; } = new();
    }
}