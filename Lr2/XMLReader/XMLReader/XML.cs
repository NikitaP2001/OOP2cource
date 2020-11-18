using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Diagnostics;
using System.Xml.Linq;

class Scientist
{
    public string Name { get; private set; }
    public string Facultet { get; private set; }
    public string Cafedra { get; private set; }
    public string Degree { get; private set; }
    public string Status { get; private set; }

    public Scientist(string name, string facultet, string cafedra, 
        string degree, string status)
    {
        Name = name;
        Facultet = facultet;
        Cafedra = cafedra;
        Degree = degree;
        Status = status;
    }

    public override string ToString()
    {
        return String.Format("{0}, {1}, {2}, {3}, {4}", 
            Name, Facultet, Cafedra, Degree, Status);
    }

}

namespace XMLReader
{
    class Doc
    {
        List<Scientist> scien = new List<Scientist>();
        string xml_link;
        public string DocToString()
        {
            string temp = "";
            foreach (Scientist u in scien)
            {
                temp = temp + u + System.Environment.NewLine;
            }
            return temp;
        }
        public void filter(string fl, string key)
        {
            List<Scientist> temp;
            temp = scien;
            for (int i = scien.Count - 1; i >= 0; i--)
            {
                switch (key)
                {
                    case "Name":
                        if (scien[i].Name != fl)
                        {
                            scien.RemoveAt(i);
                        }
                        break;
                    case "Facultet":
                        if (scien[i].Facultet != fl)
                        {
                            scien.RemoveAt(i);
                        }
                        break;
                    case "Cafedra":
                        if (scien[i].Cafedra != fl)
                        {
                            scien.RemoveAt(i);
                        }
                        break;
                    case "Degree":
                        if (scien[i].Degree != fl)
                        {
                            scien.RemoveAt(i);
                        }
                        break;
                    case "Status":
                        if (scien[i].Status != fl)
                        {
                            scien.RemoveAt(i);

                        }
                        break;
                }
            }
            scien = temp;
        }

        public void reset()
        {
            filter("ae8ty47y582j8", "Name");
        }

        public void Linq()
        {
            XDocument xdoc = XDocument.Load(xml_link);
            foreach (XElement scienElement in xdoc.Element("catalog").Elements("scientist"))
            {
                XElement nameElement = scienElement.Element("Name");
                XElement facultetElement = scienElement.Element("Facultet");
                XElement cafedraElement = scienElement.Element("Cafedra");
                XElement degreeElement = scienElement.Element("Degree");
                XElement statusElement = scienElement.Element("Status");
                if (nameElement !=null && facultetElement != null &&
                    cafedraElement != null && degreeElement != null && statusElement != null)
                {
                    scien.Add(new Scientist(nameElement.Value , facultetElement.Value, cafedraElement.Value,
                        degreeElement.Value, statusElement.Value));
                }
                Console.WriteLine();
            }
        }
        public void Dom()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\1\LR\Cource2OOP\Lr2\source.xml");
            XmlNode root = doc.DocumentElement;
            string name = "";
            string fac = "";
            string caf = "";
            string deg = "";
            string stat = "";
            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    for (int j = 0; j < root.ChildNodes[i].ChildNodes.Count; j++)
                    {
                        switch (root.ChildNodes[i].ChildNodes[j].Name)
                        {
                            case "Name":
                                name = root.ChildNodes[i].ChildNodes[j].InnerText;
                                break;
                            case "Facultet":
                                fac = root.ChildNodes[i].ChildNodes[j].InnerText;
                                break;
                            case "Cafedra":
                                caf = root.ChildNodes[i].ChildNodes[j].InnerText;
                                break;
                            case "Degree":
                                deg = root.ChildNodes[i].ChildNodes[j].InnerText;
                                break;
                            case "Status":
                                stat = root.ChildNodes[i].ChildNodes[j].InnerText;
                                break;
                        }
                    }
                    scien.Add(new Scientist(name, fac, caf, deg, stat));
                }
            }

        }
        public void SaxTr()
        {
            using (XmlReader xr = XmlReader.Create(xml_link))
            {
                string name = "";
                string element = "";
                string fac = "";
                string caf = "";
                string deg = "";
                string stat = "";
                while (xr.Read())
                {
                    // reads the element
                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        element = xr.Name; // the name of the current element
                    }
                    // reads the element value
                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        switch (element)
                        {
                            case "Name":
                                name = xr.Value;
                                break;
                            case "Facultet":
                                fac= xr.Value;
                                break;
                            case "Cafedra": 
                                caf = xr.Value;
                                break;
                            case "Degree":
                                deg = xr.Value;
                                break;
                            case "Status":
                                stat = xr.Value;
                                break;
                        }
                    }
                    // reads the closing element
                    else if ((xr.NodeType == XmlNodeType.EndElement) && (xr.Name == "scientist"))
                        scien.Add(new Scientist(name, fac, caf, deg, stat));
                }
            }
        }

        public string HtmlString()
        {
            string temp = "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>" +
                           "<?xml-stylesheet type = \"text/xsl\" href = \"style.xsl\"?>" +
                           "<catalog>";
            foreach (Scientist u in scien)
            {
                temp = temp + "<scientist>";
                temp = temp + "<Name>" + u.Name + "</Name>";
                temp = temp + "<Facultet>" + u.Name + "</Facultet>";
                temp = temp + "<Cafedra>" + u.Name + "</Cafedra>";
                temp = temp + "<Degree>" + u.Name + "</Degree>";
                temp = temp + "<Status>" + u.Name + "</Status>";
                temp = temp + "</scientist>";
            }
            temp = temp + "</catalog>";
            return temp;
        }
        public string TransformXMLToHTML()
        {
            XslCompiledTransform transform = new XslCompiledTransform();
            using (XmlReader reader = XmlReader.Create(@"C:\Users\1\LR\Cource2OOP\Lr2\style.xsl"))
            {
                transform.Load(reader);
            }
            StringWriter results = new StringWriter();
            using (XmlReader reader = XmlReader.Create(new StringReader(HtmlString())))
            {
                transform.Transform(reader, null, results);
            }
            return results.ToString();
        }

        public Doc()
        {
            xml_link = @"C:\Users\1\LR\Cource2OOP\Lr2\source.xml";
        }
    }
}

