
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] name = GetName();
        double[] price = GetPrice(name);
        double budget = GetBudget();

        for(int i = 0; i < price.Length; i++)
        {
            if(price[i] < budget)
            Console.WriteLine("o produto {0} custa {1} e cabe no seu orçamento", name[i],price[i]);
        }
        Console.ReadKey();
    }

    static double GetBudget()
    { 
        Console.WriteLine("Qual o orçamento?");
        double budget = double.Parse(Console.ReadLine());
        return budget;
    }
    static double[] GetPrice(string[] ProductName)
    {
        double[] ProductPrice = new double[10];
        for (int i = 0; i < ProductPrice.Length; i++)
        {
            Console.WriteLine("digite o preço do produto {0}", ProductName[i]);
            ProductPrice[i] = double.Parse(Console.ReadLine());
        }
        
        return ProductPrice;
    }
        static string[] GetName()
        { 
            string[] ProductName = new string[10];
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("digite o {0}° produto", i + 1);
                ProductName[i] = Console.ReadLine();
            }
            for(int i = 0; i<ProductName.Length; i++)
        {
            Console.WriteLine(" produto {0}: {1}", i + 1, ProductName[i]);
        }
            return ProductName;
        }

        /* for(int i = 0; i < ProductPrice.Length; i++)
         {
             Console.WriteLine("o produto {0} custa R${1}", ProductName[i], ProductPrice[i]);
         }*/
}


