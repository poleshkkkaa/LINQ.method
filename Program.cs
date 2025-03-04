using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] A = { "apple", "bank", "cherry", "dog" };

        var result = A.Reverse().Select(w => w[0]);

        foreach (var latters in result)
        {
            Console.Write(latters + " ");
        }
    }
}
