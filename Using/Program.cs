namespace FileStreamStreamReaderUsingPath
{
    class Startup
    {
        static void Main(string[] args)
        {
            string originPath = @"C:\BackupNoteOnclick\Arquivos\QA\JSONPedidoDebug\GETOrderHUB_FLORA.txt";
            string destinationPath = @"C:\BackupNoteOnclick\Arquivos\QA\JSONPedidoDebug\GETOrderHUB_FLORA_novo.txt";

            /* Realizando a abertura e leitura de arquivos
            try
            {
                using (StreamReader sr = File.OpenText(originPath))
                {
                    string teste = sr.ReadToEnd().Replace("\r","").Replace("\n","").Replace("\","");
                    Console.WriteLine(teste);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred" + Environment.NewLine + e.Message);
            }*/

            //Escrevendo em arquivos
            try
            {
                using (StreamReader sr = new StreamReader(originPath))
                {
                    using (StreamWriter sw = new StreamWriter(destinationPath))
                    {
                        string pedidoDebug = sr.ReadToEnd();
                        sw.WriteLine(pedidoDebug.ToUpper());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred" + Environment.NewLine + ex.Message);
            }

            //Outra forma de escrever arquivos, adicionando o novo texto ao final do texto já existente, com a função Append()
            //Como no bloco abaixo está sendo utilizada a função Append(), o mesmo texto do arquivo origem será concatenado ao final do novo arquivo.
            //Caso o arquivo não exista, ele será criado. Caso contrário, o arquivo existente terá seu conteúdo sobrescrito com o texto;
            try
            {
                string[] lines = File.ReadAllLines(originPath);
                using (StreamWriter sw = File.AppendText(destinationPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred" + Environment.NewLine + ex.Message);
            }
        }
    }
}