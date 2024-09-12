// Exercicio For

int numb = int.Parse(Console.ReadLine());

while (numb < 1 || numb > 1000 )
{
    numb = int.Parse(Console.ReadLine());
}

for  (int i = 0; i < numb; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}