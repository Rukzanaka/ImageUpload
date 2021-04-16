namespace ImageUpload
{
    partial class StudentDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.checkUg = new System.Windows.Forms.CheckBox();
            this.CheckPg = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.picUpload = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Education";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(271, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(271, 162);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(187, 48);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(271, 253);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(59, 21);
            this.radioMale.TabIndex = 6;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(402, 253);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(75, 21);
            this.radioFemale.TabIndex = 7;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // checkUg
            // 
            this.checkUg.AutoSize = true;
            this.checkUg.Location = new System.Drawing.Point(271, 326);
            this.checkUg.Name = "checkUg";
            this.checkUg.Size = new System.Drawing.Size(51, 21);
            this.checkUg.TabIndex = 8;
            this.checkUg.Text = "UG";
            this.checkUg.UseVisualStyleBackColor = true;
            this.checkUg.CheckedChanged += new System.EventHandler(this.checkUg_CheckedChanged);
            // 
            // CheckPg
            // 
            this.CheckPg.AutoSize = true;
            this.CheckPg.Location = new System.Drawing.Point(402, 326);
            this.CheckPg.Name = "CheckPg";
            this.CheckPg.Size = new System.Drawing.Size(50, 21);
            this.CheckPg.TabIndex = 9;
            this.CheckPg.Text = "PG";
            this.CheckPg.UseVisualStyleBackColor = true;
            this.CheckPg.CheckedChanged += new System.EventHandler(this.CheckPg_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 48);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(502, 84);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(286, 34);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // picUpload
            // 
            this.picUpload.Location = new System.Drawing.Point(502, 124);
            this.picUpload.Name = "picUpload";
            this.picUpload.Size = new System.Drawing.Size(286, 241);
            this.picUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpload.TabIndex = 12;
            this.picUpload.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(502, 382);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(286, 48);
            this.btnUpload.TabIndex = 13;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.picUpload);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.CheckPg);
            this.Controls.Add(this.checkUg);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentDetails";
            this.Text = "StudentDetails";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.CheckBox checkUg;
        private System.Windows.Forms.CheckBox CheckPg;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.PictureBox picUpload;
        private System.Windows.Forms.Button btnUpload;
    }
}

