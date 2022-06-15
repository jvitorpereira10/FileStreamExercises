namespace DirectoryDirectoryInfo
{
    class Startup
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\Folders";

            try
            {
                //Listando todos os sub-diretórios a partir da pasta inicial
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                //Listando todos os arquivos das sub-pastas a partir da pasta inicial
                var files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories);
                Console.WriteLine();
                Console.WriteLine("FILES: ");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                //Criando uma nova pasta utilizando o diretório já existente
                Directory.CreateDirectory(path + @"\newfolder");
                Console.WriteLine();
                Console.WriteLine("DIRECTORY UPDATED: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred" + Environment.NewLine + e.Message);
            }
        }
    }
}