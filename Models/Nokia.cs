namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Verificando espaço disponível para instalar o aplicativo {nomeApp} no Nokia...");

            // Simula lógica de checagem de memória
            int tamanhoApp = 50; // Tamanho do aplicativo em MB
            if (Memoria >= tamanhoApp)
            {
                Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
                AtualizarMemoriaDisponivel(tamanhoApp);
                Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no Nokia!");
            }
            else
            {
                Console.WriteLine($"Não há espaço suficiente para instalar o aplicativo {nomeApp} no Nokia.");
            }
        }
    }
}