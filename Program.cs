using System;

public class Program
{
    public static void Main(string[] args)
    {
        var arr = new int[5];

        try
        {
            //Console.Clear();
            //for (var index = 0; index < 10; index++)
            //{
            //    Console.WriteLine(arr[index]);
            //}

            Register("");
        }
        catch(IndexOutOfRangeException exp)
        {
            Console.WriteLine(exp.InnerException);
            Console.WriteLine(exp.Message);
            Console.WriteLine("Índice não encontrado!");
        }
        catch(ArgumentNullException exp)
        {
            Console.WriteLine(exp.InnerException);
            Console.WriteLine(exp.Message);
            Console.WriteLine("Falha ao cadastrar o texto!");
        }
        catch (Exception exp)
        {
            Console.Clear();
            Console.WriteLine(exp.InnerException);
            Console.WriteLine(exp.Message);
            Console.WriteLine("Desculpe, algo deu errado!!!");
        }
    }
    private static void Register(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
        }
    }
}
