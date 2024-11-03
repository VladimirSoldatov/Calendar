namespace Calendar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            listBox1 = new ListBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            button4 = new Button();
            textBox5 = new TextBox();
            listBox2 = new ListBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            button5 = new Button();
            numericUpDown1 = new NumericUpDown();
            toolTip1 = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            button6 = new Button();
            button7 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(125, 227);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(301, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(79, 457);
            button1.Name = "button1";
            button1.Size = new Size(139, 23);
            button1.TabIndex = 1;
            button1.Text = "Включить каледарь";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(224, 457);
            button2.Name = "button2";
            button2.Size = new Size(139, 23);
            button2.TabIndex = 2;
            button2.Text = "Отключить каледарь";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(369, 457);
            button3.Name = "button3";
            button3.Size = new Size(139, 23);
            button3.TabIndex = 4;
            button3.Text = "Записать дату";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(301, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(125, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(301, 23);
            textBox3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 91);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 8;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 146);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 199);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 10;
            label4.Text = "Отчество";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(125, 285);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(309, 94);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(125, 256);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(301, 23);
            textBox4.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PHP", "C#", "C++", "Python" });
            comboBox1.Location = new Point(124, 400);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(310, 23);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "Не выбрано";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Test 1", "Test 2" });
            checkedListBox1.Location = new Point(529, 68);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(136, 94);
            checkedListBox1.TabIndex = 14;
            // 
            // button4
            // 
            button4.Location = new Point(529, 255);
            button4.Name = "button4";
            button4.Size = new Size(136, 23);
            button4.TabIndex = 16;
            button4.Text = "ChecedListBoxButtom";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(529, 199);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(136, 23);
            textBox5.TabIndex = 17;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(701, 72);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(187, 79);
            listBox2.TabIndex = 18;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(529, 327);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(136, 23);
            progressBar1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(529, 367);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 20;
            label1.Text = "label1";
            // 
            // button5
            // 
            button5.Location = new Point(529, 396);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 21;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            button5.MouseHover += button5_MouseHover;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(610, 399);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(55, 23);
            numericUpDown1.TabIndex = 22;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 497);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1443, 22);
            statusStrip1.TabIndex = 23;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(118, 17);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(705, 227);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(244, 45);
            trackBar1.TabIndex = 24;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(705, 285);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(244, 45);
            trackBar2.TabIndex = 25;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(705, 347);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(244, 45);
            trackBar3.TabIndex = 26;
            // 
            // button6
            // 
            button6.Location = new Point(705, 396);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 27;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(529, 457);
            button7.Name = "button7";
            button7.Size = new Size(136, 23);
            button7.TabIndex = 28;
            button7.Text = "Open new Window";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(826, 396);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 29;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 519);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(statusStrip1);
            Controls.Add(numericUpDown1);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(listBox2);
            Controls.Add(textBox5);
            Controls.Add(button4);
            Controls.Add(checkedListBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private SaveFileDialog saveFileDialog1;
        private ListBox listBox1;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private CheckedListBox checkedListBox1;
        private Button button4;
        private TextBox textBox5;
        private ListBox listBox2;
        private ProgressBar progressBar1;
        private Label label1;
        private Button button5;
        private NumericUpDown numericUpDown1;
        private ToolTip toolTip1;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private Button button6;
        private Button button7;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button8;
    }
}
