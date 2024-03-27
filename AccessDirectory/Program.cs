using AccessDirectory;
public class Program
{
    private static void Main(string[] args)
    {

        DirectoryPath dir = new DirectoryPath();

        Console.WriteLine("Acessando Diretorio");
        dir.ExecuteCloneCommand();

        dir.listDirectory();

       
    }
}