using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //Aluno a;
            //a = new Aluno();
            //Console.Write("Nome do Aluno: ");
            //a.Nome = Console.ReadLine();
            //Console.WriteLine("Digite as três notas do aluno: ");
            //a.N1 = double.Parse(Console.ReadLine());
            //a.N2 = double.Parse(Console.ReadLine());
            //a.N3 = double.Parse(Console.ReadLine());
            //Console.WriteLine(a);

            //Funcionario f;
            //f = new Funcionario();
            //Console.Write("Nome: ");
            //f.Nome = Console.ReadLine();
            //Console.Write("Salário Bruto: ");
            //f.SalarioBruto = double.Parse(Console.ReadLine());
            //Console.Write("Imposto: ");
            //f.Imposto = double.Parse(Console.ReadLine());
            //Console.WriteLine("Funcionário: " + f.Nome + ", $ " + f.SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture));
            //Console.Write("Digite a porcentagem para aumentar o salário: ");
            //f.AumentarSalario(double.Parse(Console.ReadLine()));
            //Console.WriteLine("Dados Atualizados: " + f.Nome + ", $ " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            //Retangulo forma;
            //forma = new Retangulo();
            //Console.WriteLine("Digite a Largura e Altura do retângulo:");
            //forma.Altura = double.Parse(Console.ReadLine());
            //forma.Largura = double.Parse(Console.ReadLine());
            //Console.WriteLine(forma);

            //##############  METODOS EM CLASSES

            //Produto item;
            //item = new Produto();
            //Console.WriteLine("Entre com os dados do produto:");
            //Console.Write("Nome: ");
            //item.Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //item.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade em estoque: ");
            //item.Quantidade = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Dados do Produto: " + item);
            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //item.AdicionarProdutos(int.Parse(Console.ReadLine()));
            //Console.WriteLine($"Dados do Produto: " + item);
            //Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            //item.RemoverProdutos(int.Parse(Console.ReadLine()));
            //Console.WriteLine($"Dados do Produto: " + item);

            //Triangulo x, y;
            //x = new Triangulo();
            //y = new Triangulo();

            //Console.WriteLine("Digite as Medidas de um Triângulo X:");

            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Digite as Medidas de um Triângulo Y:");

            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine($"A área de X = {x.Area().ToString("F4", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"A área de Y = {y.Area().ToString("F4", CultureInfo.InvariantCulture)}");

            //if (x.Area() > y.Area()) {
            //    Console.WriteLine("Maior área: X");
            //}
            //else {
            //    Console.WriteLine("Maior área: Y");
            //}

            //######################### exercicios

            //Pessoa fulano1, fulano2;
            //fulano1 = new Pessoa();
            //fulano2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa:");
            //Console.WriteLine("Nome:");
            //fulano1.Nome = Console.ReadLine();
            //Console.WriteLine("Idade:");
            //fulano1.Idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sálario:");
            //fulano1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Dados da segunda pessoa:");
            //Console.WriteLine("Nome:");
            //fulano2.Nome = Console.ReadLine();
            //Console.WriteLine("Idade:");
            //fulano2.Idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sálario:");
            //fulano2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if (fulano1.Idade>fulano2.Idade) {
            //    Console.WriteLine($"A pessoa mais velha: {fulano1.Nome}");
            //}
            //else if (fulano1.Idade==fulano2.Idade) {
            //    Console.WriteLine("As pessoa tem a mesma idade.");
            //}
            //else {
            //    Console.WriteLine($"A pessoa mais velha: {fulano2.Nome}");
            //}

            //Console.WriteLine($"Salário médio = { (( fulano1.Salario + fulano2.Salario )/2).ToString("F2",CultureInfo.InvariantCulture) } ");


            //Triangulo x, y;
            //x = new Triangulo();
            //y = new Triangulo();

            //Console.WriteLine("Digite as Medidas de um Triângulo X:");

            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Digite as Medidas de um Triângulo Y:");

            //y.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double px = (x.A + x.B + x.C) / 2;
            //double py = (y.A + y.B + y.C) / 2;

            //double Ax = Math.Sqrt(px * (px - x.A) * (px - x.B) * (px - x.C));
            //double Ay = Math.Sqrt(py * (py - y.A) * (py - y.B) * (py - y.C));

            //Console.WriteLine($"A área de X = {Ax.ToString("F4", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"A área de Y = {Ay.ToString("F4", CultureInfo.InvariantCulture)}");

            //if (Ax > Ay) {
            //    Console.WriteLine("Maior área: X");
            //}
            //else {
            //    Console.WriteLine("Maior área: Y");
            //}

            //Console.WriteLine("Digite as Medidas de um Triângulo X:");

            //double ax = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //double bx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double cx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Digite as Medidas de um Triângulo Y:");

            //double ay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double by = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double cy = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double px = (ax + bx + cx) / 2;
            //double py = (ay + by + cy) / 2;

            //double Ax = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
            //double Ay = Math.Sqrt(py * (py - ay) * (py - by) * (py - cy));

            //Console.WriteLine($"A área de X = {Ax.ToString("F4", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"A área de Y = {Ay.ToString("F4", CultureInfo.InvariantCulture)}");

            //if (Ax > Ay) {
            //    Console.WriteLine("Maior área: X");
            //}
            //else {
            //    Console.WriteLine("Maior área: Y");
            //}


        }
    }
}
