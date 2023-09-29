internal class Program
{
    enum Gun { Pazartesi=1,Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar};
    private static void Main(string[] args)
    {
        Gun gun =Gun.Çarşamba;

        if (gun == Gun.Cumartesi || gun == Gun.Pazar)
        {
            Console.WriteLine("Hafta Sonunu Seçtiniz");
        }
        else
        {
            Console.WriteLine("Hafta içini Seçtiniz");
        }
    }
}