using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {

            Banco b;

            Console.Write("Entre com o Número da Conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o Titular da Conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá Déposito Inicial (s/n): ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                b = new Banco(conta, titular, saldo);
            }
            else {
                b = new Banco(conta, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(b);
            Console.WriteLine();

            Console.Write("Entre o valor de depósito: ");
            b.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(b);
            Console.WriteLine();

            Console.Write("Entre o valor de saque: ");
            b.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(b);
            Console.WriteLine();





            //Produto p = new Produto("TV", 500.00, 10);
            //Console.WriteLine(p.Nome);
            //p.Nome = "T";             // p.Nome = funciona porque tem Set na properties, mas p.Preco = não por que não tem Set
            //Console.WriteLine(p.Preco);


            //Produto p = new Produto("TV", 500.00, 10);
            //Console.WriteLine(p.Nome);
            //p.Nome = "TV 4K";             // p.Nome = funciona porque tem Set na properties, mas p.Preco = não por que não tem Set
            //Console.WriteLine(p.Preco);


            //################## Encapsulamento SET GET
            //Produto p = new Produto("TV", 500.00, 10);
            //Console.WriteLine(p.GetNome());
            //p.SetNome("TV 4K");
            //Console.WriteLine(p.GetPreco());


            //############### SOBRECARGA DE CONSTRUTORES
            //Console.WriteLine("Entre os dados do produto:");
            //Console.Write("Nome: ");
            //string Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Produto p = new Produto(Nome, Preco);
            //Produto p2 = new Produto();
            //Produto p3 = new Produto { Nome = "TV", Preco = 500.00, Quantidade = 20 };

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);
            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);
            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);
            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser removido do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);
            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);






            //Console.WriteLine("Entre os dados do produto:");
            //Console.Write("Nome: ");
            //string Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Produto p = new Produto(Nome, Preco);

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);
            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);
            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);
            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser removido do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);
            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);


            //#################### Contrutores

            //Console.WriteLine("Entre os dados do produto:");
            //Console.Write("Nome: ");
            //string Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //int Quantidade = int.Parse(Console.ReadLine());

            //Produto p = new Produto(Nome,Preco,Quantidade);

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);
            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);
            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);
            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser removido do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);
            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);

        }
    }
}