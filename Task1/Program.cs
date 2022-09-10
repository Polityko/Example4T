Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение степени (число B), в которую будет возводиться число А: ");
int B = Convert.ToInt32(Console.ReadLine());

int power = A;

for (int i = 1; i < B; i++)
{
    power = power * A;
}

Console.WriteLine("A в степени B равно " + power);