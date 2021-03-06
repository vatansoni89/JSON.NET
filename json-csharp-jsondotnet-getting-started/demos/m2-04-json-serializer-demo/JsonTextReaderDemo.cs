﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m2.d4
{
    public class JsonTextReaderDemo
    {
        //JsonConvert uses reflection so Serialize and Deserialize are little slow.
        //JsonTextReader don't use reflection so faster.
        public static void ShowJsonTextReader()
        {
            Console.Clear();
            Console.WriteLine("*** JsonTextReader Demo ***");
            string jsonText = @"
                {
                'name': 'Xavier Morera',
                'courses': [
                    'Solr',
                    'dotTrace'],
                'since': '2014-01-14T00:00:00',
                'happy': true,
                'issues': null,
                'car': {
                    'model': 'Land Rover Series III',
                    'year': 1976}
                }";

            JsonTextReader jsonReader = new JsonTextReader(new StringReader(jsonText));

            //JsonToken TokenType  : Almost every thing is a TokenType in json string, the beginning '{' is StartObject, then it goes gor key and values.

            while (jsonReader.Read())
            {
                if (jsonReader.Value != null)
                    Console.WriteLine("Token: {0}, Value: {1}", jsonReader.TokenType, jsonReader.Value);
                else
                    Console.WriteLine("Token: {0}", jsonReader.TokenType);
            }
        }
    }
}
