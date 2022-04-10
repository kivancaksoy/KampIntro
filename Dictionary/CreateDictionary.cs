using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class CreateDictionary
    {
        public void CreateDictionaryMethod()
        {
            // Create a dictionary with string key and Int16 value pair
            Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>();
            AuthorList.Add("Mahesh Chand", 35);
            AuthorList.Add("Mike Gold", 25);
            AuthorList.Add("Praveen Kumar", 29);
            AuthorList.Add("Raj Beniwal", 21);
            AuthorList.Add("Dinesh Beniwal", 84);
            // Read all data
            Console.WriteLine("Authors List");
            foreach (KeyValuePair<string, Int16> author in AuthorList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
            }
        }
    }
}
