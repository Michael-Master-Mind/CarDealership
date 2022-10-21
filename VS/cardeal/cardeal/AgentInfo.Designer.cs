namespace cardeal
{
    partial class AgentInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(30, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 38);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(63, 93);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 26);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "email";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(63, 58);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(114, 26);
            this.lblLocation.TabIndex = 25;
            this.lblLocation.Text = "Location";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(63, 130);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(85, 26);
            this.lblPhone.TabIndex = 26;
            this.lblPhone.Text = "Phone";
            // 
            // AgentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Name = "AgentInfo";
            this.Size = new System.Drawing.Size(739, 188);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblPhone;
    }
}
