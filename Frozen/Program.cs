using System;
using System.Collections.Generic;
using System.IO;

namespace OOPAndFiles
{
    class Program
    {

        class Frozen
        {
            string name;
            string gift;
          


            public Frozen(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
                
            }

            //getter for Movie
            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }
            

        }
        static void Main(string[] args)

        //Anna wants new earings for Christmas.

        {
            List<Frozen> myGift = new List<Frozen>();
            string[] moviesFromFile = GetDataFromFile();

            foreach (string line in moviesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Frozen newGift = new Frozen(tempArray[0], tempArray[1]);
                myGift.Add(newGift);

            }

            foreach (Frozen movieFromList in myGift)
            {
                Console.WriteLine($"{movieFromList.Name} wants {movieFromList.Gift} for Christmas.");
            }


        }
        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\jaagu\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }





    }
}

