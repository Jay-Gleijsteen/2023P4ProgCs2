namespace ListOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Birds = new List<string>()
            {
                "kraai",
                "uil",
                "hond",
                "papagaai"
        };

            List<string> Birds2 = new List<string>()
            {
                "meeuw",
                "duif"
            };

            Birds.AddRange(Birds2);
            Birds.Remove(Birds[2]);
            for (int i = 0; i < Birds.Count; i++)

                Console.WriteLine(Birds[i]);
        }
    }
}
