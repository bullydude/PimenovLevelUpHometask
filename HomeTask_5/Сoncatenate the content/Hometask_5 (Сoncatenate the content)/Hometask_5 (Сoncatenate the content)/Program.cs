using System.Text;

namespace Hometask_5_Сoncatenate_the_content
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter files directory: ");
            string fileDirectory = Console.ReadLine() ?? string.Empty;

            var txtFolder = Directory.EnumerateFiles(fileDirectory, "*.txt");
            var strBuilder = new StringBuilder();
            foreach (var txtPath in txtFolder)
            {
                var text = File.ReadAllTextAsync(txtPath, CancellationToken.None).Result;
                strBuilder.Append(text + "\n");
            }
            File.WriteAllTextAsync($"{fileDirectory}//Result.txt",
                strBuilder.ToString(),
                Encoding.Unicode,
                CancellationToken.None);

        }
    }
}