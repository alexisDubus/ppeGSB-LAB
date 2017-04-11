namespace gsbCsharp
{
    partial class FormCreateCabinet
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
            this.btnCreateCabinet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRueCabinet = new System.Windows.Forms.TextBox();
            this.textBoxVilleCabinet = new System.Windows.Forms.TextBox();
            this.textBoxCPCabinet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateCabinet
            // 
            this.btnCreateCabinet.Location = new System.Drawing.Point(196, 234);
            this.btnCreateCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateCabinet.Name = "btnCreateCabinet";
            this.btnCreateCabinet.Size = new System.Drawing.Size(56, 19);
            this.btnCreateCabinet.TabIndex = 0;
            this.btnCreateCabinet.Text = "Ajouter";
            this.btnCreateCabinet.UseVisualStyleBackColor = true;
            this.btnCreateCabinet.Click += new System.EventHandler(this.btnCreateCabinet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "rue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ville";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CP";
            // 
            // textBoxRueCabinet
            // 
            this.textBoxRueCabinet.Location = new System.Drawing.Point(196, 82);
            this.textBoxRueCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRueCabinet.Name = "textBoxRueCabinet";
            this.textBoxRueCabinet.Size = new System.Drawing.Size(211, 20);
            this.textBoxRueCabinet.TabIndex = 4;
            // 
            // textBoxVilleCabinet
            // 
            this.textBoxVilleCabinet.Location = new System.Drawing.Point(196, 132);
            this.textBoxVilleCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVilleCabinet.Name = "textBoxVilleCabinet";
            this.textBoxVilleCabinet.Size = new System.Drawing.Size(211, 20);
            this.textBoxVilleCabinet.TabIndex = 5;
            // 
            // textBoxCPCabinet
            // 
            this.textBoxCPCabinet.Location = new System.Drawing.Point(196, 185);
            this.textBoxCPCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCPCabinet.Name = "textBoxCPCabinet";
            this.textBoxCPCabinet.Size = new System.Drawing.Size(211, 20);
            this.textBoxCPCabinet.TabIndex = 6;
            // 
            // FormCreateCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(497, 338);
            this.Controls.Add(this.textBoxCPCabinet);
            this.Controls.Add(this.textBoxVilleCabinet);
            this.Controls.Add(this.textBoxRueCabinet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateCabinet);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCreateCabinet";
            this.Text = "GSB : création d\'un cabinet";
            this.Load += new System.EventHandler(this.FormCreateCabinet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCabinet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRueCabinet;
        private System.Windows.Forms.TextBox textBoxVilleCabinet;
        private System.Windows.Forms.TextBox textBoxCPCabinet;
    }
}