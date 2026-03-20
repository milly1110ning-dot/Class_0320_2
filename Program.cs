namespace Class_0320_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test std1, std2;

            std1 = new Test();
            std2 = new Test();

            std1.Mid = 78;
            std1.SetFinal(72);

            std2.SetGrate(68,84);


            Console.WriteLine("第一位" + std1.GetAvg().ToString());

            Console.WriteLine("第二位" + std2.GetAvg().ToString());



        }
    }
}
