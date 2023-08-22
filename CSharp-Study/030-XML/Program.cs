using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _030_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a letter list to store all the letter info
            List<Letter> letterList = new List<Letter>(); 

            //XmlDocument is for analyzing xml file
            XmlDocument xmlDocument = new XmlDocument();
            
            //load the file we want to analyze
            //xmlDocument.Load("TextFile1.txt"); ////pass address
            // or we can load like this:
            xmlDocument.LoadXml(File.ReadAllText("TextFile1.txt")); //pass a string of file name

            XmlNode rootNode = xmlDocument.FirstChild; //get the root node (Letters)
            XmlNodeList letterNodeList = rootNode.ChildNodes; //get the list of all its child nodes

            foreach (XmlNode letterNode in letterNodeList) //the letter
            { 
                Letter letter = new Letter();
                XmlNodeList inLetterNodeList = letterNode.ChildNodes; //get the info (name, id ...etc) inside the letter node
                foreach (XmlNode inLetterNode in inLetterNodeList)
                {
                    if (inLetterNode.Name == "id")
                    {
                        int id = Int32.Parse(inLetterNode.InnerText);
                        letter.id = id;
                    }
                    else if (inLetterNode.Name == "name")
                    {
                        string name = inLetterNode.InnerText;
                        letter.name = name;
                        string from = inLetterNode.Attributes["from"].Value; //get the value stored in attribute
                        letter.from = from;
                    }
                    else if (inLetterNode.Name == "content")
                    { 
                        string content = inLetterNode.InnerText;
                        letter.content = content;
                    }
                }
                letterList.Add(letter);
            }
            foreach (Letter l in letterList)
            {
                Console.WriteLine(l.ToString());
            }

            Console.ReadKey();
        }
    }
}
