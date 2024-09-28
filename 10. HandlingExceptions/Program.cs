namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = Path.GetFullPath("tet.txt", Environment.CurrentDirectory);
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"A problem occured:\nEnsure the file exists.");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"A problem occured:\nEnsure the directory '{Environment.CurrentDirectory}' exists");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"A problem occured:\n{ex.Message}");
            }
            finally
            {
                Console.WriteLine("Press 'Enter' key to exit...");
            }
            Console.ReadLine();
        }
    }
}