using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _031_XML_MorePractice //-p72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Letter> letters = new List <Letter> ();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("LetterInfo.txt");

            //XmlNode lettersNode = xmlDoc.FirstChild;
            //XmlNode letterListNode = lettersNode.FirstChild;
            //In one sentence:
            XmlNode letterListNode = xmlDoc.FirstChild.FirstChild;
            XmlNodeList letterList = letterListNode.ChildNodes;
            foreach (XmlNode letterNode in letterList)
            { 
                Letter letter = new Letter();
                XmlElement eleId = letterNode["id"];
                XmlElement eleName = letterNode["name"];
                XmlAttributeCollection nameAttribute = letterNode["name"].Attributes;
                XmlElement eleContent = letterNode["content"];

                letter.id=Int32.Parse(eleId.InnerText);
                letter.name = eleName.InnerText;
                letter.from = nameAttribute["from"].Value;
                letter.favfood = nameAttribute["favfood"].Value;
                letter.content = eleContent.InnerText;
                letters.Add (letter);
            }
            foreach (Letter l in letters)
            {
                Console.WriteLine(l.ToString());
            }

        }
    }
}
