﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    abstract public class LibraryItem
    {
        public string title;
        public Author author;
        bool onLoan = false;

        public LibraryItem(string title)
        {
            this.title = title;
        }

        public LibraryItem(Author author, string title)
        {
            this.title = title;
            this.author = author;
        }

        public bool isOnLoan()
        {
            return onLoan;
        }

        public virtual string checkIn()
        {
            if (!this.isOnLoan())
            {
                return "item is not currently on loan";
            }

            this.onLoan = false;

            return "item has been checked in";
        }

        public virtual string checkOut()
        {
            if (this.isOnLoan())
            {
                return "item is currently on loan";
            }

            this.onLoan = true;

            return "item has been checked out";
        }
    }
}