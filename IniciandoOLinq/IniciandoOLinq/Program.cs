namespace IniciandoOLinq;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        //Especificar o data source, ou fonte de dados

        int[] numbers = new[] { 2, 3, 4, 5 };
        
        //Definir a expressão de consulta

        var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
        
        // Executar a consulta

        foreach (var x in result)
        {
            Console.WriteLine(x);
        }
    }
}