namespace StudentProfile
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
            lblName = new Label();
            lblcontact = new Label();
            txtPhone = new TextBox();
            lblcontacts = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(12, 184);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 65);
            lblName.TabIndex = 0;
            // 
            // lblcontact
            // 
            lblcontact.AutoSize = true;
            lblcontact.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcontact.Location = new Point(30, 383);
            lblcontact.Name = "lblcontact";
            lblcontact.Size = new Size(0, 25);
            lblcontact.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(30, 386);
            txtPhone.MaxLength = 11;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(134, 29);
            txtPhone.TabIndex = 2;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // lblcontacts
            // 
            lblcontacts.AutoSize = true;
            lblcontacts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcontacts.Location = new Point(30, 362);
            lblcontacts.Name = "lblcontacts";
            lblcontacts.Size = new Size(214, 21);
            lblcontacts.TabIndex = 3;
            lblcontacts.Text = "ENTER CONTACT NUMBER:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 597);
            Controls.Add(lblcontacts);
            Controls.Add(txtPhone);
            Controls.Add(lblcontact);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblcontact;
        private TextBox txtPhone;
        private Label lblcontacts;
    }
}
