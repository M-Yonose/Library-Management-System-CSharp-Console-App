namespace LibraryManagementSystem
{
    public class BorrowRecord
    {
        public Book Book { get; set; }
        public LibraryMember Member {  get; set; }
        public DateTime BorrowDate {  get; set; }
        public DateTime ? ReturnDate { get; set; }

        public BorrowRecord(Book book, LibraryMember member)
        {
            Book = book;
            Member = member;
            BorrowDate = DateTime.Now;
            ReturnDate = null;
        }
    }
}
