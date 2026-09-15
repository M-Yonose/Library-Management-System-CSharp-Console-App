namespace LibraryManagementSystem
{
    public class Librarian : IBorrowable
    {
        private Book[] books = new Book[500];
        private LibraryMember[] members = new LibraryMember[1000];
        private BorrowRecord[] records = new BorrowRecord[5000];

        private int _bookCount = 0;
        private int _memberCount = 0;
        private int _recordCount = 0;

        public void AddBook(Book book)
        {
            if (_bookCount < books.Length)
            {
                books[_bookCount] = book;
                _bookCount++;
            }
            else
            {
                Console.WriteLine("Sorry, Book Storage Is Full!");
            }
        }
        public void AddBook(int id, string title, string author, int isbn)
        {
            Book book = new Book(id, title, author, isbn);

            AddBook(book);
        }
        public void RegisterMember(LibraryMember member)
        {
            if (_memberCount < members.Length)
            {
                members[_memberCount] = member;
                _memberCount++;
            }
            else
            {
                Console.WriteLine("Sorry, Member Limt Is fill Up!");
            }
        }

        public Book? FindBookById(int bookID)
        {
            for (int i = 0; i < _bookCount; i++)
            {
                if (books[i].Id == bookID)
                {
                    return books[i];
                }
            }
            return null;
        }

        public LibraryMember? FindMemberById(int memberID)
        {
            for (int i = 0; i < _memberCount; i++)
            {
                if (members[i].Id == memberID)
                {
                    return members[i];
                }
            }

            return null;
        }

        public void BorrowBook(Book book, LibraryMember member)
        {
            if (book.IsBorrowed)
            {
                Console.WriteLine("Sorry, The book is already borrowed!");
                return;
            }
            book.IsBorrowed = true;

            BorrowRecord record = new BorrowRecord(book, member);
            records[_recordCount] = record;
            _recordCount++;
            Console.WriteLine("The book is borrowed successfully!");
        }
        public void ReturnBook(Book book, LibraryMember member)
        {
            for (int i = 0; i < _recordCount; i++)
            {
                if (records[i].Book == book &&
                    records[i].Member == member &&
                    records[i].ReturnDate == null)
                {
                    records[i].ReturnDate = DateTime.Now;
                    book.IsBorrowed = false;

                    Console.WriteLine("Book returned successfully.");
                    return;
                }
            }
            Console.WriteLine("Borrow record not found.");
        }

        public void DisplayAvailabeBooks()
        {
            Console.WriteLine("\nAvailableBooks: ");
            
            for(int i = 0; i < _bookCount; i++)
            {
                if (!books[i].IsBorrowed)
                {
                    books[i].DisplayInfo();
                    Console.WriteLine();
                }
            }
        }

        public  double CalculateFine(Book book, LibraryMember member)
        {
            for(int i = 0; i < _recordCount; i++)
            {
                if (records[i].Book == book &&
                    records[i].Member == member &&
                    records[i].ReturnDate != null)
                {
                    int borrowedDays = (records[i].ReturnDate.Value - records[i].BorrowDate).Days;

                    int lateDays = borrowedDays - 7;

                    if (lateDays > 0)
                    {
                        FineCalculator calculator = new FineCalculator();

                        return calculator.CalculateFine(lateDays);
                    }

                    return 0;
                }
            }
            return 0;
        }
    }
}
