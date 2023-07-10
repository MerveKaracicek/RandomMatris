internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Rastgele matris oluşturan uygulamaya hoşgeldiniz:");

        Console.WriteLine("Lütfen matrisinizin satir bilgisini giriniz:");
        int satir_boyut=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen matrisinizin sutun bilgisini giriniz:");
        int sutun_boyut = Convert.ToInt32(Console.ReadLine());

        int[,] randomMatris = new int [satir_boyut, sutun_boyut];

        var n = new Random();
        int toplam = 0;


        for (int i = 0; i < satir_boyut; i++)
        {
            for (int j = 0; j < sutun_boyut; j++)
            {
                randomMatris[i, j] = n.Next(1, 20);
                Console.Write($"{randomMatris[i,j],5}");
                toplam += randomMatris[i, j];
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Matrisin toplamı = {toplam}");


    }

}