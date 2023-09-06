Chapter chapter1 = new Chapter("Kapitel 1");
{
    List<Page> pages = new List<Page>();

    Page side = new Page(Variabler.side1);
    Page side2 = new Page(Variabler.side2);

    pages.Add(side);
    pages.Add(side2);
    
    chapter1.Pages = pages;
}


Chapter chapter2 = new Chapter("Kapitel 2");
{
    List<Page> pages = new List<Page>();

    Page side = new Page(conditionals.side1);
    Page side2 = new Page(conditionals.side2);

    pages.Add(side);
    pages.Add(side2);
    
    chapter2.Pages = pages;
}

Chapter chapter3 = new Chapter("Kapitel 3");
{
    List<Page> pages = new List<Page>();

    Page side = new Page(Arrays.side1);
    Page side2 = new Page(Arrays.side2);

    pages.Add(side);
    pages.Add(side2);
    
    chapter3.Pages = pages;
}

Book bog1 = new Book("Dine Programmeringsnoter");
List<Chapter> chapters = new List<Chapter>();
chapters.Add(chapter1);
chapters.Add(chapter2);
chapters.Add(chapter3);
bog1.Chapters = chapters;

bog1.Start();