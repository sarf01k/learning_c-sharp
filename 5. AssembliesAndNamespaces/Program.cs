namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // string text = "First line";

            // string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // File.WriteAllText(Path.Combine(docPath, "WriteFile.txt"), text);

            System.Net.WebClient client = new System.Net.WebClient();
            string reply = client.DownloadString("https://learn.microsoft.com/en-us/dotnet/api/system.net.webclient.downloadstring?view=net-8.0");

            Console.WriteLine(reply);
            Console.ReadLine();
        }
    }
}