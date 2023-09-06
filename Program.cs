List<Page> pages = new List<Page>();

Page side = new Page(Variabler.side1);
Page side2 = new Page(Variabler.side2);
 
pages.Add(side);
pages.Add(side2);

Chapter chapter1 = new Chapter("Kapitel 1");
chapter1.Pages = pages;
Chapter chapter2 = new Chapter("Kapitel 2", pages);

Chapter chapter3 = new Chapter("Kapitel 3", pages);

Book bog1 = new Book("Dine Programmeringsnoter");
List<Chapter> chapters = new List<Chapter>();
chapters.Add(chapter1);
chapters.Add(chapter2);

bog1.Chapters = chapters;

bog1.Start();