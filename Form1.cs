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

        public string[] Courses
        {
            get;set;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Easier to Doubleclick the Form to get to all the code, than
            //to do anything else!
        }

        private void TxtNum_TextChanged(object sender, EventArgs e)
        {
            short ix = 0;
            Debug.WriteLine(Int16.TryParse(TxtNum.Text, out ix));
            if (!Int16.TryParse(TxtNum.Text, out ix) && TxtNum.Text != "")
            {
                TxtNum.Text = "";
            }
        }

        private void CheckChange(object sender, EventArgs e)
        {
            TxtC101.Visible = ChkC101.Checked;
            TxtC102.Visible = ChkC102.Checked;

        }
    }
}
