using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Model
{
    internal class Cooking : Book
    {
        public Cooking(string iD, string name, string author, string yOP, string type) : base(iD, name, author, yOP, type)
        {
            this.Type = "Cooking";
        }
    }
}
