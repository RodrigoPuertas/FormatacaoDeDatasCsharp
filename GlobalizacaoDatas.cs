using System;
using System.Globalization;

namespace FormatacaoDeDatas
{
    public static class GlobalizacaoDatas
    {
        public static void globalizacaoDatas()
        {
            var pt = new CultureInfo("pt-PT");//portugues de Portugal
            var br = new CultureInfo("pt-BR");//portugues do Brasil
            var en = new CultureInfo("en-US");//ingles americano
            var atual = CultureInfo.CurrentCulture;//Cultura atual da maquina. 

            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", br));
            Console.WriteLine(DateTime.Now.ToString("D", en));
            Console.WriteLine(DateTime.Now.ToString("D", atual));

            Console.WriteLine("----------------------------------TimeZone------------------------------------");

            var utcDate = DateTime.UtcNow; //horario global que calcula o horario da região atual

            Console.WriteLine(DateTime.Now);//horario do brasil -3GMT
            Console.WriteLine(utcDate);// horario global


        }
    }
}