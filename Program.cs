using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        char op;

        Console.Write("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o operador (+, -, *, /): ");
        op = Convert.ToChar(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        if (op == '+')
        {
            result = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
        }
        else if (op == '-')
        {
            result = num1 - num2;
            Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
        }
        else if (op == '*')
        {
            result = num1 * num2;
            Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
        }
        else if (op == '/')
        {
            result = num1 / num2;
            Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
        }
        else
        {
            Console.WriteLine("Operador inválido!");
        }

        Console.ReadLine();
    }
}

