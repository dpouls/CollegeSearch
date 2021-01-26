
namespace CollegeSearch
{
    partial class AddCollegeCityForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxCollege = new System.Windows.Forms.TextBox();
            this.TxtBoxCity = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LstBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "College";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "City";
            // 
            // TxtBoxCollege
            // 
            this.TxtBoxCollege.Location = new System.Drawing.Point(167, 115);
            this.TxtBoxCollege.Name = "TxtBoxCollege";
            this.TxtBoxCollege.Size = new System.Drawing.Size(150, 45);
            this.TxtBoxCollege.TabIndex = 0;
            // 
            // TxtBoxCity
            // 
            this.TxtBoxCity.Location = new System.Drawing.Point(167, 178);
            this.TxtBoxCity.Name = "TxtBoxCity";
            this.TxtBoxCity.Size = new System.Drawing.Size(150, 45);
            this.TxtBoxCity.TabIndex = 1;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(51, 231);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(266, 46);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "&Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LstBox
            // 
            this.LstBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstBox.FormattingEnabled = true;
            this.LstBox.ItemHeight = 25;
            this.LstBox.Location = new System.Drawing.Point(401, 48);
            this.LstBox.Name = "LstBox";
            this.LstBox.Size = new System.Drawing.Size(349, 329);
            this.LstBox.TabIndex = 3;
            this.LstBox.TabStop = false;
            // 
            // AddCollegeCityForm
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstBox);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtBoxCity);
            this.Controls.Add(this.TxtBoxCollege);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AddCollegeCityForm";
            this.Text = "Add College & City";
            this.Load += new System.EventHandler(this.AddCollegeCityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxCollege;
        private System.Windows.Forms.TextBox TxtBoxCity;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ListBox LstBox;
    }
}

