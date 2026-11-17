namespace SchoolApp
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtInstitution = new TextBox();
            btnSave = new Button();
            dgvData = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 49);
            label1.Name = "label1";
            label1.Size = new Size(123, 42);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(279, 55);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Masukan Nama";
            txtName.Size = new Size(220, 36);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 127);
            label2.Name = "label2";
            label2.Size = new Size(222, 42);
            label2.TabIndex = 2;
            label2.Text = "Institution";
            label2.Click += label2_Click;
            // 
            // txtInstitution
            // 
            txtInstitution.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInstitution.Location = new Point(279, 133);
            txtInstitution.Name = "txtInstitution";
            txtInstitution.PlaceholderText = "Institution";
            txtInstitution.Size = new Size(220, 36);
            txtInstitution.TabIndex = 3;
            txtInstitution.TextChanged += this.txtInstitution_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(560, 55);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 36);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(49, 202);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(450, 225);
            dgvData.TabIndex = 5;
            dgvData.CellClick += dgvData_CellClick;
            dgvData.CellContentClick += this.dgvData_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(560, 111);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 40);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(560, 171);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 36);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvData);
            Controls.Add(btnSave);
            Controls.Add(txtInstitution);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtInstitution_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtInstitution;
        private Button btnSave;
        private DataGridView dgvData;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
