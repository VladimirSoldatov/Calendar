using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form2 : Form
    {
        public Person person { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        public DialogResult ShowDialog(string str)
        {
            label1.Text = str;
            return ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person = new Person();
            person.LastName = textBox1.Text;
            person.FirstName = textBox2.Text;
            person.MiddleName = textBox3.Text;
            person.Birthdate = DateOnly.FromDateTime(dateTimePicker1.Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
