using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar instancias
            Smartphone nokia = new Nokia("11999999999", "3310", "1234567890", 100);
            Smartphone iphone = new Iphone("11999999998", "iPhone 12", "0987654321", 200);

            // Testes do Nokia
            Console.WriteLine("=== Testes Nokia ===");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");
            nokia.InstalarAplicativo("Facebook");
            Console.WriteLine($"Memória disponível após instalação: {nokia.Memoria} MB\n");
            nokia.InstalarAplicativo("Instagram");
            Console.WriteLine($"Memória disponível após instalação: {nokia.Memoria} MB\n");

            // Testes do iPhone
            Console.WriteLine("=== Testes iPhone ===");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp");
            iphone.InstalarAplicativo("Facebook");
            Console.WriteLine($"Memória disponível após instalação: {iphone.Memoria} MB\n");
            iphone.InstalarAplicativo("Instagram");
            Console.WriteLine($"Memória disponível após instalação: {iphone.Memoria} MB\n");

            Console.WriteLine("\nFim dos testes. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

    }
}