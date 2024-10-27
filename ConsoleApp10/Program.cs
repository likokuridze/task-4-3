// See https://aka.ms/new-console-template for more information

{

    {

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());


        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }
}


