using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace para1
{

    public partial class Form2 : Form
    {
        private string? name, surname;
        private static string? group;
        private int exam;
        private string? photoPath;

        private string[] groups = { "РФ-425", "РФ-426", "РФ-427", "РФ-428", "РФ-429" };

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.DataSource = groups;
            comboBox1.SelectedIndex = 0;
        }

        static void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            group = comboBox.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPicture = new OpenFileDialog();
            openPicture.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png";

            if (openPicture.ShowDialog() == DialogResult.OK)
            {
                photoPath = openPicture.FileName;
                pictureBox1.Image = Image.FromFile(photoPath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool FLAG = false;
            if (textBox1.Text.Length == 0) { MessageBox.Show("Enter LASTNAME!"); FLAG = true; }
            if (textBox2.Text.Length == 0) { MessageBox.Show("Enter NAME!"); FLAG = true; }
            if (textBox4.Text.Length == 0 || !(new Utils()).isDigit(textBox4.Text)) { MessageBox.Show("Incorrect assessment for the exam"); FLAG = true; }

            if (!FLAG)
            {
                name = textBox1.Text;
                surname = textBox2.Text;
                exam = int.Parse(textBox4.Text);

                Student student = new Student();
                student.createStudent(name, surname, group, exam, photoPath);

                FileManager manager = new FileManager();
                manager.writeLineInFile("D:\\TestFiles\\data.txt", student.getInfo(), true);

                Close();
            }
        }
    }
}
