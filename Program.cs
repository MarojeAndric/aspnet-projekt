using Vjezba.Model_;

Console.WriteLine("Hello, World!");

var street = new Street
{
    Id = 1,
    Name = "Main Street",
    City = "New York",
    State = "NY",
    PostalCode = "10001",
    Country = "USA"
};

Console.WriteLine($"Street: {street.Name}, City: {street.City}, State: {street.State}, Postal Code: {street.PostalCode}, Country: {street.Country}");