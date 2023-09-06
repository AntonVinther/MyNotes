public class Book
{
    public string Title;
    public List<Chapter> Chapters;
    public Book(string title = "Programming notes")
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Title = title;
        Chapters = new List<Chapter>();
    }

    public Book(string title, List<Chapter> chapters)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Title = title;
        Chapters = chapters; 
    }

    public void PrintChapters()
    {
        //Print chapter titles
        Console.WriteLine("\nChapter titles:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (Chapter chapter in Chapters)
        {
            Console.WriteLine(chapter.Title);
        }
        Console.ResetColor();
    }

    private Chapter GetChapter(string title)
    {
        foreach (Chapter chapter in Chapters)
        {
            if (chapter.Title.ToLower() == title)
            {
                return chapter;
            }
        }
        return null;
    }

    public string RecursiveWriteLine(string text)
    {
        if (text.Length == 0)
        {
            return "";
        }
        else
        {
            Console.Write(text[0]);
            Thread.Sleep(1);
            return RecursiveWriteLine(text.Substring(1));
        }
    }

    public static void WriteLine(string text)
    {
        foreach (char letter in text)
        {
            Console.Write(letter);
            Thread.Sleep(1);
        }
    }

    public void Start()
    {
        while (true)
        {
            //Print book title and introduction
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Title);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Book.WriteLine("\nVelkommen til dine programmerings noter " +
                "\nDette program vil hjælpe dig med at huske alle de mega super awesome ting" +
                "\nsom Jesper (the G.O.A.T) har sagt\n");
        

            //Print chapter titles
            Console.ResetColor();
            PrintChapters();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nSkriv en kapitel titel (eller 'quit/q/exit' for at forlade programmet):");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit" || input.ToLower() == "q" || input.ToLower() == "exit")
            {
                break;
            }
            Chapter chapterToRead = GetChapter(input.ToLower());
            if (chapterToRead == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Chapter not found.\n");
                Console.ResetColor();
                continue;
            }
            chapterToRead.Read();
        }
    }
}