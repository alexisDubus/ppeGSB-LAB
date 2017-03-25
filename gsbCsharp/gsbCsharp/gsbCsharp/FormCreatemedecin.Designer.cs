namespace gsbCsharp
{
    partial class FormCreateMedecin
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
            this.textBoxNomMedecin = new System.Windows.Forms.TextBox();
            this.textBoxPrenomMedecin = new System.Windows.Forms.TextBox();
            this.btnAjouteMedecin = new System.Windows.Forms.Button();
            this.listBoxMedecin = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // textBoxNomMedecin
            // 
            this.textBoxNomMedecin.Location = new System.Drawing.Point(258, 94);
            this.textBoxNomMedecin.Name = "textBoxNomMedecin";
            this.textBoxNomMedecin.Size = new System.Drawing.Size(100, 22);
            this.textBoxNomMedecin.TabIndex = 2;
            // 
            // textBoxPrenomMedecin
            // 
            this.textBoxPrenomMedecin.Location = new System.Drawing.Point(258, 149);
            this.textBoxPrenomMedecin.Name = "textBoxPrenomMedecin";
            this.textBoxPrenomMedecin.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrenomMedecin.TabIndex = 3;
            // 
            // btnAjouteMedecin
            // 
            this.btnAjouteMedecin.Location = new System.Drawing.Point(258, 336);
            this.btnAjouteMedecin.Name = "btnAjouteMedecin";
            this.btnAjouteMedecin.Size = new System.Drawing.Size(75, 23);
            this.btnAjouteMedecin.TabIndex = 4;
            this.btnAjouteMedecin.Text = "Ajouter";
            this.btnAjouteMedecin.UseVisualStyleBackColor = true;
            // 
            // listBoxMedecin
            // 
            this.listBoxMedecin.FormattingEnabled = true;
            this.listBoxMedecin.ItemHeight = 16;
            this.listBoxMedecin.Location = new System.Drawing.Point(258, 249);
            this.listBoxMedecin.Name = "listBoxMedecin";
            this.listBoxMedecin.Size = new System.Drawing.Size(120, 52);
            this.listBoxMedecin.TabIndex = 5;
            // 
            // FormCreateMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 402);
            this.Controls.Add(this.listBoxMedecin);
            this.Controls.Add(this.btnAjouteMedecin);
            this.Controls.Add(this.textBoxPrenomMedecin);
            this.Controls.Add(this.textBoxNomMedecin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateMedecin";
            this.Text = "GSB : création d\'un médecin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCreateMedecin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomMedecin;
        private System.Windows.Forms.TextBox textBoxPrenomMedecin;
        private System.Windows.Forms.Button btnAjouteMedecin;
        private System.Windows.Forms.ListBox listBoxMedecin;
    }
}