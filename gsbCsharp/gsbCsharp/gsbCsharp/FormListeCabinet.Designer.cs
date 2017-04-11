namespace gsbCsharp
{
    partial class FormListeCabinet
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
            this.textBoxCPCabinet = new System.Windows.Forms.TextBox();
            this.textBoxVilleCabinet = new System.Windows.Forms.TextBox();
            this.textBoxRueCabinet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditCabinet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCabinet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxCPCabinet
            // 
            this.textBoxCPCabinet.Location = new System.Drawing.Point(395, 110);
            this.textBoxCPCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCPCabinet.Name = "textBoxCPCabinet";
            this.textBoxCPCabinet.Size = new System.Drawing.Size(191, 20);
            this.textBoxCPCabinet.TabIndex = 13;
            // 
            // textBoxVilleCabinet
            // 
            this.textBoxVilleCabinet.Location = new System.Drawing.Point(395, 78);
            this.textBoxVilleCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVilleCabinet.Name = "textBoxVilleCabinet";
            this.textBoxVilleCabinet.Size = new System.Drawing.Size(191, 20);
            this.textBoxVilleCabinet.TabIndex = 12;
            // 
            // textBoxRueCabinet
            // 
            this.textBoxRueCabinet.Location = new System.Drawing.Point(395, 46);
            this.textBoxRueCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRueCabinet.Name = "textBoxRueCabinet";
            this.textBoxRueCabinet.Size = new System.Drawing.Size(191, 20);
            this.textBoxRueCabinet.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ville";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "rue";
            // 
            // btnEditCabinet
            // 
            this.btnEditCabinet.Location = new System.Drawing.Point(375, 164);
            this.btnEditCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCabinet.Name = "btnEditCabinet";
            this.btnEditCabinet.Size = new System.Drawing.Size(56, 19);
            this.btnEditCabinet.TabIndex = 7;
            this.btnEditCabinet.Text = "Editer";
            this.btnEditCabinet.UseVisualStyleBackColor = true;
            this.btnEditCabinet.Click += new System.EventHandler(this.btnEditCabinet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sélectionner un Cabinet : ";
            // 
            // comboBoxCabinet
            // 
            this.comboBoxCabinet.FormattingEnabled = true;
            this.comboBoxCabinet.Location = new System.Drawing.Point(20, 73);
            this.comboBoxCabinet.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCabinet.Name = "comboBoxCabinet";
            this.comboBoxCabinet.Size = new System.Drawing.Size(278, 21);
            this.comboBoxCabinet.TabIndex = 14;
            this.comboBoxCabinet.SelectedIndexChanged += new System.EventHandler(this.comboBoxCabinet_SelectedIndexChanged);
            // 
            // FormListeCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 295);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCabinet);
            this.Controls.Add(this.textBoxCPCabinet);
            this.Controls.Add(this.textBoxVilleCabinet);
            this.Controls.Add(this.textBoxRueCabinet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditCabinet);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormListeCabinet";
            this.Text = "Liste des Cabinet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCPCabinet;
        private System.Windows.Forms.TextBox textBoxVilleCabinet;
        private System.Windows.Forms.TextBox textBoxRueCabinet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditCabinet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCabinet;
    }
}