// See https://aka.ms/new-console-template for more information
Console.WriteLine("This Program Calculates divisors of an integer > 1.");
int n;

while (true)
{
    Console.WriteLine("Enter an integer > 1 to start or 0 to exit");
    var str = Console.ReadLine();
    if (!int.TryParse(str, out n))
    {
        Console.WriteLine($"You entered invalid input '{str}'.");
        continue;
    }

    if (n == 0)
    {
        Console.WriteLine("You enter 0, thanks for using this program. Good Bye!");
        break;
    }

    if (n <= 1)
    {
        Console.WriteLine($"You entered an invalid integer '{n}' <= 1");
        break;
    }

    int sum = 1;
    Console.WriteLine("{0} and {1} divides {2}", 1, n, n);
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {

            Console.WriteLine("{0} and {1} divides {2}", i, n / i, n);
            sum += i + (n/i);
        }
    }
    if (sum == n)
    {
        Console.WriteLine("The number {0} is a perfect number", n);
    }
}