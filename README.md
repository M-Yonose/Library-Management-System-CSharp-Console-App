# Library Management Console App with C#

A simple **C#/.NET console-based Library Management System** developed to practice and demonstrate core Object-Oriented Programming (OOP) concepts through a functional library management application.

## Overview

This project simulates a basic library system where a librarian can manage books and library members, handle book borrowing and returning, and calculate late fines.

The project was developed as a practical exercise to strengthen understanding of **C# programming, OOP principles, interfaces, inheritance, abstraction, polymorphism, method overloading, and array-based data management**.

## Features

* Register library members
* Add books to the library
* Borrow books
* Return books
* Display available books
* Display borrowed books
* Calculate late fines
* Search for books by ID
* Search for members by ID
* Track borrowing and returning dates

## Technologies Used

* **C#**
* **.NET**
* **Visual Studio**
* Console Application

## OOP Concepts Demonstrated

This project demonstrates several fundamental Object-Oriented Programming concepts:

### Classes and Objects

The application uses classes such as `Book`, `LibraryMember`, `BorrowRecord`, `FineCalculator`, and `Librarian` to represent different parts of the library system.

### Encapsulation

Properties are used to control and organize the data belonging to each object.

### Inheritance

The project uses inheritance to create specialized classes from base classes:

```text
LibraryItem
    ↓
   Book

Person
   ↓
LibraryMember
```

### Abstraction

Abstract classes are used to define common structures and behavior:

* `LibraryItem`
* `Person`

### Interfaces

Interfaces define required behaviors:

* `IBorrowable`
* `IFineCalculator`

### Polymorphism

Method overriding is demonstrated through `DisplayInfo()` implementations in derived classes.

### Method Overloading

The `AddBook()` method has multiple versions that allow books to be added in different ways.

### Constructors

Constructors are used to initialize objects with their required information.

## Project Structure

```text
LibraryManagementConsoleAppWithCSharp/
│
├── LibraryItem.cs
├── Book.cs
├── Person.cs
├── LibraryMember.cs
├── IBorrowable.cs
├── IFineCalculator.cs
├── BorrowRecord.cs
├── FineCalculator.cs
├── Librarian.cs
└── Program.cs
```

### Main Classes

| Class / Interface | Purpose                                          |
| ----------------- | ------------------------------------------------ |
| `LibraryItem`     | Abstract base class for library items            |
| `Book`            | Represents a book in the library                 |
| `Person`          | Abstract base class for people                   |
| `LibraryMember`   | Represents a registered library member           |
| `IBorrowable`     | Defines borrowing and returning behavior         |
| `IFineCalculator` | Defines fine calculation behavior                |
| `BorrowRecord`    | Stores borrowing information                     |
| `FineCalculator`  | Calculates late fines                            |
| `Librarian`       | Manages books, members, and borrowing operations |
| `Program`         | Entry point and console menu                     |

## How the System Works

The application starts from `Program.cs`, where the user interacts with the console menu.

The `Librarian` class handles the main library operations and manages the arrays containing books, members, and borrowing records.

### Basic Flow

```text
User
 ↓
Program.cs
 ↓
Librarian
 ↓
Books / Members / Borrow Records
```

For borrowing a book:

```text
Enter Book ID
       ↓
Find Book
       ↓
Enter Member ID
       ↓
Find Member
       ↓
Borrow Book
       ↓
Create Borrow Record
       ↓
Mark Book as Borrowed
```

## Late Fine

The current implementation uses a **7-day borrowing period** and calculates a fine of **10 Taka per late day**.

For example:

```text
Late Days = 5
Fine = 5 × 10
Fine = 50 Taka
```

These values are implementation choices for the current project and can be changed later.

## How to Run

### Using Visual Studio

1. Clone or download the repository.
2. Open the solution in **Visual Studio**.
3. Open the project.
4. Build the solution.
5. Run the application.
6. Use the console menu to interact with the system.

### Console Menu

```text
===== Library Management System =====

1. Register Member
2. Add Book
3. Borrow Book
4. Return Book
5. Display Available Books
6. Display Borrowed Books
7. Calculate Late Fine
0. Exit
```

## Current Implementation

The current version uses **arrays** for storing books, members, and borrowing records.

The project intentionally keeps the implementation simple and focuses on understanding fundamental C# and OOP concepts.

## Future Improvements

Possible improvements for future versions include:

* Replace arrays with generic collections such as `List<T>`
* Use more advanced Generics
* Add LINQ for searching and filtering
* Improve input validation and exception handling
* Add data persistence using files or a database
* Introduce a service-based architecture
* Add unit testing
* Improve the console user experience
* Explore ASP.NET Core for a web-based version

## Learning Goals

This project was created as a practical way to improve my understanding of:

* C# fundamentals
* Object-Oriented Programming
* Class design
* Inheritance
* Abstraction
* Interfaces
* Polymorphism
* Method overloading
* Method overriding
* Constructors
* Properties
* Arrays
* Basic application structure

## Author

**Mohammed Yonose**

Computer Science and Engineering Graduate
Interested in **C#, .NET, ASP.NET Core, Backend Development, and Software Engineering**.

## License

This project is intended for educational and portfolio purposes.
