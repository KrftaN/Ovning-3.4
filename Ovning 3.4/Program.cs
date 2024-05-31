namespace övning_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Krav på låtens längd i sekunder
            const int minDurationSeconds = 2 * 60 + 45; // 2 minuter och 45 sekunder
            const int maxDurationSeconds = 4 * 60 + 20; // 4 minuter och 20 sekunder

            // Användaren anger längden på låten
            Console.WriteLine("Ange längden på låten:");
            Console.Write("Minuter: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Sekunder: ");
            int seconds = int.Parse(Console.ReadLine());

            // Beräkna den totala längden i sekunder
            int totalDurationSeconds = minutes * 60 + seconds;

            // Kontrollera om låten får spelas på radiostationen
            if (totalDurationSeconds >= minDurationSeconds && totalDurationSeconds <= maxDurationSeconds)
            {
                Console.WriteLine("Låten får spelas på radiostationen.");
            }
            else
            {
                Console.WriteLine("Låten får inte spelas på radiostationen.");
            }
        }
    }
}
