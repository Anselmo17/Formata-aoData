using System;
using System.Globalization;

namespace Aula_7_Topicos_Variados
{
    class Program
    {
        static void Main(string[] args)
        {


            // formatando datas 
            DateTime d = DateTime.Now;
            DateTime d1 = DateTime.UtcNow;

            // formatando com o PARSE
            DateTime d2 = DateTime.Parse("27/12/2019");
            DateTime d3 = DateTime.Parse("27/12/2019 13:48:58");

            // formatando com PARSEEXACT
            DateTime d4 = DateTime.ParseExact("2019-12-20","yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d5 = DateTime.ParseExact("2019-12-20 13:48:58", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            // formato toString
            var data = d1.ToString("yyyy-MM-dd");
            var dataHora = d1.ToString("yyyy-MM-dd HH:mm:ss");

            // formatando data local e por UTC
            DateTime local = new DateTime(2019, 12, 26, 13,5,58 , DateTimeKind.Local);
            DateTime dataUtc = new DateTime(2019, 12, 26, 13, 5, 58, DateTimeKind.Utc);

            // print as data na tela  
            Console.WriteLine(d);
            Console.WriteLine(d1);

            // formatando data e horas
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            // formatando com exact
            Console.WriteLine(d4);
            Console.WriteLine(d5);

            // formato toString
            Console.WriteLine(data);
            Console.WriteLine(dataHora);

            // formato data local e UTC
            Console.WriteLine("Data local : "+local.ToLocalTime());
            Console.WriteLine("Data local universal : " + local.ToUniversalTime());
            Console.WriteLine("Data universal : "+dataUtc.ToUniversalTime());
        }
    }
}
