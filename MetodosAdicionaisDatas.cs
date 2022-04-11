using System;

namespace FormatacaoDeDatas
{
    public static class MetodosAdicionaisDatas
    {
        public static void metodosAdicionais()
        {
            var data = DateTime.Now;
            Console.WriteLine(data);

            data.AddDays(12);
            Console.WriteLine(data.AddDays(12));//add + 12 dias a dias EX:05+12 = 17
            Console.WriteLine(data.AddMonths(1));//add + 1 para os mês.
            Console.WriteLine(data.AddYears(1));//add + 1 para o ano.
            Console.WriteLine(data.AddHours(1));//add + 1 para a hora.
            //OBS: usar esses metodos pois não precisa se preocupar com a qtd dse dias um mes tem ele já faz isso automaticamente.


        }
    }
}