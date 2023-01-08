using AngleSharp.Browser.Dom;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using TagTool.Models;

namespace TagTool.Services
{
    public class XmlHandler
    {
        public static void ReadXmlFile(string filepath)
        {
            XmlTextReader reader = new XmlTextReader(filepath);
            while(reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Debug.Write("<" + reader.Name);
                        while (reader.MoveToNextAttribute())
                        {
                            Debug.Write(" " + reader.Name + " = " + reader.Value);
                        }
                        Debug.Write(">");
                        break;
                    case XmlNodeType.Text:
                        Debug.Write(reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Debug.Write("</" + reader.Name);
                        Debug.Write(">");
                        Debug.WriteLine("");
                        break;
                }
            }
            LoadFb(filepath);
        }

        private static FunctionBlock LoadFb(string filepath)
        {
            FunctionBlock functionBlock = new FunctionBlock();

            XPathDocument doc = new XPathDocument(filepath);

            XPathNavigator nav = doc.CreateNavigator();

            string strExpression = "library/functionblock";

            XPathNodeIterator nodes = nav.Select(strExpression);

            while (nodes.MoveNext())
            {
                XPathNavigator nav2 = nodes.Current.Clone();
                nav2.Select("/library/functionblock/alarm");
            }

            return functionBlock;
        }

    }
}
