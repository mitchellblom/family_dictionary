using System;
using System.Linq;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Diana"},
                {"age", "24"}
            });

            myFamily.Add("sister-in-law", new Dictionary<string, string>(){ 
                {"name", "Carly"},
                {"age", "17"}
            });

            myFamily.Add("brother-in-law", new Dictionary<string, string>(){ 
                {"name", "Dominic"},
                {"age", "17"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){ 
                {"name", "Mikey"},
                {"age", "25"}
            });
            
            foreach (KeyValuePair<string, Dictionary<string, string>> sibling in myFamily) {
                Console.WriteLine($"{sibling.Value["name"]} is my {sibling.Key} and is {sibling.Value["age"]} years old.");
            }

        }
    }
}
