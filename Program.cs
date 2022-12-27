using System;

public class Program
{
    public static void Main(string[] args)
    {
        var arr = new int[5];

        try
        {
            Console.Clear();
            for (var index = 0; index < 10; index++)
            {
                Console.WriteLine(arr[index]);
            }
        }
        catch(IndexOutOfRangeException exp)
        {
            Console.WriteLine(exp.InnerException);
            Console.WriteLine(exp.Message);
            Console.WriteLine("Índice não encontrado!");
        }
        catch (Exception exp)
        {
            Console.Clear();
            Console.WriteLine(exp.InnerException);
            Console.WriteLine(exp.Message);
            Console.WriteLine("Desculpe, algo deu errado!!!");
        }
    }
}
