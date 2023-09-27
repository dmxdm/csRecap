

using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace S7 {
    class Program
    {
        static void Main(string[] args)
        {
            //// S7 - Aula 93, DateTimeKind e Padrao ISO 8601

            //DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            //DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Kind);
            //Console.WriteLine(d1.ToLocalTime());
            //Console.WriteLine(d1.ToUniversalTime());

            //Console.WriteLine(d2);
            //Console.WriteLine(d2.Kind);
            //Console.WriteLine(d2.ToLocalTime());
            //Console.WriteLine(d2.ToUniversalTime());

            //Console.WriteLine(d2.ToString("yyyy-MM-ddT:HH:mm:ssZ")); //cuidado, o ideal é garantir qu esteja no universal
            //Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddT:HH:mm:ssZ"));


            //DateTime d1 = new DateTime(2000, 08, 15, 13, 5, 58, DateTimeKind.Local);
            //DateTime d2 = new DateTime(2000, 08, 15, 13, 5, 58, DateTimeKind.Utc);
            //DateTime d3 = new DateTime(2000, 08, 15, 13, 5, 58);

            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Kind);
            //Console.WriteLine(d1.ToLocalTime());
            //Console.WriteLine(d1.ToUniversalTime());

            //Console.WriteLine(d2);
            //Console.WriteLine(d2.Kind);
            //Console.WriteLine(d2.ToLocalTime());
            //Console.WriteLine(d2.ToUniversalTime());

            //Console.WriteLine(d3);
            //Console.WriteLine(d3.Kind);
            //Console.WriteLine(d3.ToLocalTime());
            //Console.WriteLine(d3.ToUniversalTime());

            //// S7 - Aula 92, TimeSpan, proprieadades e operadores

            //TimeSpan t1 = new TimeSpan(1, 30, 10);
            //TimeSpan t2 = new TimeSpan(0, 10, 5);

            //TimeSpan soma = t2.Add(t1);
            //Console.WriteLine(soma);
            //Console.WriteLine(t1.Subtract(t2));
            //Console.WriteLine(t2.Multiply(2.0));
            //Console.WriteLine(t2.Divide(2.0));


            //TimeSpan t = new TimeSpan(2,3,5,7,11);
            //Console.WriteLine(t);
            //Console.WriteLine(t.Days);
            //Console.WriteLine(t.Hours);
            //Console.WriteLine(t.Minutes);
            //Console.WriteLine(t.Seconds);
            //Console.WriteLine(t.Milliseconds);
            //Console.WriteLine(t.Ticks);

            //Console.WriteLine(t.TotalSeconds);
            //Console.WriteLine(t.TotalMilliseconds);
            //Console.WriteLine(t.TotalDays);
            //Console.WriteLine(t.TotalHours);
            //Console.WriteLine(t.TotalMinutes);

            //TimeSpan t1 = TimeSpan.MaxValue;
            //TimeSpan t2 = TimeSpan.MinValue;
            //TimeSpan t3 = TimeSpan.Zero;
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);


            //// propriedade operações datetime

            //DateTime d = new DateTime(2000, 10, 15);
            //DateTime d2 = new DateTime(2000, 10, 18);

            //TimeSpan t = d2.Subtract(d);
            //Console.WriteLine(t);

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            //DateTime d2 = d.AddHours(2);
            //DateTime d3 = d.AddMinutes(3);
            //DateTime d4 = d.AddDays(7);

            //Console.WriteLine(d);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);


            //Console.WriteLine(d.ToLongDateString());

            //Console.WriteLine(d.ToLongTimeString());

            //Console.WriteLine(d.ToShortDateString());

            //Console.WriteLine(d.ToShortTimeString());

            //string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");

            //Console.WriteLine(s6);

            //string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            //Console.WriteLine(s7);



            //Console.WriteLine(d);
            //Console.WriteLine(d.Date);
            //Console.WriteLine(d.Year);
            //Console.WriteLine(d.Month);
            //Console.WriteLine(d.Day);
            //Console.WriteLine(d.DayOfYear);

            ////timespan

            //TimeSpan t1 = TimeSpan.FromDays(1.5);
            //TimeSpan t2 = TimeSpan.FromHours(1.5);
            //TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            //TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            //TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            //TimeSpan t6 = TimeSpan.FromTicks(900000000L);

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);
            //Console.WriteLine(t6);

            //TimeSpan t1 = new TimeSpan(0,1,30);
            //TimeSpan t2 = new TimeSpan(900000000L);
            //TimeSpan t3 = new TimeSpan(2,11,21);
            //TimeSpan t4 = new TimeSpan(1,2,11,21);
            //TimeSpan t5 = new TimeSpan(1, 2, 11, 21,321);

            //Console.WriteLine(t1);
            //Console.WriteLine(t1.Ticks); // cada tick 100ns
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);


            ////Datetime

            //DateTime d1 = DateTime.Parse("2000-08-15");
            //Console.WriteLine(d1);

            //DateTime d2 = DateTime.Parse("2000-08-15 13:58");
            //Console.WriteLine(d2);

            //DateTime d3 = DateTime.Parse("15/08/2000");
            //Console.WriteLine(d3);

            //DateTime d4 = DateTime.Parse("15/08/2000 13:05:48");
            //Console.WriteLine(d4);

            //DateTime d5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);
            //Console.WriteLine(d5);

            //DateTime d6 = DateTime.ParseExact("2000-08-15 13:05:58", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            //Console.WriteLine(d6);


            //DateTime d1 = new DateTime(2018, 11, 25);
            //Console.WriteLine(d1);

            //DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 03);
            //Console.WriteLine(d2);

            //DateTime d3 = DateTime.Now;
            //Console.WriteLine(d3);

            //DateTime d4 = DateTime.Today;
            //Console.WriteLine(d4);

            //DateTime d5 = DateTime.UtcNow;
            //Console.WriteLine(d5);




            //DateTime d1 = DateTime.Now;

            //Console.WriteLine(d1);

            //Console.WriteLine(d1.Ticks);// pega um valor gigante numero de ticks desde 1 de janeiro, é o numero que o computador guarda



            //string original = "abcde FGHIJ ABC abc DEFG     ";

            //string s1 = original.ToUpper();
            //string s2 = original.ToLower();
            //string s3 = original.Trim();
            //int n1 = original.IndexOf("bc");
            //int n2 = original.LastIndexOf("bc");
            //string s4 = original.Substring(3);
            //string s5 = original.Substring(3,5);
            //string s6 = original.Replace('a','x');
            //string s7 = original.Replace("abc","xy");
            //bool b1 = String.IsNullOrEmpty(original);
            //bool b2 = String.IsNullOrWhiteSpace(original);


            //Console.WriteLine(original + "-");
            //Console.WriteLine("--");
            //Console.WriteLine(s1 + "-");
            //Console.WriteLine("--");
            //Console.WriteLine(s2 + "-");
            //Console.WriteLine("--");
            //Console.WriteLine(s3 + "-");
            //Console.WriteLine("--");
            //Console.WriteLine(n1 + "-");
            //Console.WriteLine("--");
            //Console.WriteLine(n2 + "-");
            //Console.WriteLine("--");
            //Console.WriteLine(s4 + "-");
            //Console.WriteLine("--");
            //Console.WriteLine(s5 + "-");
            //Console.WriteLine("--");
            //Console.WriteLine(s6 + "-");
            //Console.WriteLine("--");
            //Console.WriteLine(s7 + "-");
            //Console.WriteLine("--");
            //Console.WriteLine(b1 + "-");
            //Console.WriteLine("--");
            //Console.WriteLine(b2 + "-");



            //// condição ternaria - IF ELSE


            //double preco = double.Parse(Console.ReadLine());

            //string result = (preco < 20) ? "preço menor" : "preço maior ou igual";

            //Console.WriteLine(result);

            //double resultB = (preco < 20) ? preco*2 : preco/2;

            //Console.WriteLine(resultB);


            //// switch case

            //int x = int.Parse(Console.ReadLine());
            //string dia;

            //switch (x)
            //{
            //    case 1:
            //        dia = "Domingo";
            //        break;
            //    case 2:
            //        dia = "Segunda";
            //        break;
            //    case 3:
            //        dia = "Terça";
            //        break;
            //    default:
            //        dia = "invalido";
            //        break;

            //}

            //Console.WriteLine(dia);

            //// VARAIVEL VAR - GENERICA

            //var x = 10;
            //var y = 20;
            //var z = "Maria";



        }
    }
}
