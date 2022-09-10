Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int tmp = num;
int sum = 0;

if (num > 0)
    {
        while (tmp != 0)
        {
            if (num % (tmp%10) ==0)
            sum += tmp%10;

            tmp = tmp / 10;
        }
        Console.WriteLine(sum);
    }
             