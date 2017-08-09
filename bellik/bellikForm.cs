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
                this.Text = ((exListBoxItem)bListNotes1.SelectedItem).Id.ToString();
                tContent.Text = Helper.TextRead(((exListBoxItem)bListNotes1.SelectedItem).Fname);
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Helper.NewNote(tTitle.Text, tContent.Text);
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Indexer.writeindex();
        }

        private void bellikForm_Paint(object sender, PaintEventArgs e)
        {
            //this.CreateGraphics().DrawRectangle(Pens.DarkGray, 0, 0, this.Width-1, this.Height-1);
        }


    }
}
