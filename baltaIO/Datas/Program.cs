using System.Data;

namespace Datas;

class Program
{
    static void Main(string[] args)
    {
        #region Data Simples

        Console.Clear();
        var data1 = new DateTime();
        Console.WriteLine(data1 + "\n");


        #endregion

        #region Data now
        ;
        var data2 = DateTime.Now;
        Console.WriteLine(data2 + "\n");

        #endregion

        #region Atribuindo valores

        var data3 = new DateTime(1997, 01, 16, 17, 34, 49);
        Console.WriteLine(data3.Year);
        Console.WriteLine(data3.Month);
        Console.WriteLine(data3.Day);
        Console.WriteLine(data3.Hour);
        Console.WriteLine(data3.Minute);
        Console.WriteLine(data3.Second + "\n");

        #endregion

        #region Formatando datas

        var data4 = DateTime.Now;
        var formatadaM = String.Format("{0:dd/MM/yy - hh:mm}", data4);
        Console.WriteLine(formatadaM + "\n");

        #endregion

        #region Adicionando e removendo valores

        var data5 = DateTime.Now;
        data5.AddDays(12);
        data5.AddMonths(09);
        data5.AddYears(2023);
        data5.AddHours(17);
        data5.AddMinutes(00);
        data5.AddSeconds(00);

        Console.WriteLine(@data5.Day + " do " +
            data5.Month + " de " +
            data5.Year + " - " +
            data5.Hour + ":" +
            data5.Minute + ":" +
            data5.Second + ".\n");

        #endregion

        #region Comparação de datas

        DateTime? data6 = null;
        Console.WriteLine(data6 + "\n\n");

        var data61 = DateTime.Now;

        if(data61.Date == DateTime.Now.Date)
        {
            Console.WriteLine("O horário é igual\n");
        }

        #endregion

        #region Culture Info

        var br = new System.Globalization.CultureInfo("pt-BR");
        var pt = new System.Globalization.CultureInfo("pt-PT");
        var us = new System.Globalization.CultureInfo("en-US");
        var en = new System.Globalization.CultureInfo("en-UK");

        Console.WriteLine(DateTime.Now.ToString("D", br));
        Console.WriteLine(DateTime.Now.ToString("d", br));
        Console.WriteLine(DateTime.Now.ToString("D", pt));
        Console.WriteLine(DateTime.Now.ToString("d", pt));
        Console.WriteLine(DateTime.Now.ToString("D", us));
        Console.WriteLine(DateTime.Now.ToString("d", us));
        Console.WriteLine(DateTime.Now.ToString("D", en));
        Console.WriteLine(DateTime.Now.ToString("d", en) + "\n");

        Console.ReadLine();
        Console.Clear();

        #endregion

        #region Timezone

        var utcDate = DateTime.UtcNow;

        Console.WriteLine(DateTime.Now);
        Console.WriteLine(utcDate);
        Console.WriteLine(utcDate.ToLocalTime());

        var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
        Console.WriteLine(timeZoneAustralia);

        var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZoneAustralia);
        Console.WriteLine(horaAustralia);

        #region Timespan

        
        var timeSpan = new TimeSpan();
        Console.WriteLine(timeSpan);

        var timeSpanNanoSegundos = new TimeSpan(1);
        Console.WriteLine(timeSpanNanoSegundos);

        var timeSpanHoraMinutoSegundo = new TimeSpan(21, 29, 59);
        Console.WriteLine(timeSpanHoraMinutoSegundo);

        #endregion

        #region Outros métodos

        Console.WriteLine(DateTime.DaysInMonth(2023, 2));

        Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

        Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }

        #endregion

        Console.ReadLine();
        Console.Clear();

        #endregion

        var timezones = TimeZoneInfo.GetSystemTimeZones();
        foreach (var timezone in timezones)
        {
            Console.WriteLine(timezone.Id);
            Console.WriteLine(timezone);
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
            Console.WriteLine("_________________________");
        }

        Console.ReadLine();

    }
}
