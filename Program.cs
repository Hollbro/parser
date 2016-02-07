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
    class Program
    {
        static void Main(string[] args)
        {
            HtmlToXml proc1 = new HtmlToXml();
            ParseXml proc2 = new ParseXml();
            proc1.RunParse();
            proc2.RunXmlParser();
        }
    }
}
