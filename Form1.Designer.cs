namespace para1
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
            button1 = new Button();
            button2 = new Button();
            DataTable = new DataGridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)DataTable).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(21, 12);
            button1.Name = "button1";
            button1.Size = new Size(118, 43);
            button1.TabIndex = 0;
            button1.Text = "Заполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(21, 77);
            button2.Name = "button2";
            button2.Size = new Size(118, 43);
            button2.TabIndex = 1;
            button2.Text = "Посмотреть";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DataTable
            // 
            DataTable.AllowUserToResizeColumns = false;
            DataTable.AllowUserToResizeRows = false;
            DataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable.Location = new Point(162, 12);
            DataTable.Name = "DataTable";
            DataTable.RowHeadersVisible = false;
            DataTable.RowHeadersWidth = 51;
            DataTable.RowTemplate.Height = 29;
            DataTable.ScrollBars = ScrollBars.Vertical;
            DataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataTable.Size = new Size(811, 499);
            DataTable.TabIndex = 2;
            DataTable.CellDoubleClick += DataTable_CellDoubleClick;
            // 
            // button3
            // 
            button3.Location = new Point(21, 143);
            button3.Name = "button3";
            button3.Size = new Size(118, 43);
            button3.TabIndex = 3;
            button3.Text = "Очистить все";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 523);
            Controls.Add(button3);
            Controls.Add(DataTable);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(1003, 570);
            MinimumSize = new Size(1003, 570);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView DataTable;
        private Button button3;
    }
}