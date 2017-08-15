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
        static string notedir = ".\\notes";//Path.Combine(rootdir, "notes");
        public string _title;
        private string _mod_date;

        string title
        {
            get { return _title; }
            set { _title = value; }
        }

        string mod_date
        {
            get { return _mod_date; }
            set { _mod_date = value; }
        }

        public static void ReadAll(bListNotes list)
        {
            XmlWriterSettings xmws = new XmlWriterSettings();
            xmws.Indent = true;
            string[] files = Directory.GetFiles(notedir);
            string title;
            string date;
            string mdate;
            int i = 0;

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
                    list.Items.Add(new exListBoxItem(i, title, file, date, true));
                    i++;
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

        public static void LoadXML(bListNotes list)
        {
            XmlReaderSettings xms = new XmlReaderSettings();

            string[] files = Directory.GetFiles(notedir);
            string title;
            string date;
            string mdate;
            string file;
            int i = 0;
            bool _sync;

            using (XmlReader xm = XmlReader.Create("index.xml", xms))
            {
                xm.MoveToContent();

                while (xm.Read())
                {
                    if (xm.Name == "n")
                    {
                        if (xm.IsStartElement())
                        {
                            title = xm.GetAttribute("t");
                            file = xm.GetAttribute("f");
                            date = xm.GetAttribute("d");
                            mdate = xm.GetAttribute("md");
                            _sync = File.Exists(file);
                            list.Items.Add(new exListBoxItem(i, title, file, date, _sync));
                            i++;
                        }
                    }

                }
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
