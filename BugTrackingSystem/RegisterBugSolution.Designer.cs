namespace BugTrackingSystem
{
    partial class RegisterBugSolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterBugSolution));
            this.pnlBugSolnInfo = new System.Windows.Forms.Panel();
            this.cmbBugDetails = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSolutionDetails = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.picSnap = new System.Windows.Forms.PictureBox();
            this.cmbbugsolvedby = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBugSolutionInformation = new System.Windows.Forms.DataGridView();
            this.pnlBugSolnInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSnap)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugSolutionInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBugSolnInfo
            // 
            this.pnlBugSolnInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBugSolnInfo.Controls.Add(this.cmbBugDetails);
            this.pnlBugSolnInfo.Controls.Add(this.panel2);
            this.pnlBugSolnInfo.Controls.Add(this.txtSolutionDetails);
            this.pnlBugSolnInfo.Controls.Add(this.label13);
            this.pnlBugSolnInfo.Controls.Add(this.cmbProject);
            this.pnlBugSolnInfo.Controls.Add(this.txtCode);
            this.pnlBugSolnInfo.Controls.Add(this.label12);
            this.pnlBugSolnInfo.Controls.Add(this.picSnap);
            this.pnlBugSolnInfo.Controls.Add(this.cmbbugsolvedby);
            this.pnlBugSolnInfo.Controls.Add(this.label7);
            this.pnlBugSolnInfo.Controls.Add(this.dateDate);
            this.pnlBugSolnInfo.Controls.Add(this.label4);
            this.pnlBugSolnInfo.Controls.Add(this.label2);
            this.pnlBugSolnInfo.Controls.Add(this.label3);
            this.pnlBugSolnInfo.Location = new System.Drawing.Point(5, 60);
            this.pnlBugSolnInfo.Name = "pnlBugSolnInfo";
            this.pnlBugSolnInfo.Size = new System.Drawing.Size(1035, 492);
            this.pnlBugSolnInfo.TabIndex = 16;
            this.pnlBugSolnInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // cmbBugDetails
            // 
            this.cmbBugDetails.BackColor = System.Drawing.SystemColors.Info;
            this.cmbBugDetails.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBugDetails.FormattingEnabled = true;
            this.cmbBugDetails.Location = new System.Drawing.Point(212, 129);
            this.cmbBugDetails.Name = "cmbBugDetails";
            this.cmbBugDetails.Size = new System.Drawing.Size(278, 39);
            this.cmbBugDetails.TabIndex = 31;
            this.cmbBugDetails.SelectedIndexChanged += new System.EventHandler(this.cmbBugDetails_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(890, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 230);
            this.panel2.TabIndex = 30;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(6, 160);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 38);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "CANCEL";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(6, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 38);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(6, 116);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(124, 38);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(6, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 38);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtSolutionDetails
            // 
            this.txtSolutionDetails.BackColor = System.Drawing.SystemColors.Info;
            this.txtSolutionDetails.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolutionDetails.Location = new System.Drawing.Point(212, 170);
            this.txtSolutionDetails.Multiline = true;
            this.txtSolutionDetails.Name = "txtSolutionDetails";
            this.txtSolutionDetails.Size = new System.Drawing.Size(278, 70);
            this.txtSolutionDetails.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(-1, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 33);
            this.label13.TabIndex = 28;
            this.label13.Text = "Solution Details:";
            // 
            // cmbProject
            // 
            this.cmbProject.BackColor = System.Drawing.SystemColors.Info;
            this.cmbProject.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(212, 88);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(278, 39);
            this.cmbProject.TabIndex = 27;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged_1);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.Info;
            this.txtCode.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(212, 253);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(667, 230);
            this.txtCode.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(119, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 33);
            this.label12.TabIndex = 25;
            this.label12.Text = "Code:";
            // 
            // picSnap
            // 
            this.picSnap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picSnap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSnap.InitialImage = ((System.Drawing.Image)(resources.GetObject("picSnap.InitialImage")));
            this.picSnap.Location = new System.Drawing.Point(499, 8);
            this.picSnap.Name = "picSnap";
            this.picSnap.Size = new System.Drawing.Size(529, 232);
            this.picSnap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSnap.TabIndex = 24;
            this.picSnap.TabStop = false;
            this.picSnap.WaitOnLoad = true;
            // 
            // cmbbugsolvedby
            // 
            this.cmbbugsolvedby.BackColor = System.Drawing.SystemColors.Info;
            this.cmbbugsolvedby.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbugsolvedby.FormattingEnabled = true;
            this.cmbbugsolvedby.Location = new System.Drawing.Point(212, 8);
            this.cmbbugsolvedby.Name = "cmbbugsolvedby";
            this.cmbbugsolvedby.Size = new System.Drawing.Size(278, 39);
            this.cmbbugsolvedby.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "Project:";
            // 
            // dateDate
            // 
            this.dateDate.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDate.Location = new System.Drawing.Point(212, 53);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(278, 32);
            this.dateDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bug Solved By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bug Details:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(-2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1059, 55);
            this.panel4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Register Bug Solution";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvBugSolutionInformation);
            this.panel3.Location = new System.Drawing.Point(5, 559);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1035, 239);
            this.panel3.TabIndex = 18;
            // 
            // dgvBugSolutionInformation
            // 
            this.dgvBugSolutionInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBugSolutionInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugSolutionInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBugSolutionInformation.Location = new System.Drawing.Point(0, 0);
            this.dgvBugSolutionInformation.Name = "dgvBugSolutionInformation";
            this.dgvBugSolutionInformation.RowTemplate.Height = 24;
            this.dgvBugSolutionInformation.Size = new System.Drawing.Size(1033, 237);
            this.dgvBugSolutionInformation.TabIndex = 0;
            this.dgvBugSolutionInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBugSolutionInformation_CellClick);
            // 
            // RegisterBugSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 799);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlBugSolnInfo);
            this.Controls.Add(this.panel4);
            this.Name = "RegisterBugSolution";
            this.Text = "RegisterBugSolution";
            this.Load += new System.EventHandler(this.RegisterBugSolution_Load);
            this.pnlBugSolnInfo.ResumeLayout(false);
            this.pnlBugSolnInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSnap)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugSolutionInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBugSolnInfo;
        private System.Windows.Forms.TextBox txtSolutionDetails;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox picSnap;
        private System.Windows.Forms.ComboBox cmbbugsolvedby;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvBugSolutionInformation;
        private System.Windows.Forms.ComboBox cmbBugDetails;
    }
}