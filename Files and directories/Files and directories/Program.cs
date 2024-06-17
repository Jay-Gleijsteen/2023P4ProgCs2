namespace Files_and_directories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\jayjl\OneDrive\Documenten\GitHub\2023P4ProgCs2");//maak een nieuwe naar 1 van de directories in de test directory (volledig path vergeet je @ niet!)
            FileInfo[] fileInfos = dir.GetFiles();
            for (int i = 0; i < fileInfos.Length; i++)
            {
                Console.WriteLine(fileInfos[i]);
            }
            DirectoryInfo[] directoryInfos = dir.GetDirectories();
            for (int i = 0; i < directoryInfos.Length; i++)
            {
                Console.WriteLine(directoryInfos[i]);
            }
        }
    }
}
