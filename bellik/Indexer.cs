using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace bellik
{
    class Indexer
    {
        public static void readindex()
        {
            
        }

        public static void writeindex(string title, string name, string date, string mdate)
        {
            XmlWriterSettings xmws = new XmlWriterSettings();
            xmws.Indent = true;
            FileStream xw = new FileStream("index.xml", FileMode.Append);
            using (XmlWriter write = XmlWriter.Create(xw, xmws))
            {
                write.WriteStartElement("note");
                write.WriteStartAttribute("t");
                write.WriteString(title);
                write.WriteStartAttribute("n");
                write.WriteString(name);
                write.WriteStartAttribute("d");
                write.WriteString(date);
                write.WriteStartAttribute("md");
                write.WriteString(mdate);
                write.WriteEndElement();
                //xw.Close();
            }
        }
    }
}
