using BookManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    internal class BookManage
    {
        private List<Book> BookManagement;
        Book Book = new Book();
        public BookManage()
        {
            BookManagement = new List<Book>();
        }

        public void AddBook()
        {
            Console.WriteLine("Input Book's ID: ");
            String id = Console.ReadLine();
            Console.WriteLine("Input Books Name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Input Book's Author");
            String author = Console.ReadLine();
            Console.WriteLine("Input Book's YOP");
            string yop = Console.ReadLine();
            Console.WriteLine("Choose Book Type");
            Console.WriteLine("1. Finance");
            Console.WriteLine("2. Cooking");
            Console.WriteLine("3. IT");

            String TYPE = null;
            bool TypeValid = false;
            while (!TypeValid)
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Finance finance = new Finance(id, name, author, yop, "Finance");
                        BookManagement.Add(finance);
                        break;
                    case 2:
                        Cooking cooking = new Cooking(id, name, author, yop, "Cooking");
                        BookManagement.Add(cooking);
                        break;
                    case 3:
                        IT it = new IT(id, name, author, yop, "IT");
                        BookManagement.Add(it);
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;

                }
            }
            Console.ReadKey();
        }


        public void ShowBook()
        {
            foreach (Book book in BookManagement)
            {
                Console.WriteLine("------Books List------");
                book.showBook();
                Console.WriteLine("----------------------");
            }
        }

        public void EditBook(string iD)
        {
            Book book = BookManagement.FirstOrDefault(bs => bs.id == iD);
            if (book == null)
            {
                Console.WriteLine("No Book found");
                return;
            }
            Console.WriteLine("Enter new Book Name");
            string newName = Console.ReadLine();
            if (!string.IsNullOrEmpty(newName))
            {
                book.name = newName;
            }

            Console.WriteLine("Enter new Book Author");
            string newAuth = Console.ReadLine();
            if (!string.IsNullOrEmpty(newName))
            {
                book.author = newAuth;
            }

            Console.WriteLine("Enter new Publish Years");
            string newYOP = Console.ReadLine();
            book.yop = newYOP;
            
            string BookType = null;

            Console.WriteLine("Enter new Category");
            Console.WriteLine("Select the book's category number: ");
            Console.WriteLine("1. Finance");
            Console.WriteLine("2. Cooking");
            Console.WriteLine("3. IT");

            bool InputType = false;
            while (!InputType)
            {
                int choices = int.Parse(Console.ReadLine());

                switch (choices)
                {
                    case 1:
                        book.TYPEB = "Finance";
                        Console.WriteLine("Updated!");
                        break;
                    case 2:
                        book.TYPEB = "Cooking";
                        Console.WriteLine("Updated!");
                        break;
                    case 3:
                        book.TYPEB = "IT";
                        Console.WriteLine("Updated!");
                        break;
                    case 4:
                        Console.WriteLine("Invalid Type!");
                        break;
                }
            }

        }
        public void DeleteBook(string iD)
        {
            Book book_delete = BookManagement.Find(bs => bs.id == iD);

            if (book_delete != null)
            {
                BookManagement.Remove(book_delete);
                Console.WriteLine("Deleted Book's ID " + iD + "?");
            }else
            Console.WriteLine("Book's ID " + iD +  " doesn't exist !!");
        }

        public void searchBook(string ID)
        {
            bool resultFound = false;
            foreach (Book book in BookManagement) 
            {
                if (book.id == ID) 
                {
                    Console.WriteLine("Books Found...");
                    book.showBook();
                    resultFound = true;
                    break;
                }
            }
            if (!resultFound) 
            {
                Console.WriteLine("Book's ID" + ID + " invalid.");
            }
        }


    }
}
