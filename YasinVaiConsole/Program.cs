class YasinVaiConsole
{
    public static void Main(string[] args)
    {
        Matrix4x4();
        //Palindrome();
        //LeapCheck();
        //UniqueCheck();
        //FibonacchiR(100);
        //FactorialSum(25);
    }
    public static void Matrix4x4()
    {
        string[][] data = new string[4][];
        for (var i = 0; i < 4; i++)
        {
            Console.WriteLine("Write The Matrix " + i + "'s row:");
            data[i] = new string[4];
            for (var j = 0; j < 4; j++)
            {
                data[i][j] = Console.ReadLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine("The matrix is:");
        for (var i = 0; i < 4; i++)
        {
            for (var j = 0; j < 4; j++)
            {
                Console.Write(data[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("The Swaped matrix is:");
        for (var i = 0; i < 4; i++)
        {
            for (var j = 0; j < 4; j++)
            {
                Console.Write(data[j][i] + " ");
            }
            Console.WriteLine();
        }
    }
    public static void Palindrome()
    {
        int data;
        Console.Write("Enter a number:");
        data = Convert.ToInt32(Console.ReadLine());

        if (1 <= data && data <= 100)
        {
            for (var i = 0; i < data; i++)
            {
                string text;
                Console.Write("Enter your Word: ");
                text = Console.ReadLine();

                if (text != null || text != "")
                {
                    var count = 0;
                    for (var j = 0; j < text.Length; j++)
                    {
                        if (text[j] == text[text.Length - 1 - j])
                        {
                            count++;
                        }
                    }

                    if (text.Length == count)
                    {
                        Console.Write("palindrome");
                    }
                    else
                    {
                        Console.Write("not palindrome");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Emplty!!!");
                }
            }
        }
        else
        {
            Console.WriteLine("Number Out of Range!!!");
        }


    }
    public static void LeapCheck()
    {
        string data;
        Console.Write("Enter a number:");
        data = Console.ReadLine();
        int year = Convert.ToInt32(data);

        if (year.GetType() == typeof(int))
        {

            if (year % 4 == 0)
            {
                Console.WriteLine("LY");
            }
            else
            {
                Console.WriteLine("NLY");
            }
        }
        else
        {
            Console.WriteLine("NAN");
        }
    }
    public static void UniqueCheck()
    {
        int data;
        Console.Write("Enter a number:");
        data = Convert.ToInt32(Console.ReadLine());

        if (1 <= data && data <= 20)
        {
            for (var i = 0; i < data; i++)
            {
                string text;
                Console.Write("Enter your Word: ");
                text = Console.ReadLine();
                int count = 0;
                for (var j = 0; j < text.Length; j++)
                {
                    for (var k = 0; k < text.Length; k++)
                    {
                        if (text[j] == text[k])
                        {
                            count++;
                        }
                    }
                }
                if (count > text.Length)
                {
                    Console.WriteLine("Not Unique");
                }
                else
                {
                    Console.WriteLine("Unique");
                }
            }
        }
    }
    public static void FibonacchiR(int n, long a = 0, long b =1)
    {
        if (n > 0)
        {
            Console.WriteLine(n +" => "+a);
            FibonacchiR(n - 1, b, a + b);
        }
    }

    //public static void FibonacchiR() {
    //    int a = 0;
    //    int b = 1;
    //    int fib = 0;
    //    for (var i = 0;i < 100;i++) {
    //        fib = a + b;
    //        Console.WriteLine(i+1 +" -> " + fib);
    //        a = b;
    //        b = fib;
    //    }
    //}

    public static void FactorialSum(int n)
    {
        long sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += Factorial(i);
        }
        Console.WriteLine("Sum of factorials up to " + n + ": " + sum);
    }
    public static long Factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }

        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
