using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //CreateDictionary createDictionary = new CreateDictionary();
            //createDictionary.CreateDictionaryMethod();

            MyDictionary<string, int> myDictionaries = new MyDictionary<string, int>();

            myDictionaries.Add("kıvanç", 26);
            myDictionaries.Add("kvnc", 24);

            for (int i = 0; i < myDictionaries.Values.Length; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", myDictionaries.Keys[i], myDictionaries.Values[i]);
            }
        }        
    }
}
