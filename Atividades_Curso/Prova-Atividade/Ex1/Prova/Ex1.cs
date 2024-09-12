// Exercicio 01

int cod1, cod2, unit1, unit2;
float preco1, preco2, valorTotal;


Console.WriteLine("Digite o codigo para o primeiro produto");

cod1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor unitario para o primeiro produto");

preco1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade do primeiro produto");

unit1 = Int32.Parse(Console.ReadLine());


Console.WriteLine("Digite o codigo para o segundo produto");

cod2 = Int32.Parse(Console.ReadLine());


Console.WriteLine("Digite o valor unitario para o segundo produto");

preco2 = float.Parse(Console.ReadLine());


Console.WriteLine("Digite a quantidade do segundo produto");

unit2 = Int32.Parse(Console.ReadLine());

valorTotal = (unit1 * preco1) + (unit2 * preco2);

Console.WriteLine(valorTotal);