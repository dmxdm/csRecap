using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {



            /*
             

          ########  FOR

            int valor = 0; 

            Console.WriteLine("Quantos valores inteiro você irá digitar:");
            int numValores = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numValores ; i++) {
                Console.WriteLine($"Valor #{i}:");
                valor = valor + int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Soma = " + valor);

              
             
            ######## WHILE
             
            double num = 0.0;

            while (num >=0 ) {
                Console.WriteLine("Digite um número:");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (num >= 0 ) {
                    Console.WriteLine(Math.Sqrt(num).ToString("F3",CultureInfo.InvariantCulture));
                }
                else {
                    Console.WriteLine("NÚMERO NEGATIVO!!");
                } 
                   
                
            }
             ######## FUNCAO
            
            Console.WriteLine("Digite três números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);
                       
            
                      
            ############## exercercios propostos
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0) {
                imposto = 0.0;
            }
            else if (salario <= 3000.0) {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0) {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
           
           string[] valores = Console.ReadLine().Split(' ');
           double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
           double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

           if (x == 0.0 && y == 0.0) {
               Console.WriteLine("Origem");
           }
           else if (x == 0.0) {
               Console.WriteLine("Eixo Y");
           }
           else if (y == 0.0) {
               Console.WriteLine("Eixo X");
           }
           else if (x > 0.0 && y > 0.0) {
               Console.WriteLine("Q1");
           }
           else if (x < 0.0 && y > 0.0) {
               Console.WriteLine("Q2");
           }
           else if (x < 0.0 && y < 0.0) {
               Console.WriteLine("Q3");
           }
           else {
               Console.WriteLine("Q4");
           }

          double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           if (numero < 0.0 || numero > 100.0) {
               Console.WriteLine("Fora de intervalo");
           }
           else if (numero <= 25.0) {
               Console.WriteLine("Intervalo [0,25]");
           }
           else if (numero <= 50.0) {
               Console.WriteLine("Intervalo (25,50]");
           }
           else if (numero <= 75.0) {
               Console.WriteLine("Intervalo (50,75]");
           }
           else {
               Console.WriteLine("Intervalo (75,100]");
           }

           string[] valores = Console.ReadLine().Split(' ');
           int codigo = int.Parse(valores[0]);
           int quantidade = int.Parse(valores[1]);

           double total;
           if (codigo == 1) {
               total = quantidade * 4.0;
           }
           else if (codigo == 2) {
               total = quantidade * 4.5;
           }
           else if (codigo == 3) {
               total = quantidade * 5.0;
           }
           else if (codigo == 4) {
               total = quantidade * 2.0;
           }
           else {
               total = quantidade * 1.5;
           }

           Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


           string[] valores = Console.ReadLine().Split(' ');
           int horaInicial = int.Parse(valores[0]);
           int horaFinal = int.Parse(valores[1]);

           int duracao;
           if (horaInicial < horaFinal) {
               duracao = horaFinal - horaInicial;
           }
           else {
               duracao = 24 - horaInicial + horaFinal;
           }

           Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");



           string[] valores = Console.ReadLine().Split(' ');
           int A = int.Parse(valores[0]);
           int B = int.Parse(valores[1]);

           if (A % B == 0 || B % A == 0) {
               Console.WriteLine("Sao Multiplos");
           }
           else {
               Console.WriteLine("Nao sao Multiplos");
           }

           int N = int.Parse(Console.ReadLine());

           if (N % 2 == 0) {
               Console.WriteLine("PAR");
           }
           else {
               Console.WriteLine("IMPAR");
           }


          int N = int.Parse(Console.ReadLine());

          if (N < 0) {
              Console.WriteLine("NEGATIVO");
          }
          else {
              Console.WriteLine("NAO NEGATIVO");
          }



          ###########  IF ELSE


          Console.WriteLine("Qual a hora atual?");
          int x = int.Parse(Console.ReadLine());

          if (x < 12) {
              Console.WriteLine("Bom dia!");
          }
          else if (x < 18) {
              Console.WriteLine("Boa tarde!");
          }
          else {
              Console.WriteLine("Boa noite!");
          }


          Console.WriteLine("Digite um número inteiro: ");
          int x = int.Parse(Console.ReadLine());

          if (x % 2 == 0) {
              Console.WriteLine("Par!");
          }
          else {
              Console.WriteLine("Impar!");
          }


         int x = 10;

         Console.WriteLine("bom dia");

         if (x<15) {
         Console.WriteLine("boa tarde");
         }

         Console.WriteLine("boa noite");

          ######### OPERADORES LOGICOS

         bool c0 = 2 > 3 && 4 != 5;
         Console.WriteLine(c0);
         bool c1 = 2 > 3 || 4 != 5;
         Console.WriteLine(c1);
         bool c2 = !(2 > 3) && 4 != 5;
         Console.WriteLine(c2);

         Console.WriteLine("________");

         bool c3 = 10 < 5;
         bool c4 = c1 || c2 && c3;
         Console.WriteLine(c3);
         Console.WriteLine(c4);

         ###### OPERADORES COMPARATIVOS

         int a = 10;
         bool c1 = a < 10;
         bool c2 = a < 20;
         bool c3 = a > 10;
         bool c4 = a > 5;
         Console.WriteLine(c1);
         Console.WriteLine(c2);
         Console.WriteLine(c3);
         Console.WriteLine(c4);
         Console.WriteLine("-----------");
         bool c5 = a <= 10;
         bool c6 = a >= 10;
         bool c7 = a == 10;
         bool c8 = a != 10;
         Console.WriteLine(c5);
         Console.WriteLine(c6);
         Console.WriteLine(c7);
         Console.WriteLine(c8);

         ######### EXERCICIOS PROPOSTOS 1

        string[] valores = Console.ReadLine().Split(' ');

        double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

        Console.WriteLine($"TRIANGULO: {((a*c)/2).ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"CIRCULO:  {(3.14159 * Math.Pow(c, 2)).ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"TRAPEZIO: {(((a + b) * c) / 2).ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"QUADRADO: {(Math.Pow(b, 2)).ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"RETÂNGULO: {(a * b).ToString("F3", CultureInfo.InvariantCulture)}");           

        string[] peca1 = Console.ReadLine().Split();
        int numPeca1 = int.Parse(peca1[0]);
        int qtPeca1 = int.Parse(peca1[1]);
        double vPeca1 = double.Parse(peca1[2],CultureInfo.InvariantCulture);
        string[] peca2 = Console.ReadLine().Split();
        int numPeca2 = int.Parse(peca2[0]);
        int qtPeca2 = int.Parse(peca2[1]);
        double vPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);
        Console.WriteLine($"VALOR A PAGA: R$ {(vPeca1 * qtPeca1 + vPeca2 * qtPeca2).ToString("F2", CultureInfo.InvariantCulture)} ");

        int numeroDoFuncionario = int.Parse(Console.ReadLine());
        int horaTrabalhadas = int.Parse(Console.ReadLine());
        double valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Console.WriteLine($"NUMBER = {numeroDoFuncionario}");
        Console.WriteLine($"SALARY = U$ {((double)horaTrabalhadas*valorHora).ToString("F2",CultureInfo.InvariantCulture)}");           /*

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int diferenca = (a * b - c * d);
        Console.WriteLine($"Diferença = {diferenca}");            

        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double area = 3.14159 * Math.Pow(raio, 2);
        Console.WriteLine($"A = {area.ToString("F4",CultureInfo.InvariantCulture)}");

        int a= int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Soma = {a + b}");


        Console.WriteLine("Entre com seu Nome Completo:");
        string nomeCompleto =Console.ReadLine();
        Console.WriteLine("Quantos quartos tem na sua casa?");
        int quartos = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o preço de um produto:");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
        string[] vet = Console.ReadLine().Split(' ');
        string sobrenome = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
        Console.WriteLine("Você digitou:");
        Console.WriteLine(nomeCompleto);
        Console.WriteLine(quartos);
        Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine(sobrenome);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));


        ################# ENTRADA DE DADOS
        int n1 = int.Parse(Console.ReadLine());
        char ch = char.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        string[] vet = Console.ReadLine().Split(' ');
        string nome = vet[0];
        char sexo = char.Parse(vet[1]);
        int idade = int.Parse(vet[2]);
        double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

        Console.WriteLine("Você digitou:");
        Console.WriteLine(n1 + " " + ch + "     " + n2.ToString("F2", CultureInfo.InvariantCulture));           
        Console.WriteLine(nome + " " + sexo + " " + idade + " " + altura.ToString("F2", CultureInfo.InvariantCulture));


        //string frase = Console.ReadLine();
        //string[] vet = frase.Split(' ');
        string[] vet = Console.ReadLine().Split(' ');

        string a = vet[0];
        string b = vet[1];
        string c = vet[2];

        Console.WriteLine("Você digitou:");
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        string frase = Console.ReadLine();
        string x = Console.ReadLine();
        string y = Console.ReadLine();
        Console.WriteLine("Você digitou:");
        Console.WriteLine(frase);
        Console.WriteLine(x);
        Console.WriteLine(y);

        string frase = Console.ReadLine();
        Console.WriteLine("Você digitou: " + frase);

        ######## OPERADOR ARITIMETICO
        double a = 1.0, b = -3.0, c = -4.0;
        //double delta = b * b - 4.0 * a * c;
        double delta = Math.Pow(b, 2) - 4.0 * a * c;

        double x1 = (-b + Math.Sqrt(delta))/ (2.0 * a);
        double x2 = (-b - Math.Sqrt(delta))/ (2.0 * a);

        Console.WriteLine(x1);
        Console.WriteLine(x2);



       int n1 = 3 + 4 * 2;
       int n2 = (3 + 4) * 2;
       int n3 = 17 % 3;
       //  double n4 = 10 / 8; não da certo, fica um resultado inteiro
       // double n4 = (double) 10 / 8; ok
       double n4 = 10.8 / 8; // ourto metodo

       Console.WriteLine(n1);
       Console.WriteLine(n2);
       Console.WriteLine(n3);
       Console.WriteLine(n4);

       converção e casting
      int a = 5;
      int b = 2;
      double resultado = (double) a / b;
      Console.WriteLine(resultado);



      double a;
      int b;

      a = 5.6;
      b = (int)a;
      Console.WriteLine(b);
      //casting, computador pode jogar isso se perde informação o problema é do programador. Aqui truncou o numero em 5.

     double a;
     float b;

     a = 5.1;
     b = (float)a; //casting, computador pode jogar isso se perde informação o problema é do programador.
     Console.WriteLine(b);
     // não dá para fazer o contrario por conta do tamanho de bytes sem colocar um casting

     float x = 4.5f;
     double y = x;
     Console.WriteLine(y);
      //converte naturalmente por que double é maior em bytes dos que float

     ############ Operadores

     int a = 10;
     int b = ++a;
     Console.WriteLine(a);
     Console.WriteLine(b);

     int a = 10;
     Console.WriteLine(a);
     a += 2;
     Console.WriteLine(a);
     a *= 3;
     Console.WriteLine(a);

     string s = "ABC";
     Console.WriteLine(s);
     s += "DEF";
     Console.WriteLine(s);

     ############ exercicio

     string produto1 = "Computador";
     string produto2 = "Mesa de escritório";

     byte idade = 30;
     int codigo = 5290;
     char genero = 'M';

     double preco1 = 2100.0;
     double preco2 = 650.50;
     double medida = 53.244567;

     Console.WriteLine("Produtos:");
     Console.WriteLine($"{produto1}, cujo preço é R$ {preco1.ToString("F2", CultureInfo.InvariantCulture)}");
     Console.WriteLine($"{produto2}, cujo preço é R$ {preco2.ToString("F2", CultureInfo.InvariantCulture)}");
     Console.WriteLine();
     Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
     Console.WriteLine();
     Console.WriteLine($"Medida com oito casa decimais: {medida.ToString("F8")}");
     Console.WriteLine($"Arredondando (três casa decimais): {medida.ToString("F3")}");
     Console.WriteLine($"Separado decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

     int idade = 32;
     double saldo = 10.35784;
     string nome = "Maria";

     ############# Saida de dados

     //PlaceHolder
     Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

     //Interpolação
     Console.WriteLine($"{nome} tem {idade} anos e saldo igual a {saldo.ToString("F2")} reais");

     //Concatenar
     Console.WriteLine(nome + " tem " + idade + " anos e saldo igual a " + saldo.ToString("F2") + " reais");
     Console.WriteLine(nome + " tem " + idade + " anos e saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

     char genero = 'F';
     int idade = 32;
     double saldo = 10.35784;
     string nome = "Maria";

     Console.Write("Bom dia!");
     Console.WriteLine("Boa tarde!");
     Console.WriteLine("Boa noite!");
     Console.WriteLine("---------------");
     Console.WriteLine(genero);
     Console.WriteLine(idade);
     Console.WriteLine(saldo);
     Console.WriteLine(nome);
     Console.WriteLine(saldo.ToString("F2"));
     Console.WriteLine(saldo.ToString("F4"));
     Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

     ############ tipo de variavies

     int n1 = int.MinValue;
     int n2 = int.MaxValue;
     sbyte n3 = sbyte.MinValue;
     decimal n4 = decimal.MaxValue;

     Console.WriteLine(n4);
     Console.WriteLine(n3);
     Console.WriteLine(n2);
     Console.WriteLine(n1);

     ############ tipo de variavies

     byte n1 = 126;
     int n2 = 1000;
     int n3 = 2147483647;
     long n4 = 2147483648L;
     bool completa = true;
     char genero = 'F';
     char letra = '\u0041';
     float n5 = 4.5f;
     double n6 = 4.5;
     string nome = "Maria Green";
     object obj1 = "Alex Brown";
     object obj2 = 4.5f;

     Console.WriteLine(obj1);
     Console.WriteLine(obj2);
     Console.WriteLine(nome);
     Console.WriteLine(letra);
     Console.WriteLine(genero);
     Console.WriteLine(completa);
     Console.WriteLine(n1);
     Console.WriteLine(n2);
     Console.WriteLine(n3);
     Console.WriteLine(n4);
     Console.WriteLine(n5);
     Console.WriteLine(n6);

     */







        }

        static double Maior(int a, int b, int c) {

            if (a > b && a > c) {
                return a;
            }
            else if (b > c) {
                return b;
            }
            else {
                return c;
            }
        }

    }
}




