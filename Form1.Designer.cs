﻿namespace Kontakte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.textBoxContactID = new System.Windows.Forms.TextBox();
            this.labelContactID = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(55, 34);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(329, 73);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // textBoxContactID
            // 
            this.textBoxContactID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContactID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxContactID.Location = new System.Drawing.Point(209, 208);
            this.textBoxContactID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxContactID.Name = "textBoxContactID";
            this.textBoxContactID.Size = new System.Drawing.Size(354, 30);
            this.textBoxContactID.TabIndex = 1;
            this.textBoxContactID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelContactID
            // 
            this.labelContactID.AutoSize = true;
            this.labelContactID.BackColor = System.Drawing.Color.Transparent;
            this.labelContactID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContactID.Location = new System.Drawing.Point(55, 210);
            this.labelContactID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelContactID.Name = "labelContactID";
            this.labelContactID.Size = new System.Drawing.Size(92, 23);
            this.labelContactID.TabIndex = 2;
            this.labelContactID.Tag = "";
            this.labelContactID.Text = "Contact ID";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.Location = new System.Drawing.Point(55, 248);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(92, 23);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Tag = "";
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxFirstName.Location = new System.Drawing.Point(209, 245);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(354, 30);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.Location = new System.Drawing.Point(55, 283);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 23);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Tag = "";
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLastName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxLastName.Location = new System.Drawing.Point(209, 283);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(354, 30);
            this.textBoxLastName.TabIndex = 5;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneNumber.Location = new System.Drawing.Point(55, 329);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(113, 23);
            this.labelPhoneNumber.TabIndex = 8;
            this.labelPhoneNumber.Tag = "";
            this.labelPhoneNumber.Text = "Phone Number";
            this.labelPhoneNumber.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhoneNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(209, 326);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(354, 30);
            this.textBoxPhoneNumber.TabIndex = 7;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(55, 420);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(70, 23);
            this.labelAddress.TabIndex = 10;
            this.labelAddress.Tag = "";
            this.labelAddress.Text = "Address";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(209, 407);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(354, 97);
            this.textBox4.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(209, 369);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 30);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(55, 376);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(49, 23);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Tag = "";
            this.labelEmail.Text = "Email";
            this.labelEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonCreate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCreate.Location = new System.Drawing.Point(51, 560);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(109, 38);
            this.buttonCreate.TabIndex = 13;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.BackColor = System.Drawing.Color.DimGray;
            this.buttonClearAll.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClearAll.ForeColor = System.Drawing.Color.White;
            this.buttonClearAll.Location = new System.Drawing.Point(440, 560);
            this.buttonClearAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(109, 38);
            this.buttonClearAll.TabIndex = 14;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = false;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(310, 560);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 38);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Orange;
            this.buttonUpdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(180, 560);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(109, 38);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(746, 210);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(952, 388);
            this.dataGridView1.TabIndex = 17;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSearch.Location = new System.Drawing.Point(744, 173);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(78, 23);
            this.labelSearch.TabIndex = 18;
            this.labelSearch.Text = "Search :";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(837, 164);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(860, 30);
            this.textBox2.TabIndex = 19;
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonImport.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonImport.Location = new System.Drawing.Point(1715, 212);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(144, 39);
            this.buttonImport.TabIndex = 20;
            this.buttonImport.Text = "Import...";
            this.buttonImport.UseVisualStyleBackColor = false;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonExport.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExport.Location = new System.Drawing.Point(1715, 267);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(144, 39);
            this.buttonExport.TabIndex = 21;
            this.buttonExport.Text = "Export...";
            this.buttonExport.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(837, 809);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "v0.1 Brought to you by @rayekov";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1920, 848);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelContactID);
            this.Controls.Add(this.textBoxContactID);
            this.Controls.Add(this.pictureBoxLogo);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontakte";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxLogo;
        private TextBox textBoxContactID;
        private Label labelContactID;
        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private Label labelPhoneNumber;
        private TextBox textBoxPhoneNumber;
        private Label labelAddress;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label labelEmail;
        private Button buttonCreate;
        private Button buttonClearAll;
        private Button buttonDelete;
        private Button buttonUpdate;
        private DataGridView dataGridView1;
        private Label labelSearch;
        private TextBox textBox2;
        private Button buttonImport;
        private Button buttonExport;
        private Label label1;
    }
}