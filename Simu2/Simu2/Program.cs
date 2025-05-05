namespace Simu2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moteur m = new Moteur();
            VTT vtt = new VTT("VTT1", "Yamaha", 44556, new Moteur());
            Console.WriteLine(vtt);
        }
    }
}
