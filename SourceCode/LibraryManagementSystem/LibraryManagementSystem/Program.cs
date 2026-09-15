using System;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main()
        {
            Librarian librarian = new Librarian();

            while (true)
            {
                Console.WriteLine("\n===== Library Management System =====");
                Console.WriteLine("1. Register Member");
                Console.WriteLine("2. Add Book");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. Display Available Books");
                Console.WriteLine("6. Display Borrowed Books");
                Console.WriteLine("7. Calculate Late Fine");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                // Choice 0: Exit
                if (choice == "0")
                {
                    break;
                }

                // Choice 1: Register Member
                if (choice == "1")
                {
                    Console.Write("Enter Member ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Enter Member Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    string phoneNo = Console.ReadLine();

                    LibraryMember member = new LibraryMember(id, name, phoneNo);

                    librarian.RegisterMember(member);
                }

                // Choice 2: Add Book
                if (choice == "2")
                {
                    Console.Write("Enter Book ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Enter Book Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter Author Name: ");
                    string author = Console.ReadLine();

                    Console.Write("Enter ISBN: ");
                    int isbn = int.Parse(Console.ReadLine());

                    librarian.AddBook(id, title, author, isbn);
                }

                // Choice 3: Borrow Book
                if (choice == "3")
                {
                    Console.Write("Enter Book ID: ");
                    int bookID = int.Parse(Console.ReadLine());

                    Console.Write("Enter Member ID: ");
                    int memberID = int.Parse(Console.ReadLine());

                    Book book = librarian.FindBookById(bookID);
                    LibraryMember member = librarian.FindMemberById(memberID);

                    if (book != null && member != null)
                    {
                        librarian.BorrowBook(book, member);
                    }
                    else
                    {
                        Console.WriteLine("Book or Member not found.");
                    }
                }

                // Choice 4: Return Book
                if (choice == "4")
                {
                    Console.Write("Enter Book ID: ");
                    int bookID = int.Parse(Console.ReadLine());

                    Console.Write("Enter Member ID: ");
                    int memberID = int.Parse(Console.ReadLine());

                    Book book = librarian.FindBookById(bookID);
                    LibraryMember member = librarian.FindMemberById(memberID);

                    if (book != null && member != null)
                    {
                        librarian.ReturnBook(book, member);
                    }
                    else
                    {
                        Console.WriteLine("Book or Member not found.");
                    }
                }

                // Choice 5: Display Available Books
                if (choice == "5")
                {
                    librarian.DisplayAvailableBooks();
                }

                // Choice 6: Display Borrowed Books
                if (choice == "6")
                {
                    librarian.DisplayBorrowedBooks();
                }

                // Choice 7: Calculate Late Fine
                if (choice == "7")
                {
                    Console.Write("Enter Book ID: ");
                    int bookID = int.Parse(Console.ReadLine());

                    Console.Write("Enter Member ID: ");
                    int memberID = int.Parse(Console.ReadLine());

                    Book book = librarian.FindBookById(bookID);
                    LibraryMember member = librarian.FindMemberById(memberID);

                    if (book != null && member != null)
                    {
                        double fine = librarian.CalculateLateFine(book, member);

                        Console.WriteLine($"Late Fine: {fine} Taka");
                    }
                    else
                    {
                        Console.WriteLine("Book or Member not found.");
                    }
                }
            }
        }
    }
}