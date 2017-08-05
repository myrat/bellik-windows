using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bellik
{
    public partial class bellikForm : Form
    {
        public bellikForm()
        {
            InitializeComponent();
        }

        private void bellikForm_Load(object sender, EventArgs e)
        {
            Helper.ReadAll(bListNotes1);
        }

        private void bListNotes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bListNotes1.SelectedItem != null)
            {
                this.Text = ((Titles)bListNotes1.SelectedItem).Fname;
                textBox1.Text = Helper.TextRead(((Titles)bListNotes1.SelectedItem).Fname);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Helper.NewNote(textBox2.Text, textBox1.Text);
        }


    }
}
