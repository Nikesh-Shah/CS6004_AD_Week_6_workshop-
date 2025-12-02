class Program
{
    static void Main()
    {
        var bookings = new List<Booking>
            {
                new Booking { CustomerName = "Aarav", Destination = "Pokhara", Price = 8000, DurationInDay = 3, IsInternational = false },
                new Booking { CustomerName = "Riya", Destination = "Thailand", Price = 45000, DurationInDay = 6, IsInternational = true },
                new Booking { CustomerName = "Suman", Destination = "Lumbini", Price = 12000, DurationInDay = 2, IsInternational = false },
                new Booking { CustomerName = "Puja", Destination = "Dubai", Price = 65000, DurationInDay = 5, IsInternational = true }
            };

        var expensiveTours = bookings.Where(b => b.Price > 10000);

        Console.WriteLine("Tours Above Rs. 10,000:");
        foreach (var b in expensiveTours)
        {
            Console.WriteLine($"{b.CustomerName} - {b.Destination} - Rs. {b.Price}");
        }

        var longTours = bookings.Where(b => b.DurationInDay > 4);

        Console.WriteLine("\nTours More Than 4 Days:");
        foreach (var b in longTours)
        {
            Console.WriteLine($"{b.CustomerName} - {b.Destination} - {b.DurationInDay} days");
        }
    }
}