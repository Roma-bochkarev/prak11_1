using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_work
{
    public partial class student_work :Form
    {
        public student_work ()
        {
            InitializeComponent();
        }

        public class Student 
        {
            public string name;
            public double rost;
            public double eda;
            private double ves;
            public double ves_end;
            public double rost_end;
            public double GetEat(double vs)
            {
                ves = vs;
                return ves;
            }
            public double SetEat(double eda, double vs)
            {
                ves = vs + eda - 2800 / 1000;
                return ves;
            }
        }

        private void label1_Click (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.name = textBox1.Text;
            student1.rost = (double) (numericUpDown2.Value);
            student1.eda = (double) (numericUpDown3.Value);
            if (student1.eda >= 5 && student1.eda <= 10)
            {
                student1.ves_end = (double) student1.GetEat((double) numericUpDown1.Value) + ((student1.eda - 1.6) * 0.7);
                student1.rost_end = student1.rost - 1;
            }
            if (student1.eda > 10)
            {
                student1.ves_end = (double) student1.GetEat((double) numericUpDown1.Value) + ((student1.eda - 1.8) * 0.5);
                student1.rost_end = student1.rost - 2;
            }
            else
            {
                student1.ves_end = (double) student1.GetEat((double) numericUpDown1.Value) + ((student1.eda) * 0.7);
            }
            MessageBox.Show(string.Format("студент: {0}, еда: {1}\nРост:{2}\nрост после еды:{3}\nВес: {4}\nВес после еды: {5}", student1.name, student1.eda, student1.rost, student1.rost_end, student1.GetEat((double)numericUpDown1.Value), student1.ves_end));
        }
    }
}
