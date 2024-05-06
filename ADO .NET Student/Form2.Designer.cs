namespace ADO.NET_Student
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
            this.btnShowALL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRollNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowALL
            // 
            this.btnShowALL.Location = new System.Drawing.Point(565, 325);
            this.btnShowALL.Name = "btnShowALL";
            this.btnShowALL.Size = new System.Drawing.Size(366, 41);
            this.btnShowALL.TabIndex = 29;
            this.btnShowALL.Text = "Show All Students";
            this.btnShowALL.UseVisualStyleBackColor = true;
            this.btnShowALL.Click += new System.EventHandler(this.btnShowALL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(516, 210);
            this.dataGridView1.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(352, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 34);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(322, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 37);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(228, 271);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 37);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(135, 271);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 37);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(44, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 37);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(158, 216);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(166, 26);
            this.txtFees.TabIndex = 22;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(158, 177);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(166, 26);
            this.txtCourse.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 26);
            this.txtName.TabIndex = 20;
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(158, 93);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(166, 26);
            this.txtRollNo.TabIndex = 19;
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(54, 222);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(45, 20);
            this.lblFees.TabIndex = 18;
            this.lblFees.Text = "Fees";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(54, 177);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(60, 20);
            this.lblCourse.TabIndex = 17;
            this.lblCourse.Text = "Course";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(54, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Location = new System.Drawing.Point(54, 93);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(56, 20);
            this.lblRollNo.TabIndex = 15;
            this.lblRollNo.Text = "RollNo";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.btnShowALL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRollNo);
            this.Name = "Form2";
            this.Text = "Disconnected Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowALL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRollNo;
    }
}