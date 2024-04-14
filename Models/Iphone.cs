using System;

namespace DesafioPOO.Models
{

    public class iPhone : Smartphone
    {

        public iPhone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            if (string.IsNullOrWhiteSpace(numero))
            {
                throw new ArgumentException("O número do iPhone não pode ser nulo ou vazio.");
            }
        }


        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no iPhone.");
        }
    }
}
