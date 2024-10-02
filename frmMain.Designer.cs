namespace WinFormsApp6_framework_
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogout = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textID = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            textPengguna = new TextBox();
            btnSave = new Button();
            btnSearch = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dataGridView1 = new DataGridView();
            CBLevel = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(512, 106);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(78, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 35);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "ID Pengguna";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 73);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 106);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 134);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 5;
            label4.Text = "Nama Pengguna";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 167);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 6;
            label5.Text = "Level";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 250);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 7;
            // 
            // textID
            // 
            textID.Location = new Point(139, 32);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(381, 192);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(344, 238);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 10;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(139, 73);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(100, 23);
            textUsername.TabIndex = 11;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(139, 103);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(100, 23);
            textPassword.TabIndex = 12;
            textPassword.TextChanged += textBox3_TextChanged;
            // 
            // textPengguna
            // 
            textPengguna.Location = new Point(139, 134);
            textPengguna.Name = "textPengguna";
            textPengguna.Size = new Size(100, 23);
            textPengguna.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(381, 25);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(512, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(381, 69);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(512, 65);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(381, 106);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(602, 178);
            dataGridView1.TabIndex = 21;
            // 
            // CBLevel
            // 
            CBLevel.FormattingEnabled = true;
            CBLevel.Items.AddRange(new object[] { "1", "2" });
            CBLevel.Location = new Point(139, 167);
            CBLevel.Name = "CBLevel";
            CBLevel.Size = new Size(121, 23);
            CBLevel.TabIndex = 22;
            CBLevel.SelectedIndexChanged += CBLevel_SelectedIndexChanged;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CBLevel);
            Controls.Add(dataGridView1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(textPengguna);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogout;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textID;
        private Label label7;
        private Label label8;
        private TextBox textUsername;
        private TextBox textPassword;
        private TextBox textPengguna;
        private Button btnSave;
        private Button btnSearch;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dataGridView1;
        private ComboBox CBLevel;
    }
}