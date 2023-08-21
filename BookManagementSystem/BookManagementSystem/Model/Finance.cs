﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Model
{
    internal class Finance : Book
    {
        public Finance(string iD, string name, string author, string yOP, string type) : base(iD, name, author, yOP, type)
        {
            this.Type = "Finance";
        }
    }
}
