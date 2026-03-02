namespace WinFormDemo
{
    partial class Form2
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
            btnInsert = new Button();
            btnFind = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            btnInsertIntoDatabase = new Button();
            dataGridView1 = new DataGridView();
            lblEmpId = new Label();
            lblEmpName = new Label();
            lblDesignation = new Label();
            lblDOJ = new Label();
            lblSalary = new Label();
            lblDepNo = new Label();
            txtEmpId = new TextBox();
            txtEmpName = new TextBox();
            txtDesignation = new TextBox();
            txtDOJ = new TextBox();
            txtSalary = new TextBox();
            txtDepNo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(32, 302);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(160, 302);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 1;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(298, 302);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(32, 355);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(160, 355);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(298, 355);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnInsertIntoDatabase
            // 
            btnInsertIntoDatabase.Location = new Point(490, 323);
            btnInsertIntoDatabase.Name = "btnInsertIntoDatabase";
            btnInsertIntoDatabase.Size = new Size(157, 29);
            btnInsertIntoDatabase.TabIndex = 6;
            btnInsertIntoDatabase.Text = "Insert into database";
            btnInsertIntoDatabase.UseVisualStyleBackColor = true;
            btnInsertIntoDatabase.Click += btnInsertIntoDatabase_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(415, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(335, 243);
            dataGridView1.TabIndex = 7;
            // 
            // lblEmpId
            // 
            lblEmpId.AutoSize = true;
            lblEmpId.Location = new Point(32, 43);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(90, 20);
            lblEmpId.TabIndex = 8;
            lblEmpId.Text = "Enter EmpId";
            // 
            // lblEmpName
            // 
            lblEmpName.AutoSize = true;
            lblEmpName.Location = new Point(32, 84);
            lblEmpName.Name = "lblEmpName";
            lblEmpName.Size = new Size(117, 20);
            lblEmpName.TabIndex = 9;
            lblEmpName.Text = "Enter EmpName";
            // 
            // lblDesignation
            // 
            lblDesignation.AutoSize = true;
            lblDesignation.Location = new Point(32, 120);
            lblDesignation.Name = "lblDesignation";
            lblDesignation.Size = new Size(127, 20);
            lblDesignation.TabIndex = 10;
            lblDesignation.Text = "Enter Designation";
            // 
            // lblDOJ
            // 
            lblDOJ.AutoSize = true;
            lblDOJ.Location = new Point(32, 154);
            lblDOJ.Name = "lblDOJ";
            lblDOJ.Size = new Size(70, 20);
            lblDOJ.TabIndex = 11;
            lblDOJ.Text = "Emp DOJ";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(32, 189);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(87, 20);
            lblSalary.TabIndex = 12;
            lblSalary.Text = "Enter Salary";
            // 
            // lblDepNo
            // 
            lblDepNo.AutoSize = true;
            lblDepNo.Location = new Point(32, 228);
            lblDepNo.Name = "lblDepNo";
            lblDepNo.Size = new Size(91, 20);
            lblDepNo.TabIndex = 13;
            lblDepNo.Text = "Emp DepNo";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(171, 36);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(125, 27);
            txtEmpId.TabIndex = 14;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(171, 69);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(125, 27);
            txtEmpName.TabIndex = 15;
            // 
            // txtDesignation
            // 
            txtDesignation.Location = new Point(171, 113);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(125, 27);
            txtDesignation.TabIndex = 16;
            // 
            // txtDOJ
            // 
            txtDOJ.Location = new Point(171, 151);
            txtDOJ.Name = "txtDOJ";
            txtDOJ.Size = new Size(125, 27);
            txtDOJ.TabIndex = 17;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(171, 192);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(125, 27);
            txtSalary.TabIndex = 18;
            // 
            // txtDepNo
            // 
            txtDepNo.Location = new Point(171, 228);
            txtDepNo.Name = "txtDepNo";
            txtDepNo.Size = new Size(125, 27);
            txtDepNo.TabIndex = 19;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDepNo);
            Controls.Add(txtSalary);
            Controls.Add(txtDOJ);
            Controls.Add(txtDesignation);
            Controls.Add(txtEmpName);
            Controls.Add(txtEmpId);
            Controls.Add(lblDepNo);
            Controls.Add(lblSalary);
            Controls.Add(lblDOJ);
            Controls.Add(lblDesignation);
            Controls.Add(lblEmpName);
            Controls.Add(lblEmpId);
            Controls.Add(dataGridView1);
            Controls.Add(btnInsertIntoDatabase);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnFind);
            Controls.Add(btnInsert);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private Button btnFind;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private Button btnInsertIntoDatabase;
        private DataGridView dataGridView1;
        private Label lblEmpId;
        private Label lblEmpName;
        private Label lblDesignation;
        private Label lblDOJ;
        private Label lblSalary;
        private Label lblDepNo;
        private TextBox txtEmpId;
        private TextBox txtEmpName;
        private TextBox txtDesignation;
        private TextBox txtDOJ;
        private TextBox txtSalary;
        private TextBox txtDepNo;
    }
}