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
            this.textBoxCPCabinet.Location = new System.Drawing.Point(527, 136);
            this.textBoxCPCabinet.Name = "textBoxCPCabinet";
            this.textBoxCPCabinet.Size = new System.Drawing.Size(253, 22);
            this.textBoxCPCabinet.TabIndex = 13;
            // 
            // textBoxVilleCabinet
            // 
            this.textBoxVilleCabinet.Location = new System.Drawing.Point(527, 96);
            this.textBoxVilleCabinet.Name = "textBoxVilleCabinet";
            this.textBoxVilleCabinet.Size = new System.Drawing.Size(253, 22);
            this.textBoxVilleCabinet.TabIndex = 12;
            // 
            // textBoxRueCabinet
            // 
            this.textBoxRueCabinet.Location = new System.Drawing.Point(527, 56);
            this.textBoxRueCabinet.Name = "textBoxRueCabinet";
            this.textBoxRueCabinet.Size = new System.Drawing.Size(253, 22);
            this.textBoxRueCabinet.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "CP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ville";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "rue";
            // 
            // btnEditCabinet
            // 
            this.btnEditCabinet.Location = new System.Drawing.Point(500, 202);
            this.btnEditCabinet.Name = "btnEditCabinet";
            this.btnEditCabinet.Size = new System.Drawing.Size(75, 23);
            this.btnEditCabinet.TabIndex = 7;
            this.btnEditCabinet.Text = "Editer";
            this.btnEditCabinet.UseVisualStyleBackColor = true;
            this.btnEditCabinet.Click += new System.EventHandler(this.btnEditCabinet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sélectionner un Cabinet : ";
            // 
            // comboBoxCabinet
            // 
            this.comboBoxCabinet.FormattingEnabled = true;
            this.comboBoxCabinet.Location = new System.Drawing.Point(27, 90);
            this.comboBoxCabinet.Name = "comboBoxCabinet";
            this.comboBoxCabinet.Size = new System.Drawing.Size(369, 24);
            this.comboBoxCabinet.TabIndex = 14;
            this.comboBoxCabinet.SelectedIndexChanged += new System.EventHandler(this.comboBoxCabinet_SelectedIndexChanged);
            // 
            // FormListeCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 363);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCabinet);
            this.Controls.Add(this.textBoxCPCabinet);
            this.Controls.Add(this.textBoxVilleCabinet);
            this.Controls.Add(this.textBoxRueCabinet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditCabinet);
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