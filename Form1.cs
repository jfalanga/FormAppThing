using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAppThing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private string SelectedMajor
        {
            get
            {
                if (RadPhil.Checked)
                {
                    return ("Philosophy");
                }
                else if (RadPrg.Checked)
                {
                    return "Programming";
                }
                else if (RadWeb.Checked)
                {
                    return "Web Design";
                } else
                {
                    return "WHAAAT";
                }
            }
        }
        private Student BuildStudent()
        {
            Student s = new Student();
            s.FirstName = Txt1stName.Text;
            s.LastName = TxtLstName.Text;
            s.StudentNumber = TxtNum.Text;
            return s;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
