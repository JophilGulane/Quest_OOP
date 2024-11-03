using System;/*

Problem: Library Management System
Create a simple library management system where users can borrow and return books. You’ll need to design a few classes to manage the library's books and its users.

Requirements:
Classes and Access Modifiers:

Book:

Private fields for Title, Author, and IsBorrowed.
Public method to display book details.
Protected method to check if the book is borrowed(returning a boolean).
Public methods to mark the book as borrowed or returned.
Library:

Private list of books.
Public methods to add books to the library, list all books, and show available books.
Public method for users to borrow or return books (if the book is available).
User:

Private fields for the user's Name and BorrowedBooks.
Public method to display the user's information.
Public method to borrow a book from the library, marking it as borrowed if available.
Protected method to check if a user has borrowed a particular book.
Functionality:

The Library class should manage the book inventory.
Users should be able to borrow books if they’re available and return them when finished.
You should have a main program that creates a library, adds some books, and allows a user to interact with it by borrowing or returning books.*/
namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Book
    {
        private string Title;
        private string Author;
        private bool isBorrowed;

        public void DisplayBookDetails()
        {

        }

        protected bool isBookBorrowed()
        {
            if (isBorrowed)
            {
                return true;
            }
            return false;
        }

        public void markBook()
        {
        }

        public Book(string Title, string Author)
        {
            this.Title = Title;
            this.Author = Author;
            isBorrowed = false;
        } 
    }

    public class Library
    {
        private List<Book> books = new List<Book>
        {
            new Book("Atomic Habit", "Jays")
        };
    }
}
