using System.Security.Cryptography.Pkcs;

namespace Calendar
{
    public partial class Form1 : Form
    {
        AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                using (StreamReader sr = new StreamReader(name.Name))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.StartsWith("Дата рождения:"))
                        {
                            string[] temp = line.Split(new char[] { ':' });
                            string dateString = temp[1].Trim();
                            if (temp.Length > 1 && dateString.Length > 0)
                                listBox1.Items.Add(dateString);
                            else
                                listBox1.Items.Add("Нет данных");
                            break;
                        }
                    }

                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"{(sender as ListBox).SelectedItem}");
        }
    }
}
