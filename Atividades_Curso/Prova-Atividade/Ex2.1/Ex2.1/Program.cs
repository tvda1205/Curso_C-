//2.1

int codigo, qtd;
double preco, valor;



codigo = int.Parse(Console.ReadLine());

qtd = int.Parse(Console.ReadLine());

switch (codigo)
{
    case 1:
        preco = 4.00;
        valor = preco * qtd;
        Console.WriteLine("Custa: " + valor);
        break;

    case 2:
        preco = 4.50;
        valor = preco * qtd;
        Console.WriteLine("Custa: " + valor);
        break;

    case 3:
        preco = 5.00;
        valor = preco * qtd;
        Console.WriteLine("Custa: " + valor);
        break;
    
    case 4:
        preco = 2.00;
        valor = preco * qtd;
        Console.WriteLine("Custa: " + valor);
        break;

    case 5:
        preco = 1.50;
        valor = preco * qtd;
        Console.WriteLine("Custa: " + valor);
        break;

    default:
        Console.WriteLine("Codigo inválido");
        break;


}



