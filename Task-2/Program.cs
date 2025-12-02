
public delegate int Calculate(int a, int b);
public delegate double DiscountStrategy(double price);
public class Program { 
    public static int Add(int a, int b) => a + b;
    
    public static int Subtract(int  a, int b) => a - b;

    public static double FestivalDiscount(double p) =>  p-( p * 0.2);
    public static double SeasonalDiscount(double p) =>  p-(p * 0.1);

    public static double NoDiscount(double p) => p;

    public static double CalculateFinalPrice(double originalprice, DiscountStrategy strategy) => strategy(originalprice);


    public static void Main(string[] args) {
        Calculate del = Add;
        Console.WriteLine(del(10,10));

        Calculate del2 = Subtract;
        Console.WriteLine(del2(10, 10));


        DiscountStrategy del3 = FestivalDiscount;
        Console.WriteLine("Festival discount: " + del3(100));

        DiscountStrategy del4 = SeasonalDiscount;
        Console.WriteLine(del4(100));


        DiscountStrategy del5 = NoDiscount;
        Console.WriteLine(del5(100));


        Console.WriteLine("2.1");

        Console.WriteLine("Festival discount1 :"+CalculateFinalPrice(1000, FestivalDiscount));
        Console.WriteLine("Seasonal discount1 :" + CalculateFinalPrice(1000, SeasonalDiscount));
        Console.WriteLine("No discount1 :" + CalculateFinalPrice(1000, NoDiscount));



        Console.WriteLine("new 30% discount :" + CalculateFinalPrice(1000, p => (p - (p * 0.3))));








    }
} 
