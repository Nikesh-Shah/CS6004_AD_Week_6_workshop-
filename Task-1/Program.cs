namespace Task_1{

    internal class Program
    {
        public static void Main(string[] args) {

            Rectangle rec = new Rectangle();
            double l = 10;
            double b = 20;

            rec.Length = l;
            rec.Breadth = b;

            Console.WriteLine("Area: " + rec.GetArea());
            Console.WriteLine("Perimeter: " + rec.GetPerimeter());
            Console.WriteLine(rec.ShowDetails());



        }
    }

}