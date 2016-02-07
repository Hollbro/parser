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
    class HtmlToXml
    {
        public void RunParse()
        {
            string[] mas;
            using (StreamReader sr = new StreamReader(@"C:\Users\den\Desktop\PROG\bd1.txt"))
            {
                mas = sr.ReadToEnd().Split(new char[] { '\n' });
            }
            List<string> list = mas.ToList();
            foreach (var a in list)
            {
                WebRequest web = WebRequest.Create(a);
                WebResponse webres = web.GetResponse();
                using (Stream stream = webres.GetResponseStream())
                {
                    using (StreamReader read = new StreamReader(stream))
                    {
                        while (read.ReadLine() != null)
                        {
                            File.AppendAllText(@"C:\Users\den\Documents\GitHub\Parser\ProjXML.xml", read.ReadToEnd());
                        }
                    }
                }
            }
        }
    }
}
