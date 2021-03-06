﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m2.d3
{
    public class DifferentTypesDemo
    {
        //We can deserilized to Dictionary and AnonymousType.

        public static void ShowDifferentTypes()
        {
            Console.Clear();
            Console.WriteLine("*** Types Demo ***");
            string authorProperties = @"{
                                   'author': 'Xavier',
                                   'happy': true,
                                   'courses': 4
                                 }
                                ";

            Console.WriteLine("- var");
            var authorVar = JsonConvert.DeserializeObject(authorProperties);

            Console.WriteLine("- Dictionary");
            Dictionary<string, string> authorDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(authorProperties);

            Console.WriteLine("- Anonymous types");
            var authorAnonymousTypeDefinition = new //anonymous types also can be used for deserialization.
            {
                author = string.Empty,
                happy = false,
                courses = 0,
                anotherproperty = string.Empty
            };
            var authorAnonymous = JsonConvert.DeserializeAnonymousType(authorProperties, authorAnonymousTypeDefinition);
            Console.WriteLine(authorAnonymous.author);
        }
    }
}
