using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace pluralsight.json.net.m2.d3
{
    public class DynamicDemo
    {
        //JsonConvert uses reflection so Serialize and Deserialize are little slow.
        //JsonTextReader don't use reflection so faster.
        public static void ShowDynamic()
        {
            Console.Clear();
            Console.WriteLine("***  Dynamic and ExpandoObject Demo ***");

            Console.WriteLine("- Serialize");
            dynamic authorDynamic = new ExpandoObject();
            authorDynamic.FriendlyName = "Xavier Morera";
            authorDynamic.Courses = new List<string>() { "Solr", "dotTrace", "Jira" };
            authorDynamic.Happy = true;
            string jsonDynamicAuthor = JsonConvert.SerializeObject(authorDynamic, Formatting.Indented);
            Console.WriteLine(jsonDynamicAuthor);

            Console.WriteLine("- Deserialize");
            dynamic authorDeserialized = JsonConvert.DeserializeObject(jsonDynamicAuthor);
            Console.WriteLine("Friendly Name: " + authorDeserialized.FriendlyName);
        }
    }
}
