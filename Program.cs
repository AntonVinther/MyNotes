List<Page> pages = new List<Page>();

Page side = new Page(MyNotes.side);
Page side2 = new Page(MyNotes.side2);
 
pages.Add(side);
pages.Add(side2);

Chapter chapter1 = new Chapter("Kapitel 1");
chapter1.Pages = pages;
Chapter chapter2 = new Chapter("Kapitel 2", pages);

chapter1.Read();
chapter2.Read();


Book bog1 = new Book("Dine Programmeringsnoter");
List<Chapter> chapters = new List<Chapter>();
chapters.Add(chapter1);
chapters.Add(chapter2);

// pause
Console.ReadLine();

bog1.Start();