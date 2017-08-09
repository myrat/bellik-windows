using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace bellik
{
    
    class Helper
    {
        static string rootdir = AppDomain.CurrentDomain.BaseDirectory;
        static string notedir = Path.Combine(rootdir, "notes");
        public static void ReadAll(bListNotes list)
        {
            XmlWriterSettings xmws = new XmlWriterSettings();
            xmws.Indent = true;
            string[] files = Directory.GetFiles(notedir);
            string title;
            string date;
            string mdate;

            using (XmlWriter xw = XmlWriter.Create("index.xml", xmws))
            {
                xw.WriteStartDocument();
                xw.WriteStartElement("notes");

            foreach(string file in files)
            {
                if(File.Exists(file))
                {
                    title = file.Substring(file.LastIndexOf("\\")+1);
                    date = File.GetCreationTime(file).ToString("ddMMyy");
                    mdate = File.GetLastWriteTime(file).ToString("ddMMyy");
                    list.Items.Add(new exListBoxItem(1, title, file, date, true));

                    xw.WriteStartElement("n");

                    xw.WriteAttributeString("t", title);
                    xw.WriteAttributeString("f", file);
                    xw.WriteAttributeString("d", date);
                    xw.WriteAttributeString("md", mdate);
                    xw.WriteEndElement();
                }
            }

            xw.WriteEndElement();
            xw.WriteEndDocument();
            xw.Close();
            }
        }


        public static string TextRead(string file)
        {
            string content;
            if (File.Exists(file))
            {
                content = File.ReadAllText(file);
                return content;
            }
            else
                return content = file;            
        }

        public static void NewNote(string title, string content)
        {
            title = title.Replace(" ", "_");
            if(!(File.Exists(notedir + "\\" + title + ".txt")))
            {
                File.WriteAllText(notedir + "\\" + title + ".txt", content);
            }
        }
    }
}
