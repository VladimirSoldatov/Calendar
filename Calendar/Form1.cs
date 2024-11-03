using System.ComponentModel;
using System.Linq.Expressions;
using System.Security.Cryptography.Pkcs;
using static System.Windows.Forms.DataFormats;

namespace Calendar
{
   
    public partial class Form1 : Form
    {
        AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
        List<Person> emploees = new List<Person>();
        MenuStrip menuStripRussian;
        MenuStrip menuStripEnglish;
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            toolTip1.SetToolTip(button4, "Test Message");
            timer1.Enabled = true;
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 255;
            trackBar2.Minimum = 0;
            trackBar2.Maximum = 255;
            trackBar3.Minimum = 0;
            trackBar3.Maximum = 255;

        
            menuStripRussian = menuStrip1;
            menuStripEnglish = menuStripRussian;
            menuStripEnglish.Visible = false;
            button1.Text = "English";
            menuStripEnglish.Items[0].Text = "File";
            menuStripEnglish.Items[1].Text = "Style";
            menuStripEnglish.Items[2].Text = "Parent";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            dateTimePicker1.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                String record = String.Empty;
                record += $"{label2.Text}: {textBox1.Text}\n";
                record += $"{label3.Text}: {textBox2.Text}\n";
                record += $"{label4.Text}: {textBox3.Text}\n";
                record += $"Дата рождения: {dateTimePicker1.Value.ToShortDateString()}\n";
                string fileName = String.Empty;
                if (File.Exists($"{textBox1.Text}.txt"))
                {
                    MessageBox.Show("Такой файл существует");
                    saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
                    saveFileDialog1.Filter = "txt файлы (*.txt)|";
                    DialogResult result = saveFileDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        fileName = saveFileDialog1.FileName.Contains(".txt") ? saveFileDialog1.FileName : saveFileDialog1.FileName + ".txt";
                    }
                    else
                    {
                        MessageBox.Show("Имя файла не введено");
                        return;
                    }

                }
                else
                {
                    fileName = $"{textBox1.Text}.txt";
                }
                using (StreamWriter sw = new StreamWriter($"{fileName}"))
                {
                    sw.WriteLine(record);
                }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            foreach (var name in directoryInfo.EnumerateFiles("*.txt"))
            {
                stringCollection.Add(name.Name[..(name.Name.IndexOf(".txt"))]);
            }
            textBox1.AutoCompleteCustomSource = stringCollection;
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (var name in directoryInfo.EnumerateFiles("*.txt"))
            {
                Person person = new Person();
                using (StreamReader sr = new StreamReader(name.Name))
                {

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line == String.Empty)
                            continue;



                        string head = line[..(line.IndexOf(":"))];
                        string tail = line[(line.IndexOf(":") + 1)..].Trim();
                        switch (head)
                        {
                            case "Фамилия":
                                person.LastName = tail;
                                break;
                            case "Имя":
                                person.FirstName = tail;
                                break;
                            case "Отчество":
                                person.MiddleName = tail;
                                break;
                            case "Дата рождения":
                                if (!String.IsNullOrEmpty(tail))
                                    person.Birthdate = DateOnly.Parse(tail);
                                else
                                    person.Birthdate = DateOnly.Parse("1970-01-01");
                                break;
                            default:
                                break;
                        }

                    }

                }
                emploees.Add(person);
            }
            foreach (Person item in emploees)
            {
                listBox1.Items.Add($"{item.Id} {item.LastName} {item.FirstName}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = $"{(sender as ListBox).SelectedItem}";
            int id = int.Parse(item[..item.IndexOf(" ")]);
            Person person = emploees.Where(p => p.Id == id).FirstOrDefault();
            textBox1.Text = person.LastName;
            textBox2.Text = person.FirstName;
            textBox3.Text = person.MiddleName;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Visible = false;
            textBox4.Text = person.Birthdate.ToShortDateString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"{(sender as ComboBox).SelectedItem}");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // проверяет, чтобы строка не была пустой
            if (!String.IsNullOrEmpty(this.textBox5.Text))
            {
                // проверяет, чтобы значения были уникальными
                if (!this.checkedListBox1.Items.Contains(this.textBox5.Text))
                    this.checkedListBox1.Items.Add(this.textBox5.Text);
                else
                    MessageBox.Show("CheckedListBox already contains this item");
            }
            else
                MessageBox.Show("Empty string");


        }

        private void button5_Click(object sender, EventArgs e)
        {
            progressBar1.Increment(Convert.ToInt32(numericUpDown1.Value));
            label1.Text = $"Значение: {progressBar1.Value}";
            numericUpDown1.Value = 0;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string str;
            str = DateTime.Now.ToShortDateString();
            this.toolStripStatusLabel1.Text = str;
            str = DateTime.Now.DayOfWeek.ToString();
            this.toolStripStatusLabel2.Text = str;
            this.toolStripStatusLabel2.Text =
            DateTime.Now.ToString("HH:mm:ss");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            if (this.BackColor == Color.White)
                return;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter("changes_coler.txt", true))
                {
                    streamWriter.WriteLine($"{this.BackColor.R}:{this.BackColor.G}:{this.BackColor.B}");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            DialogResult dialogResult = form2.ShowDialog("Привет группа 311");
            if (dialogResult == DialogResult.OK)
            {
                this.textBox1.Text = form2.person.LastName;
                this.textBox2.Text = form2.person.FirstName;
                this.textBox3.Text = form2.person.MiddleName;
                this.textBox4.Text = form2.person.Birthdate.ToShortDateString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.IsMdiContainer = true;
            form3.MdiParent = this;
            form3.Show();


        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!String.IsNullOrEmpty(textBox6.Text))
                    textBox6.Text = String.Empty;
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        textBox6.Text += sr.ReadLine() + Environment.NewLine;
                    }
                }
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Checked)
                this.BackColor = Color.FromArgb(this.BackColor.A, 255, this.BackColor.G == 240 ? 0 : this.BackColor.G, this.BackColor.B == 240 ? 0 : this.BackColor.B);
            else
                this.BackColor = Color.FromArgb(this.BackColor.A, 0, this.BackColor.G == 240 ? 0 : this.BackColor.G, this.BackColor.B == 240 ? 0 : this.BackColor.B);

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Checked)
            {
                this.BackColor = Color.FromArgb(this.BackColor.A, this.BackColor.R == 240 ? 0 : this.BackColor.R, 255, this.BackColor.B == 240 ? 0 : this.BackColor.B);
            }
            else
            {
                this.BackColor = Color.FromArgb(this.BackColor.A, this.BackColor.R == 240 ? 0 : this.BackColor.R, 0, this.BackColor.B == 240 ? 0 : this.BackColor.B);

            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Checked)
                this.BackColor = Color.FromArgb(this.BackColor.A, this.BackColor.R == 240 ? 0 : this.BackColor.R, this.BackColor.G == 240 ? 0 : this.BackColor.G, 255);
            else
                this.BackColor = Color.FromArgb(this.BackColor.A, this.BackColor.R == 240 ? 0 : this.BackColor.R, this.BackColor.G == 240 ? 0 : this.BackColor.G, 0);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text.CompareTo("Русский") == 0)
            {
                (sender as Button).Text = "English";
                menuStripEnglish.Visible = false;
                menuStripRussian.Visible = true;
                menuStrip1 = menuStripEnglish;
  

            }
            else
            {
                (sender as Button).Text = "Русский";

                menuStripEnglish.Visible = true;
                menuStripRussian.Visible = false;
                menuStrip1 = menuStripRussian;
            }

        }
    }
}
