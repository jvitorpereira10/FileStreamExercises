namespace FileStreamStreamReaderUsingPath
{
    class Startup
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\joao.santos\source\repos\docs\file1.txt";
            //string targetPath = @"C:\Users\joao.santos\source\repos\docs\file2.txt";

            StreamReader sr = new StreamReader(sourcePath);
            try
            {
                // FileInfo e File
                /*FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] files = File.ReadAllLines(targetPath);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }*/
                Console.WriteLine(sr.ReadToEnd());

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred " + Environment.NewLine + e.Message);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }
    }
}