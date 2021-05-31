
namespace Rayon
{
    partial class Form1
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
            this.Rezult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBagrut = new System.Windows.Forms.TextBox();
            this.txtDapr = new System.Windows.Forms.TextBox();
            this.txtKaba = new System.Windows.Forms.TextBox();
            this.txtTz = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.profileCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rezult
            // 
            this.Rezult.Location = new System.Drawing.Point(348, 493);
            this.Rezult.Name = "Rezult";
            this.Rezult.Size = new System.Drawing.Size(131, 23);
            this.Rezult.TabIndex = 0;
            this.Rezult.Text = "לחץ לשליחה";
            this.Rezult.UseVisualStyleBackColor = true;
            this.Rezult.Click += new System.EventHandler(this.Rezult_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(221, 33);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 100);
            this.label1.TabIndex = 3;
            this.label1.Text = "מבחני קבלה";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBagrut
            // 
            this.txtBagrut.Location = new System.Drawing.Point(332, 439);
            this.txtBagrut.Name = "txtBagrut";
            this.txtBagrut.Size = new System.Drawing.Size(166, 22);
            this.txtBagrut.TabIndex = 4;
            this.txtBagrut.TextChanged += new System.EventHandler(this.txtBagrut_TextChanged);
            // 
            // txtDapr
            // 
            this.txtDapr.Location = new System.Drawing.Point(332, 371);
            this.txtDapr.Name = "txtDapr";
            this.txtDapr.Size = new System.Drawing.Size(166, 22);
            this.txtDapr.TabIndex = 5;
            this.txtDapr.TextChanged += new System.EventHandler(this.txtDapr_TextChanged);
            // 
            // txtKaba
            // 
            this.txtKaba.Location = new System.Drawing.Point(332, 302);
            this.txtKaba.Name = "txtKaba";
            this.txtKaba.Size = new System.Drawing.Size(166, 22);
            this.txtKaba.TabIndex = 6;
            this.txtKaba.TextChanged += new System.EventHandler(this.txtKaba_TextChanged);
            // 
            // txtTz
            // 
            this.txtTz.Location = new System.Drawing.Point(332, 236);
            this.txtTz.Name = "txtTz";
            this.txtTz.Size = new System.Drawing.Size(166, 22);
            this.txtTz.TabIndex = 7;
            this.txtTz.TextChanged += new System.EventHandler(this.txtTz_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(332, 175);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 22);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "שם מועמד";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "תעודת זהות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "קב\"א";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "ממוצע בגרות ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "דפ\"ר";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "*אנה הזן פרטים אישיים";
            // 
            // profileCheck
            // 
            this.profileCheck.Location = new System.Drawing.Point(348, 522);
            this.profileCheck.Name = "profileCheck";
            this.profileCheck.Size = new System.Drawing.Size(131, 23);
            this.profileCheck.TabIndex = 15;
            this.profileCheck.Text = "להדפסת פרטים";
            this.profileCheck.UseVisualStyleBackColor = true;
            this.profileCheck.Click += new System.EventHandler(this.profileCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 727);
            this.Controls.Add(this.profileCheck);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTz);
            this.Controls.Add(this.txtKaba);
            this.Controls.Add(this.txtDapr);
            this.Controls.Add(this.txtBagrut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rezult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rezult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBagrut;
        private System.Windows.Forms.TextBox txtDapr;
        private System.Windows.Forms.TextBox txtKaba;
        private System.Windows.Forms.TextBox txtTz;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button profileCheck;
    }
}

