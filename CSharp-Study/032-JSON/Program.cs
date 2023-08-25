using LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Letter> letters = new List<Letter>();
            //use litjson >> 2 ways -p75
            //1. download litjson.dll and add to References
            //2. Manage NuGet package, and add litjson

            //Use jsonmapper to analyze a json file
            //jsondata can be an object or an array (here it's an array)
            //JsonData jsonData = JsonMapper.ToObject(File.ReadAllText("TextFile1.txt"));

            //foreach (JsonData letter in jsonData)
            //{
            //    Letter letterEle = new Letter();
            //    JsonData idValue = letter["id"];
            //    JsonData nameValue = letter["name"];
            //    JsonData messageValue = letter["message"];

            //    int id = Int32.Parse(idValue.ToString());
            //    string name = nameValue.ToString();
            //    string message = messageValue.ToString();

            //    //Console.WriteLine("ID: " + id + ", Name: " + name + ", message: " + message);
            //    letterEle.id = id;
            //    letterEle.name = name;
            //    letterEle.message = message;

            //    letters.Add(letterEle);
            //}

            //foreach (Letter l in letters)
            //{
            //    Console.WriteLine(l.ToString());
            //}

            //use type to analyze the json. inside <> is what is in the json file
            //the key name in json and the var in class should be same
            //Letter[] letters = JsonMapper.ToObject<Letter[]>(File.ReadAllText("TextFile1.txt"));

            //foreach (Letter l in letters)
            //{
            //    Console.WriteLine(l);
            //}


            //List<Letter> letters = JsonMapper.ToObject<List<Letter>>(File.ReadAllText("TextFile1.txt"));

            //foreach (Letter l in letters)
            //{
            //    Console.WriteLine(l);
            //}

            //PostOffice postOffice = JsonMapper.ToObject<PostOffice>(File.ReadAllText("TextFile2.txt"));
            //Console.WriteLine(postOffice);
            //foreach (var temp in postOffice.Task)
            //{ 
            //    Console.WriteLine(temp);
            //}

            //PostOffice postOffice = new PostOffice(); // -p77
            //postOffice.Name = "Calagary";
            //postOffice.Country = "Alberta";
            //postOffice.SeriesNumber = 769;
            //string j = JsonMapper.ToJson(postOffice);
            //Console.WriteLine(j);


            Console.ReadKey();
        }
    }
}
