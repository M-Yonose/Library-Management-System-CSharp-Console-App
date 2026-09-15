namespace LibraryManagementSystem
{
    public abstract class LibraryItem
    {
        public int Id { get; private set; }
        public string Title { get; set; }

        public LibraryItem(int id, string title)
        {
            Id = id;
            Title = title;
        }
        public abstract void DisplayInfo();
    }
}
