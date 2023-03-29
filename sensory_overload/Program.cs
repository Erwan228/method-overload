namespace sensory_overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Worite();
            Worite();
        }
        //static void Worite()
        //{
        //    Console.WriteLine("Hei og velkommen");
        //}
        static void Worite(string name = "Terje")
        {
            Console.WriteLine("Hei og velkommen. " + name);
        }
    }
}