namespace gsbCsharp
{
    partial class FormListeMedecin
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
            this.comboBoxMedecin = new System.Windows.Forms.ComboBox();
            this.btnEditMedecin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomMedecin = new System.Windows.Forms.TextBox();
            this.textBoxPrenomMedecin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMedecinCabinet = new System.Windows.Forms.ComboBox();
            this.comboBoxMedecinVisiteur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxMedecin
            // 
            this.comboBoxMedecin.FormattingEnabled = true;
            this.comboBoxMedecin.Location = new System.Drawing.Point(28, 70);
            this.comboBoxMedecin.Name = "comboBoxMedecin";
            this.comboBoxMedecin.Size = new System.Drawing.Size(211, 24);
            this.comboBoxMedecin.TabIndex = 0;
            this.comboBoxMedecin.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedecin_SelectedIndexChanged_1);
            // 
            // btnEditMedecin
            // 
            this.btnEditMedecin.Location = new System.Drawing.Point(473, 256);
            this.btnEditMedecin.Name = "btnEditMedecin";
            this.btnEditMedecin.Size = new System.Drawing.Size(75, 25);
            this.btnEditMedecin.TabIndex = 1;
            this.btnEditMedecin.Text = "Editer";
            this.btnEditMedecin.UseVisualStyleBackColor = true;
            this.btnEditMedecin.Click += new System.EventHandler(this.btnEditMedecin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "prenom";
            // 
            // textBoxNomMedecin
            // 
            this.textBoxNomMedecin.Location = new System.Drawing.Point(473, 77);
            this.textBoxNomMedecin.Name = "textBoxNomMedecin";
            this.textBoxNomMedecin.Size = new System.Drawing.Size(308, 22);
            this.textBoxNomMedecin.TabIndex = 5;
            // 
            // textBoxPrenomMedecin
            // 
            this.textBoxPrenomMedecin.Location = new System.Drawing.Point(473, 118);
            this.textBoxPrenomMedecin.Name = "textBoxPrenomMedecin";
            this.textBoxPrenomMedecin.Size = new System.Drawing.Size(308, 22);
            this.textBoxPrenomMedecin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "cabinet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "visiteur";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxMedecinCabinet
            // 
            this.comboBoxMedecinCabinet.FormattingEnabled = true;
            this.comboBoxMedecinCabinet.Location = new System.Drawing.Point(473, 205);
            this.comboBoxMedecinCabinet.Name = "comboBoxMedecinCabinet";
            this.comboBoxMedecinCabinet.Size = new System.Drawing.Size(308, 24);
            this.comboBoxMedecinCabinet.TabIndex = 11;
            // 
            // comboBoxMedecinVisiteur
            // 
            this.comboBoxMedecinVisiteur.FormattingEnabled = true;
            this.comboBoxMedecinVisiteur.Location = new System.Drawing.Point(473, 166);
            this.comboBoxMedecinVisiteur.Name = "comboBoxMedecinVisiteur";
            this.comboBoxMedecinVisiteur.Size = new System.Drawing.Size(308, 24);
            this.comboBoxMedecinVisiteur.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sélectionner un médecin : ";
            // 
            // FormListeMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 434);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMedecinVisiteur);
            this.Controls.Add(this.comboBoxMedecinCabinet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrenomMedecin);
            this.Controls.Add(this.textBoxNomMedecin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditMedecin);
            this.Controls.Add(this.comboBoxMedecin);
            this.Name = "FormListeMedecin";
            this.Text = "Liste des médecins";
            this.Load += new System.EventHandler(this.FormListeMedecin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMedecin;
        private System.Windows.Forms.Button btnEditMedecin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomMedecin;
        private System.Windows.Forms.TextBox textBoxPrenomMedecin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMedecinCabinet;
        private System.Windows.Forms.ComboBox comboBoxMedecinVisiteur;
        private System.Windows.Forms.Label label5;
    }
}