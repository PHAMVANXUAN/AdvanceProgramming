using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Model
{
    public class Book :Object
    {
        protected String ID;
        protected String Name;
        protected String Author;
        protected string YOP;
        protected String Type;

        public Book(string iD, string name, string author, string yOP, string type)
        {
            ID = iD;
            Name = name;
            Author = author;
            YOP = yOP;
            Type = type;
        }

        public Book() { }

        public String id
        {
            get { return ID; }
            set { ID = value; }
        }

        public String name
        {
            get { return Name; }
            set { Name = value; }
        }

        public String author
        {
            get { return Author; }
            set { Author = value; }
        }

        public string yop
        {
            get { return YOP; }
            set { YOP = value; }
        }

        public string TYPEB
        {
            get { return Type; }
            set { Type = value; }
        }

        public virtual void showBook()
        {
            Console.WriteLine("Book's ID: " + ID);
            Console.WriteLine("Book name: " + Name);
            Console.WriteLine("Author: " +Author);
            Console.WriteLine("Publish Years: " +YOP);
            Console.WriteLine("Book Type: " + Type);
        }
    }
}
