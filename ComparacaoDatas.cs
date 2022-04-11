using System;

namespace FormatacaoDeDatas
{
    public static class ComparacaoDatas
    {
        public static void ComparandoDatas()
        {


            // DateTime? data = null;// para deixar a data nula.

            var data = DateTime.Now;
            // if (data == DateTime.Now) desse modo sempre dara false pq ele compara até fração de segundos.
            if (data.Date == DateTime.Now.Date)//Comparando somente a data por causa do .Date.
            {
                Console.WriteLine("É Igual");
            }
            else
            {
                Console.WriteLine("Não é igual");
            }

            Console.WriteLine(data);


        }
    }
}