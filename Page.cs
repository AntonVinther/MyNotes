public class Page
{
    public string Content;

    public Page(string content)
    {
        Content = content;
    }

    public void Read()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Book.WriteLine(Content);
        Console.ResetColor();
    }
}