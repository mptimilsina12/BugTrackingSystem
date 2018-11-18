namespace BugTrackingSystem
{
    partial class BugEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugEntryForm));
            this.dgvBugEntryInformation = new System.Windows.Forms.DataGridView();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtBugDetails = new System.Windows.Forms.TextBox();
            this.txtLineNumber = new System.Windows.Forms.TextBox();
            this.picSnap = new System.Windows.Forms.PictureBox();
            this.txtBlock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbIdentifiedBy = new System.Windows.Forms.ComboBox();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassLibrary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugEntryInformation)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSnap)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBugEntryInformation
            // 
            this.dgvBugEntryInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugEntryInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBugEntryInformation.Location = new System.Drawing.Point(0, 0);
            this.dgvBugEntryInformation.Name = "dgvBugEntryInformation";
            this.dgvBugEntryInformation.RowTemplate.Height = 24;
            this.dgvBugEntryInformation.Size = new System.Drawing.Size(1325, 256);
            this.dgvBugEntryInformation.TabIndex = 0;
            // 
            // dateDate
            // 
            this.dateDate.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDate.Location = new System.Drawing.Point(212, 13);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(240, 32);
            this.dateDate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(897, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Project:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(971, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 38);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(478, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(234, 38);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE Bug";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.txtBugDetails);
            this.panel1.Controls.Add(this.txtLineNumber);
            this.panel1.Controls.Add(this.picSnap);
            this.panel1.Controls.Add(this.txtBlock);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbProject);
            this.panel1.Controls.Add(this.cmbIdentifiedBy);
            this.panel1.Controls.Add(this.txtMethod);
            this.panel1.Controls.Add(this.txtClass);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dateDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtClassLibrary);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(6, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 422);
            this.panel1.TabIndex = 12;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.Info;
            this.txtCode.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(16, 172);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(529, 236);
            this.txtCode.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 33);
            this.label12.TabIndex = 25;
            this.label12.Text = "Code:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(1008, 379);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(205, 38);
            this.btnBrowse.TabIndex = 20;
            this.btnBrowse.Text = "Browse Snap";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBugDetails
            // 
            this.txtBugDetails.BackColor = System.Drawing.SystemColors.Info;
            this.txtBugDetails.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBugDetails.Location = new System.Drawing.Point(1076, 100);
            this.txtBugDetails.Multiline = true;
            this.txtBugDetails.Name = "txtBugDetails";
            this.txtBugDetails.Size = new System.Drawing.Size(240, 33);
            this.txtBugDetails.TabIndex = 22;
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtLineNumber.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineNumber.Location = new System.Drawing.Point(637, 98);
            this.txtLineNumber.Multiline = true;
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(240, 33);
            this.txtLineNumber.TabIndex = 21;
            // 
            // picSnap
            // 
            this.picSnap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picSnap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSnap.InitialImage = ((System.Drawing.Image)(resources.GetObject("picSnap.InitialImage")));
            this.picSnap.Location = new System.Drawing.Point(787, 144);
            this.picSnap.Name = "picSnap";
            this.picSnap.Size = new System.Drawing.Size(529, 232);
            this.picSnap.TabIndex = 24;
            this.picSnap.TabStop = false;
            this.picSnap.WaitOnLoad = true;
            // 
            // txtBlock
            // 
            this.txtBlock.BackColor = System.Drawing.SystemColors.Info;
            this.txtBlock.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlock.Location = new System.Drawing.Point(212, 100);
            this.txtBlock.Multiline = true;
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.Size = new System.Drawing.Size(240, 33);
            this.txtBlock.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(458, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 33);
            this.label9.TabIndex = 19;
            this.label9.Text = "Line Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(458, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(289, 33);
            this.label11.TabIndex = 23;
            this.label11.Text = "Snap of Error Message:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(897, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 33);
            this.label10.TabIndex = 18;
            this.label10.Text = "Bug Details:";
            // 
            // cmbProject
            // 
            this.cmbProject.BackColor = System.Drawing.SystemColors.Info;
            this.cmbProject.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(1076, 8);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(240, 39);
            this.cmbProject.TabIndex = 17;
            // 
            // cmbIdentifiedBy
            // 
            this.cmbIdentifiedBy.BackColor = System.Drawing.SystemColors.Info;
            this.cmbIdentifiedBy.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdentifiedBy.FormattingEnabled = true;
            this.cmbIdentifiedBy.Location = new System.Drawing.Point(637, 9);
            this.cmbIdentifiedBy.Name = "cmbIdentifiedBy";
            this.cmbIdentifiedBy.Size = new System.Drawing.Size(240, 39);
            this.cmbIdentifiedBy.TabIndex = 16;
            // 
            // txtMethod
            // 
            this.txtMethod.BackColor = System.Drawing.SystemColors.Info;
            this.txtMethod.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMethod.Location = new System.Drawing.Point(1076, 57);
            this.txtMethod.Multiline = true;
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(240, 33);
            this.txtMethod.TabIndex = 15;
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.SystemColors.Info;
            this.txtClass.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(637, 57);
            this.txtClass.Multiline = true;
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(240, 33);
            this.txtClass.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(897, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "Method:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "Class Library:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 33);
            this.label8.TabIndex = 11;
            this.label8.Text = "Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identified By:";
            // 
            // txtClassLibrary
            // 
            this.txtClassLibrary.BackColor = System.Drawing.SystemColors.Info;
            this.txtClassLibrary.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassLibrary.Location = new System.Drawing.Point(212, 57);
            this.txtClassLibrary.Multiline = true;
            this.txtClassLibrary.Name = "txtClassLibrary";
            this.txtClassLibrary.Size = new System.Drawing.Size(240, 33);
            this.txtClassLibrary.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Block:";
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(717, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(248, 38);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "DELETE Bug";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(6, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 47);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(195, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(277, 38);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Register Identified Bug";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvBugEntryInformation);
            this.panel3.Location = new System.Drawing.Point(6, 535);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1327, 258);
            this.panel3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bug Entry Form";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1387, 55);
            this.panel4.TabIndex = 15;
            // 
            // BugEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 814);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BugEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BugEntryForm";
            this.Load += new System.EventHandler(this.BugEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugEntryInformation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSnap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBugEntryInformation;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassLibrary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbIdentifiedBy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBugDetails;
        private System.Windows.Forms.TextBox txtLineNumber;
        private System.Windows.Forms.TextBox txtBlock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.PictureBox picSnap;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBrowse;
    }
}