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
        public string[] tCourses;
        public Form1()
        {
            InitializeComponent();
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

        //method for making the Student class variable have, & deal w/ in it's own way
        private Student BuildStudent()
        {
            Student s = new Student();
            s.FirstName = Txt1stName.Text;
            s.LastName = TxtLstName.Text;
            s.StudentNumber = TxtNum.Text;
            s.Courses = tCourses;
            s.Major = SelectedMajor;
            List<int> scoring=new List<int>();
            bool yOrN;
            int ix = ScoreInts(TxtC101, out yOrN);
            if (yOrN) { scoring.Add(ix); }
            ix = ScoreInts(TxtC102, out yOrN);
            if (yOrN) { scoring.Add(ix); }
            ix = ScoreInts(TxtP101, out yOrN);
            if (yOrN) { scoring.Add(ix); }
            ix = ScoreInts(TxtP110, out yOrN);
            if (yOrN) { scoring.Add(ix); }

            return s;
        }

        //Basically a method for dealing with the score textboxes & their texts
        private int ScoreInts(TextBox txt, out bool isVisible)
        {
            if (txt.Visible)
            {
                int ix;
                if (Int32.TryParse(txt.Text,out ix))
                {
                    isVisible = true;
                    return ix;
                } else
                {
                    isVisible = true;
                    return 0;
                }
            }
            else
            {
                isVisible = false;
                return -200;
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student cPlus = BuildStudent();
            string bean = "The Student #" + cPlus.StudentNumber + "'s name is " + cPlus.FirstName + ' ' + cPlus.LastName+".";
            bean = bean + " THeir Major is " + cPlus.Major + "; and they are taking the following courses: ";
            int ix = 0;
            foreach(string course in cPlus.Courses)
            {
                ix++;
                bean += course;
                if (ix!=cPlus.Courses.Length)
                {
                    bean += ", and ";
                }
            }
            bean += ". ";

            bean += "Their Avegage score, in this is " + cPlus.Average;
            TxtDisplay.Text = bean;
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            //Easier to Doubleclick the Form to get to all the code, than
            //to do anything else!
        }

        private void TxtNum_TextChanged(object sender, EventArgs e)
        {
            if (!TextIsNumeral(TxtNum.Text))
            {
                TxtNum.Text = "";
            }
        }

        //This seemed an easier way of dealing w/ the considerable number of textboxes that needed to be purely numerical!
        private bool TextIsNumeral(string text)
        {
            int ix = 0;
            Debug.WriteLine(Int32.TryParse(TxtNum.Text, out ix));
            if (!Int32.TryParse(TxtNum.Text, out ix) && TxtNum.Text != "")
            {
                return false;
            } else
            {
                return true;
            }
        }

        //It seems MUCH more elegant to have ALL the checkboxes raise the same method!
        private void CheckChange(object sender, EventArgs e)
        {
            List<string> tCourses = new List<string>();
            TxtC101.Visible = ChkC101.Checked;
            if (TxtC101.Visible) 
            { 
                tCourses.Add("CSI 101"); 
            }

            TxtC102.Visible = ChkC102.Checked;
            if (TxtC102.Visible)
            {
                tCourses.Add("CSI 102");
            }
            TxtP101.Visible = ChkP101.Checked;
            if (TxtP101.Visible)
            {
                tCourses.Add("Phil 101");
            }
            TxtP110.Visible = ChkP110.Checked;
            if (TxtP110.Visible)
            {
                tCourses.Add("Phil 110");
            }
            if (ChkC101.Checked || ChkC102.Checked|| ChkP101.Checked|| ChkP110.Checked)
            {
                LblScores.Visible = true;
            } else
            {
                LblScores.Visible = false;
            }
            this.tCourses = tCourses.ToArray();
        }

        private void TxtC101_Changed(object sender, EventArgs e)
        {
            if (!TextIsNumeral(TxtC101.Text))
            {
                TxtC101.Text = "";
            }
        }

        private void TxtC102_Changed(object sender, EventArgs e)
        {
            if (!TextIsNumeral(TxtC102.Text))
            {
                TxtC102.Text = "";
            }
        }

        private void TxtP101_Changed(object sender, EventArgs e)
        {
            if (!TextIsNumeral(TxtP101.Text))
            {
                TxtP101.Text = "";
            }
        }

        private void TxtP110_Changed(object sender, EventArgs e)
        {
            if (!TextIsNumeral(TxtP110.Text))
            {
                TxtP110.Text = "";
            }
        }
    }
}
