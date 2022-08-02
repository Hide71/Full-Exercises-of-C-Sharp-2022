using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CursoCSharp.ExerciciosBalta
{
    internal class Data
    {
        static bool FimDeSemana(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
        public static void Executar()
        {
            Console.Clear();
            var data = new DateTime(1971, 12, 15, 12, 30, 59);
            //var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.Kind);
            Console.WriteLine((int)data.DayOfWeek);
            Console.WriteLine(data.DayOfWeek);

            var data2 = DateTime.Now;
            var formato = String.Format("{0: dd * MM * yyy hh: mm: ss zz}", data2);
            Console.WriteLine(formato);

            var data3 = DateTime.Now;
            Console.WriteLine(data3.AddYears(2));
            Console.WriteLine(data3.AddMonths(11));
            Console.WriteLine(data3.AddHours(5));


            var br = new CultureInfo("pt-Br");
            var pt = new CultureInfo("pt-PT");
            var en = new CultureInfo("en-UK");
            var us = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;
            Console.WriteLine(DateTime.Now.ToString("D",br));
            Console.WriteLine(DateTime.Now.ToString("D",pt));
            Console.WriteLine(DateTime.Now.ToString("D",en));
            Console.WriteLine(DateTime.Now.ToString("D",us));
            Console.WriteLine(DateTime.Now.ToString("D",de));
            Console.WriteLine(DateTime.Now.ToString("D", atual));
            Console.WriteLine("Quer limpar?: ");
            var resp = Console.ReadLine().ToUpper();
            if(resp == "S")
            {
                Console.Clear();
            }
            var dateTime = DateTime.UtcNow;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToLocalTime());

            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timeZoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZoneAustralia);
            Console.WriteLine(horaAustralia);

            Console.WriteLine("Quer limpar?: ");
            var resp1 = Console.ReadLine().ToUpper();
            if (resp1 == "S")
            {
                Console.Clear();
            }
            var timeZones = TimeZoneInfo.GetSystemTimeZones();
            foreach(var timeZone in timeZones)
            {
                Console.WriteLine(timeZone.Id);
                Console.WriteLine(timeZone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZone));
                Console.WriteLine("Quer limpar?: ");

            }
            Console.WriteLine("Quer limpar?: ");
            var resp3 = Console.ReadLine().ToUpper();
            if (resp3 == "S")
            {
                Console.Clear();
            }
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var nanoSegundos = new TimeSpan(1);
            Console.WriteLine(nanoSegundos); 

            var horaMinutoSegundo = new TimeSpan(12,37,18);
            Console.WriteLine(horaMinutoSegundo);

            var diaHoraMinutoSegundo = new TimeSpan(5, 12,37,18);
            Console.WriteLine(diaHoraMinutoSegundo);

            var diaHoraMinutoSegundoMilisegundo = new TimeSpan(5, 12,37,18, 8);
            Console.WriteLine(diaHoraMinutoSegundoMilisegundo);

            Console.WriteLine(horaMinutoSegundo - diaHoraMinutoSegundo);
            Console.WriteLine(diaHoraMinutoSegundo.Days);
            Console.WriteLine(diaHoraMinutoSegundo.Add(new TimeSpan(12,0,0)));


            Console.WriteLine(DateTime.DaysInMonth(2022, 2));
            Console.WriteLine(FimDeSemana(DateTime.Now.DayOfWeek));




        }
     
    }
}
