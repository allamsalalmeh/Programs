// See https://aka.ms/new-console-template for more information
Console.WriteLine("This Program to Calculate GCF");
Console.WriteLine("Enter number bigger than 1 to start or 0 to exit");
int i;
allam:
if (int.TryParse(Console.ReadLine(), out i)) {
    while (i != 0)
    {
        int j = 1;
        int c = 0;
        for (int b = 1; b < i; b++)
        {
            if (i % b == 0)
            {

                Console.WriteLine("The GCF{0} = {1}", j, b);
                c = c + b;
                j++;
            }


        }
        if (c == i)
        {
            Console.WriteLine("The number {0} is perfect number", i);
        }
        Console.WriteLine("Enter number bigger than 1 to start or 0 to exit");
        //i = Convert.ToInt32(Console.ReadLine());
        goto allam;
    }
}
else {
    Console.WriteLine("You enter wrong Number please renter vaild");
    goto allam;
        }