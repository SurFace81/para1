namespace para1
{
    public partial class Form1 : Form
    {
        private FileManager fileManager;
        private TableView tableView;

        private const string DATA_PATH = "D:\\TestFiles\\data.txt";
        private const string DATA_FOLDER = "D:\\TestFiles";
        public Form1()
        {
            fileManager = new FileManager();
            tableView = new TableView();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableView.clearAllRows(DataTable);

            int dataTableWidth = DataTable.Width / 4;

            tableView.tableAddColumn(DataTable, "Name", dataTableWidth);
            tableView.tableAddColumn(DataTable, "Lastname", dataTableWidth);
            tableView.tableAddColumn(DataTable, "Group", dataTableWidth);
            tableView.tableAddColumn(DataTable, "Exam", dataTableWidth);
            tableView.tableAddColumn(DataTable, "OTHER");

            if (fileManager.isExists(DATA_PATH))
            {
                string? line;
                while ((line = fileManager.readLineInFile(DATA_PATH)) != "")
                {
                    tableView.tableAddRow(DataTable, line, 5);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableView.clearAllRows(DataTable);
            //fileManager.deleteAllFiles(DATA_FOLDER, ".txt");
            fileManager.deleteFile(DATA_PATH);
        }

        private void DataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form3 form3 = new Form3();

            form3.label5.Text = this.DataTable.CurrentRow.Cells[0].Value.ToString();
            form3.label6.Text = this.DataTable.CurrentRow.Cells[1].Value.ToString();
            form3.label7.Text = this.DataTable.CurrentRow.Cells[2].Value.ToString();
            form3.label8.Text = this.DataTable.CurrentRow.Cells[3].Value.ToString();

            string path = this.DataTable.CurrentRow.Cells[4].Value.ToString();
            if (path != null && path.Length != 0)
            {
                form3.pictureBox1.Image = Image.FromFile(path);
                form3.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            form3.ShowDialog();
        }
    }
}