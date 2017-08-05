using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bellik
{
    
    class Helper
    {
        static string rootdir = AppDomain.CurrentDomain.BaseDirectory;
        static string notedir = Path.Combine(rootdir, "notes");
        public static void ReadAll(bListNotes list)
        {
            string[] files = Directory.GetFiles(notedir);
            string title;
            foreach(string file in files)
            {
                if(File.Exists(file))
                {
                    title = file.Substring(file.LastIndexOf("\\")+1);
                    list.Items.Add(new Titles { Title = title, Fname = file });
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
