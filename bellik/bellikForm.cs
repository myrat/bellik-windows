using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bellik
{
    public partial class bellikForm : Form
    {
        private string _Filename;
        public string Filename
        {
            get
            {
                return _Filename;
            }
            set
            {
                var oldvalue = value;
                _Filename = value;
                tContent.ReadOnly = true;
                if(value.Length > 0)
                    btEdSave.Enabled = true;
                else
                    btEdSave.Enabled = false;
                //OnFilenameChanged(oldvalue, value);
            }
        }

        private string title;


        private bool _edit_mode;
        public bool edit_mode
        {
            get { return _edit_mode; }
            set
            {
                if(value == true)
                {
                    btEdSave.Text = "Save";
                    tContent.ReadOnly = false;
                }
                    
                else
                    btEdSave.Text = "Edit";
            }
        }


        public bellikForm()
        {
            InitializeComponent();
        }

        private void bellikForm_Load(object sender, EventArgs e)
        {
            Helper.LoadXML(bListNotes1);
        }

        private void bListNotes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bListNotes1.SelectedItem != null)
            {
                this.Text = ((exListBoxItem)bListNotes1.SelectedItem).Title;
                tContent.Enabled = ((exListBoxItem)bListNotes1.SelectedItem).Synced;
                Filename = ((exListBoxItem)bListNotes1.SelectedItem).Fname;
                title = ((exListBoxItem)bListNotes1.SelectedItem).Title;
                edit_mode = false;
                if (((exListBoxItem)bListNotes1.SelectedItem).Synced)
                {
                    tContent.Text = Helper.TextRead(Filename);
                    tTitle.Text = title;
                }
                    
                else
                    tContent.Text = "Not synced...";
            }            
        }

        private void tContent_TextChanged(object sender, EventArgs e)
        {
            IsChanhed = true;
        }

        private void mnuImprt_Click(object sender, EventArgs e)
        {
            Helper.ReadAll(bListNotes1);
        }



        public string Content
        {
            get { return tContent.Text; }
            set { tContent.Text = value; }
        }
        private bool _IsChanhed;
        public bool IsChanhed
        {
            get
            {
                if (Filename == null && Content.Length <=0) return false;
                return _IsChanhed;
            }
            set
            {
                _IsChanhed = value;
            }
        }

        private bool _title_changed;
        public bool title_changed
        {
            get
            {
                if (Filename == null && tTitle.Text.Length<= 0) return false;
                return _title_changed;
            }
            set
            {
                _title_changed = value;
            }
        }

        private bool Save()
        {
            if (!IsChanhed) return true;

            if ((Filename == null) || new FileInfo(Filename).IsReadOnly)
            {
                //return SaveAs();
            }

            File.WriteAllText(Filename, Content);
            IsChanhed = false;
            return true;
        }

        private void btEdSave_Click(object sender, EventArgs e)
        {
            edit_mode = true;
        }

        private void tTitle_TextChanged(object sender, EventArgs e)
        {
            title_changed = true;
        }

        private bool EnsureWorkNotLost()
        {
            if (!title_changed && IsChanhed) return true;

            
            var Mes new MessageBox.Show("Hello");

            switch (DialogResult)
            {
                case DialogResult.Yes:
                    return Save();
                case DialogResult.No:
                    return true;
                case DialogResult.Cancel:
                    return false;
                default:
                    throw new Exception();
            }
        }
    }
}
