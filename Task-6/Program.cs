class Program
{
    static void Main()
    {
        var bookings = new List<Booking>
            {
                new Booking { CustomerName = "Aarav", Destination = "Pokhara", Price = 8000, DurationInDay = 3, IsInternational = false },
                new Booking { CustomerName = "Riya", Destination = "Thailand", Price = 45000, DurationInDay = 6, IsInternational = true },
                new Booking { CustomerName = "Suman", Destination = "Lumbini", Price = 12000, DurationInDay = 2, IsInternational = false },
                new Booking { CustomerName = "Puja", Destination = "Dubai", Price = 65000, DurationInDay = 5, IsInternational = true },
                new Booking { CustomerName = "Kamal", Destination = "Chitwan", Price = 15000, DurationInDay = 5, IsInternational = false }
            };

        var filtered = bookings.Where(b => b.Price > 10000 && b.DurationInDay > 4);

        var projected = filtered.Select(b => new
        {
            b.CustomerName,
            b.Destination,
            b.Price,
            Category = b.IsInternational ? "International" : "Domestic"
        });

        var sorted = projected
            .OrderBy(b => b.Category)       
            .ThenBy(b => b.Price)           
            .ToList();

        Console.WriteLine("Filtered, Transformed and Sorted Tours:\n");
        foreach (var b in sorted)
        {
            Console.WriteLine($"Customer: {b.CustomerName}\nDestination: {b.Destination}\nCategory: {b.Category}\nPrice: Rs. {b.Price}\n------------------------");
        }
    }
}