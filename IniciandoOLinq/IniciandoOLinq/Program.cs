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
        //Usando o where para filtrar a fonte de dados, ou seja, criando uma condição
        //Usando o Select para pegar cada elemento que tem números pares e multiplicando por 10, gerando uma nova coleção 
        
        // Executar a consulta

        foreach (var x in result)
        {
            Console.WriteLine(x);
        }
    }
}