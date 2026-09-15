namespace LibraryManagementSystem
{
    public interface IBorrowable
    {
        void BorrowBook(Book book, LibraryMember member);
        void ReturnBook(Book book, LibraryMember member);
    }
}
