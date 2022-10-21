namespace cardeal
{
    partial class Dash
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLastest = new System.Windows.Forms.Label();
            this.lblOldest = new System.Windows.Forms.Label();
            this.lblCheapest = new System.Windows.Forms.Label();
            this.lblExpensive = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.labelo = new System.Windows.Forms.Label();
            this.labelc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPurhcases = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1423, 760);
            this.panel2.TabIndex = 31;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(666, 25);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(746, 575);
            this.dgv.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lblPurhcases);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblLastest);
            this.panel3.Controls.Add(this.lblOldest);
            this.panel3.Controls.Add(this.lblCheapest);
            this.panel3.Controls.Add(this.lblExpensive);
            this.panel3.Controls.Add(this.lblTotalCount);
            this.panel3.Controls.Add(this.labelT);
            this.panel3.Controls.Add(this.labell);
            this.panel3.Controls.Add(this.labelE);
            this.panel3.Controls.Add(this.labelo);
            this.panel3.Controls.Add(this.labelc);
            this.panel3.Location = new System.Drawing.Point(13, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(652, 575);
            this.panel3.TabIndex = 30;
            // 
            // lblLastest
            // 
            this.lblLastest.AutoSize = true;
            this.lblLastest.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastest.ForeColor = System.Drawing.Color.White;
            this.lblLastest.Location = new System.Drawing.Point(189, 335);
            this.lblLastest.Name = "lblLastest";
            this.lblLastest.Size = new System.Drawing.Size(103, 38);
            this.lblLastest.TabIndex = 33;
            this.lblLastest.Text = "Latest:";
            // 
            // lblOldest
            // 
            this.lblOldest.AutoSize = true;
            this.lblOldest.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldest.ForeColor = System.Drawing.Color.White;
            this.lblOldest.Location = new System.Drawing.Point(195, 282);
            this.lblOldest.Name = "lblOldest";
            this.lblOldest.Size = new System.Drawing.Size(109, 38);
            this.lblOldest.TabIndex = 32;
            this.lblOldest.Text = "Oldest:";
            // 
            // lblCheapest
            // 
            this.lblCheapest.AutoSize = true;
            this.lblCheapest.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheapest.ForeColor = System.Drawing.Color.White;
            this.lblCheapest.Location = new System.Drawing.Point(230, 231);
            this.lblCheapest.Name = "lblCheapest";
            this.lblCheapest.Size = new System.Drawing.Size(144, 38);
            this.lblCheapest.TabIndex = 31;
            this.lblCheapest.Text = "Cheapest:";
            // 
            // lblExpensive
            // 
            this.lblExpensive.AutoSize = true;
            this.lblExpensive.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpensive.ForeColor = System.Drawing.Color.White;
            this.lblExpensive.Location = new System.Drawing.Point(315, 182);
            this.lblExpensive.Name = "lblExpensive";
            this.lblExpensive.Size = new System.Drawing.Size(229, 38);
            this.lblExpensive.TabIndex = 30;
            this.lblExpensive.Text = "Most Expensive:";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.ForeColor = System.Drawing.Color.White;
            this.lblTotalCount.Location = new System.Drawing.Point(262, 135);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(176, 38);
            this.lblTotalCount.TabIndex = 29;
            this.lblTotalCount.Text = "Total Count:";
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelT.Location = new System.Drawing.Point(80, 135);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(176, 38);
            this.labelT.TabIndex = 28;
            this.labelT.Text = "Total Count:";
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labell.Location = new System.Drawing.Point(80, 335);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(103, 38);
            this.labell.TabIndex = 27;
            this.labell.Text = "Latest:";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelE.Location = new System.Drawing.Point(80, 182);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(229, 38);
            this.labelE.TabIndex = 24;
            this.labelE.Text = "Most Expensive:";
            // 
            // labelo
            // 
            this.labelo.AutoSize = true;
            this.labelo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelo.Location = new System.Drawing.Point(80, 282);
            this.labelo.Name = "labelo";
            this.labelo.Size = new System.Drawing.Size(109, 38);
            this.labelo.TabIndex = 26;
            this.labelo.Text = "Oldest:";
            // 
            // labelc
            // 
            this.labelc.AutoSize = true;
            this.labelc.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelc.Location = new System.Drawing.Point(80, 231);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(144, 38);
            this.labelc.TabIndex = 25;
            this.labelc.Text = "Cheapest:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(80, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 38);
            this.label1.TabIndex = 34;
            this.label1.Text = "Purchases:";
            // 
            // lblPurhcases
            // 
            this.lblPurhcases.AutoSize = true;
            this.lblPurhcases.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurhcases.ForeColor = System.Drawing.Color.White;
            this.lblPurhcases.Location = new System.Drawing.Point(240, 384);
            this.lblPurhcases.Name = "lblPurhcases";
            this.lblPurhcases.Size = new System.Drawing.Size(146, 38);
            this.lblPurhcases.TabIndex = 35;
            this.lblPurhcases.Text = "Purchases";
            // 
            // Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 760);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dash";
            this.Text = "Dash";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelo;
        private System.Windows.Forms.Label labelc;
        private System.Windows.Forms.Label lblLastest;
        private System.Windows.Forms.Label lblOldest;
        private System.Windows.Forms.Label lblCheapest;
        private System.Windows.Forms.Label lblExpensive;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label lblPurhcases;
        private System.Windows.Forms.Label label1;
    }
}