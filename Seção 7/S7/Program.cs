

using System.Diagnostics;
using System.Linq.Expressions;

namespace S7 {
    class Program
    {
        static void Main(string[] args)
        {



            string original = "abcde FGHIJ ABC abc DEFG     ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3,5);
            string s6 = original.Replace('a','x');
            string s7 = original.Replace("abc","xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.WriteLine(original + "-");
            Console.WriteLine("--");
            Console.WriteLine(s1 + "-");
            Console.WriteLine("--");
            Console.WriteLine(s2 + "-");
            Console.WriteLine("--");
            Console.WriteLine(s3 + "-");
            Console.WriteLine("--");
            Console.WriteLine(n1 + "-");
            Console.WriteLine("--");
            Console.WriteLine(n2 + "-");
            Console.WriteLine("--");
            Console.WriteLine(s4 + "-");
            Console.WriteLine("--");
            Console.WriteLine(s5 + "-");
            Console.WriteLine("--");
            Console.WriteLine(s6 + "-");
            Console.WriteLine("--");
            Console.WriteLine(s7 + "-");
            Console.WriteLine("--");
            Console.WriteLine(b1 + "-");
            Console.WriteLine("--");
            Console.WriteLine(b2 + "-");



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
