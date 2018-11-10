﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m8.d25
{
    public class Author
    {
        public string country;
        public int age;
        public string name { get; set; }
        public string[] courses { get; set; }
        public DateTime since { get; set; }
        public bool happy { get; set; }
        public object issues { get; set; }
        public Car car { get; set; }
        public List<Author> FavoriteAuthors { get; set; }
    }

    public class Car
    {
        public string model { get; set; }
        public int year { get; set; }
    }
}

