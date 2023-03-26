// See https://aka.ms/new-console-template for more information
namespace tpmodul6_1302210074
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            SayaTubeVideo vid = new SayaTubeVideo("Tutorial Design By Contract - Raihan Sulthon Y");
            vid.IncreasePlayCount(500);
            vid.PrintVideoDetails();

            Console.WriteLine("\n");
            SayaTubeVideo vid1 = new SayaTubeVideo("R34 Pure Sound");

            vid1.IncreasePlayCount(1000000000);
            vid1.PrintVideoDetails();
        }
    }
}