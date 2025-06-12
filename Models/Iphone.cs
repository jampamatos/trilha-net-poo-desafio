namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Verificando espaço disponível para instalar o aplicativo {nomeApp} no iPhone...");

            // Simula lógica de checagem de memória
            int tamanhoApp = 50; // Tamanho do aplicativo em MB
            if (Memoria >= tamanhoApp)
            {
                Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone...");
                AtualizarMemoriaDisponivel(tamanhoApp);
                Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no iPhone!");
            }
            else
            {
                Console.WriteLine($"Não há espaço suficiente para instalar o aplicativo {nomeApp} no iPhone.");
            }
        }
    }
}