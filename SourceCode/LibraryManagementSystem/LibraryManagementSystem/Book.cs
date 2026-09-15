namespace LibraryManagementSystem
{
    public class Book : LibraryItem
    {
        public int ISBN { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(int id, string title, string author, int isbn) : base (id, title)
        {
            ISBN = isbn;         
            Author = author;
            IsBorrowed = false;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Author : {Author}");
            Console.WriteLine($"ISBN : {ISBN}");
            Console.WriteLine($"Available : {!IsBorrowed}");

        }
    }
}
