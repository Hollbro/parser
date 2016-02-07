using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Xml;


namespace Parser
{
    class ParseXml
    {
        public void RunXmlParser()
        {
            string path = @"C:\Users\den\Documents\GitHub\Parser\ProjXML.xml";
            XDocument doc = XDocument.Load(path);
            XElement root = new XElement("root",doc);
            root.Save(path);
            var qwerty = from c in doc.Root.Descendants("root")
                         select c.Element("host").Value + "\n" +
                         c.Element("din").Value + "\n" +
                         c.Element("hin").Value;
            foreach (string sit in qwerty)
            {
                using (StreamWriter write = new StreamWriter(@"C:\Users\den\Documents\GitHub\Parser\newXML.xml"))
                {
                    File.WriteAllText(@"C:\Users\den\Documents\GitHub\Parser\newXML.xml", sit);
                }
            }
        }
    }
}
