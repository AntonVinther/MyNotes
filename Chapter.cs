public class Chapter
{
    public string Title;
    public List<Page> Pages;
    public Chapter(string title)
    {
        Title = title;
        Pages = new List<Page>();
    }

    public Chapter(string title, List<Page> pages)
    {
        Title = title;
        Pages = pages;
    }

    public void Read()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(Title);
        Console.ForegroundColor = ConsoleColor.White;
        
        int i = 0;
        foreach (Page page in Pages)
        {
            Console.WriteLine("\nLæser nu: Side " + ++i + " " + Title + "\n");
            page.Read();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n \nPress any key to move to the next page...");
            Console.ReadKey();
            Console.Clear();
        }
        
    }
}