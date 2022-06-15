namespace MetodoPath
{
    class Startup
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\Folders\newfolder\file1.txt";
            try
            {
                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
                Console.WriteLine("GetFileName: " + Path.GetFileName(path));
                Console.WriteLine("GetExtension: " + Path.GetExtension(path));
                Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
                Console.WriteLine("GetTempPath: " + Path.GetTempPath());

            }
            catch (Exception e)
            {
                throw new Exception("An error ocurred: " + e.Message);
            }
        }
    }
}