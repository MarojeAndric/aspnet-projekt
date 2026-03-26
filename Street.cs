namespace Vjezba.Model_
{
    public class Street
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
    }
}