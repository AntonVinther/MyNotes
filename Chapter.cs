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
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Title);
        Console.ResetColor();
        Console.WriteLine("\nChapter contents:");
        int i = 0;
        foreach (Page page in Pages)
        {
            Console.WriteLine("\nReading page " + ++i);
            page.Read();
            Console.WriteLine("\nPress any key to move to the next page...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}