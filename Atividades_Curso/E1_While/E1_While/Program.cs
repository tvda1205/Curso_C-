// Ex While


int clienteGasolina = 0;

int clienteAlcool = 0;

int clienteDiesel = 0;

int tipo = int.Parse(Console.ReadLine());

while (tipo != 4)
{
    if (tipo == 1)
    {
         clienteAlcool += 1;
    }
    else if (tipo == 2)
    {
        clienteGasolina += 1;
    }
    else if(tipo == 3)
    {
        clienteDiesel += 1;
    }

    tipo = int.Parse(Console.ReadLine());

}

Console.WriteLine("Muito Obrigado");
Console.WriteLine("Clientes que usaram alcool: " + clienteAlcool);
Console.WriteLine("Clientes que usaram gasolina: " + clienteGasolina);
Console.WriteLine("Clientes que usaram diesel: " + clienteDiesel);