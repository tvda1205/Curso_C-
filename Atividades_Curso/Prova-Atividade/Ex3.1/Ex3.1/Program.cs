// Ex 3.1


int senhaCorreta = 2002;

int senha;


senha = Int32.Parse(Console.ReadLine());

while (senha != senhaCorreta)
{
    Console.WriteLine("Senha Invalida");

    senha = Int32.Parse(Console.ReadLine());
}

Console.WriteLine("Acesso Permitido");