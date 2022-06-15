using ExercicioFixacaoArquivos.Entities;
using System.Globalization;

namespace ExercicioFixacaoArquivos
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full pach: ");
            string dirOrigin = Console.ReadLine();

            //string dirOrigin = @"C:\Temp\Folders\docs";
            string sourceFile = dirOrigin + @"\SourceFile.csv";
            string outputFile = dirOrigin + @"\out\summary.csv";
            List<Product> products = new List<Product>();

            try
            {
                using (StreamReader sr = new StreamReader(sourceFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] lines = sr.ReadLine().Split(",");
                        Product product = new Product(lines[0], double.Parse(lines[1], CultureInfo.InvariantCulture), int.Parse(lines[2]));
                        products.Add(product);
                    }
                    Directory.CreateDirectory(dirOrigin + @"\out");
                    using (StreamWriter sw = File.AppendText(outputFile))
                    {
                        foreach (Product item in products)
                        {
                            sw.WriteLine(item.Name + "," + item.Total().ToString("F2", CultureInfo.InvariantCulture));

                        }
                    }
                }
            }
            catch (IOException e)
            {
                throw new IOException("An error ocurred: " + e.Message);
            }
        }
    }
}