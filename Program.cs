using System;

namespace FormatacaoDeDatas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            /*var data = new DateTime(2002, 7, 31, 17, 00, 15);
              cria uma data
              var data = DateTime.Now;  //usar a data de atual 
              Console.WriteLine(data);
              Console.WriteLine(data.Year);   //imprime o ano
              Console.WriteLine(data.Month);  //imprime o mês
              Console.WriteLine(data.Day);    //imprime o dia 
              Console.WriteLine(data.Hour);   //imprime a hora
              Console.WriteLine(data.Minute); //imprime o minuto
              Console.WriteLine(data.Second); //imprime o segundo
            */

            var data = DateTime.Now;

            /* ------------Observações de formatação de data e hora:---------------
                Usar sempre os dois pontos para utilizar a formatação.

                y para Years
                M para mês
                d para dia
                h para hora
                m para minutos
                s para secundos
                ff fração de segundos
                z timezone, em que lugar esta sendo referenciado o horario

                -------------------FORMATÇÃO PRÉ-DEFINIDAS------------------------

                t imprime somente o horario na menor qtd de caracteres.     (hh:mm)
                d imprime somente a data na menor qtd de caracteres.        (7/8/2020) 
                T imprime somente o horario por extenso.                    (hh:mm:ss)
                D imprime somente a data por extenso.                       (Wednesday, July 8, 2020)
                f combina por extenso a data e a hora.                      (Wednesday, July 8, 2020 1:15 PM)
                g combina data e hora na menor qtd de caracteres.           (7/8/2020 1:16 PM)
                r impreme no padrão muito utilizado.                        (Wed, 08 jul 2020 13:16:55 GMT)
                s muito utilizado nas datas tipos json.                     (2020-07-0808T13:17:31)
                u padrão universal.                                         (2020-07-08 13:17:58Z)
            */

            var formatada = String.Format("{0:yyyy/MM/dd hh:mm:ss ff z}", data);
            Console.WriteLine(formatada);

            Console.WriteLine("-----------------------------------------Metodos Adicionais para formatação de data e hora-------------------------------");
            MetodosAdicionaisDatas.metodosAdicionais();

            Console.WriteLine("------------------------------------------------------Comparação de Datas------------------------------------------------");
            ComparacaoDatas.ComparandoDatas();

            Console.WriteLine("----------------------------------------------------Globalização de Datas------------------------------------------------");
            GlobalizacaoDatas.globalizacaoDatas();





        }
    }
}
