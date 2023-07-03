namespace Bloom2.forms
{
    partial class Create_worker
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
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passTb = new System.Windows.Forms.TextBox();
            this.passLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.messageLbl = new System.Windows.Forms.Label();
            this.phoneNumberTb = new System.Windows.Forms.TextBox();
            this.phoneNLbl = new System.Windows.Forms.Label();
            this.phoneCodeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(32, 75);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(105, 25);
            this.firstNameLbl.TabIndex = 0;
            this.firstNameLbl.Text = "FirstName:";
            // 
            // firstNameTb
            // 
            this.firstNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTb.Location = new System.Drawing.Point(161, 52);
            this.firstNameTb.Multiline = true;
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(389, 42);
            this.firstNameTb.TabIndex = 1;
            // 
            // lastNameTb
            // 
            this.lastNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTb.Location = new System.Drawing.Point(161, 129);
            this.lastNameTb.Multiline = true;
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(389, 42);
            this.lastNameTb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "LastName:";
            // 
            // passTb
            // 
            this.passTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTb.Location = new System.Drawing.Point(161, 208);
            this.passTb.Multiline = true;
            this.passTb.Name = "passTb";
            this.passTb.Size = new System.Drawing.Size(389, 42);
            this.passTb.TabIndex = 5;
            this.passTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passTb_KeyPress);
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.Location = new System.Drawing.Point(32, 225);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(98, 25);
            this.passLbl.TabIndex = 4;
            this.passLbl.Text = "Password:";
            this.passLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Thistle;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(161, 361);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(143, 64);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Create";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Thistle;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(407, 361);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(143, 64);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // messageLbl
            // 
            this.messageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLbl.Location = new System.Drawing.Point(206, 26);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(299, 23);
            this.messageLbl.TabIndex = 8;
            this.messageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneNumberTb
            // 
            this.phoneNumberTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumberTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumberTb.Location = new System.Drawing.Point(234, 287);
            this.phoneNumberTb.Multiline = true;
            this.phoneNumberTb.Name = "phoneNumberTb";
            this.phoneNumberTb.Size = new System.Drawing.Size(316, 42);
            this.phoneNumberTb.TabIndex = 10;
            this.phoneNumberTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberTb_KeyPress);
            // 
            // phoneNLbl
            // 
            this.phoneNLbl.AutoSize = true;
            this.phoneNLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNLbl.Location = new System.Drawing.Point(32, 304);
            this.phoneNLbl.Name = "phoneNLbl";
            this.phoneNLbl.Size = new System.Drawing.Size(96, 25);
            this.phoneNLbl.TabIndex = 9;
            this.phoneNLbl.Text = "Phone N :";
            // 
            // phoneCodeLbl
            // 
            this.phoneCodeLbl.BackColor = System.Drawing.Color.LightCyan;
            this.phoneCodeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneCodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneCodeLbl.Location = new System.Drawing.Point(158, 287);
            this.phoneCodeLbl.Name = "phoneCodeLbl";
            this.phoneCodeLbl.Size = new System.Drawing.Size(77, 42);
            this.phoneCodeLbl.TabIndex = 12;
            this.phoneCodeLbl.Text = "+998";
            this.phoneCodeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Create_worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(741, 468);
            this.Controls.Add(this.phoneCodeLbl);
            this.Controls.Add(this.phoneNumberTb);
            this.Controls.Add(this.phoneNLbl);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.lastNameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameTb);
            this.Controls.Add(this.firstNameLbl);
            this.Name = "Create_worker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_worker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox firstNameTb;
        private System.Windows.Forms.TextBox lastNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.TextBox phoneNumberTb;
        private System.Windows.Forms.Label phoneNLbl;
        private System.Windows.Forms.Label phoneCodeLbl;
    }
}