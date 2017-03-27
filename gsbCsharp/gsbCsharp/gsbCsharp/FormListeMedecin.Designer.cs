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
            this.buttonModifMedicin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomMedecin = new System.Windows.Forms.TextBox();
            this.textBoxPrenomMedecin = new System.Windows.Forms.TextBox();
            this.textBoxMedecinCabinet = new System.Windows.Forms.TextBox();
            this.textBoxMedecinVisiteur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxMedecin
            // 
            this.comboBoxMedecin.FormattingEnabled = true;
            this.comboBoxMedecin.Location = new System.Drawing.Point(28, 43);
            this.comboBoxMedecin.Name = "comboBoxMedecin";
            this.comboBoxMedecin.Size = new System.Drawing.Size(211, 24);
            this.comboBoxMedecin.TabIndex = 0;
            this.comboBoxMedecin.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedecin_SelectedIndexChanged_1);
            // 
            // btnEditMedecin
            // 
            this.btnEditMedecin.Location = new System.Drawing.Point(28, 138);
            this.btnEditMedecin.Name = "btnEditMedecin";
            this.btnEditMedecin.Size = new System.Drawing.Size(75, 23);
            this.btnEditMedecin.TabIndex = 1;
            this.btnEditMedecin.Text = "Editer";
            this.btnEditMedecin.UseVisualStyleBackColor = true;
            this.btnEditMedecin.Click += new System.EventHandler(this.btnEditMedecin_Click);
            // 
            // buttonModifMedicin
            // 
            this.buttonModifMedicin.Location = new System.Drawing.Point(598, 228);
            this.buttonModifMedicin.Name = "buttonModifMedicin";
            this.buttonModifMedicin.Size = new System.Drawing.Size(186, 23);
            this.buttonModifMedicin.TabIndex = 2;
            this.buttonModifMedicin.Text = "Modifier le Medecin";
            this.buttonModifMedicin.UseVisualStyleBackColor = true;
            this.buttonModifMedicin.Visible = false;
            this.buttonModifMedicin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "nom";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "prenom";
            this.label2.Visible = false;
            // 
            // textBoxNomMedecin
            // 
            this.textBoxNomMedecin.Location = new System.Drawing.Point(684, 49);
            this.textBoxNomMedecin.Name = "textBoxNomMedecin";
            this.textBoxNomMedecin.Size = new System.Drawing.Size(100, 22);
            this.textBoxNomMedecin.TabIndex = 5;
            this.textBoxNomMedecin.Visible = false;
            // 
            // textBoxPrenomMedecin
            // 
            this.textBoxPrenomMedecin.Location = new System.Drawing.Point(684, 90);
            this.textBoxPrenomMedecin.Name = "textBoxPrenomMedecin";
            this.textBoxPrenomMedecin.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrenomMedecin.TabIndex = 6;
            this.textBoxPrenomMedecin.Visible = false;
            // 
            // textBoxMedecinCabinet
            // 
            this.textBoxMedecinCabinet.Location = new System.Drawing.Point(684, 179);
            this.textBoxMedecinCabinet.Name = "textBoxMedecinCabinet";
            this.textBoxMedecinCabinet.Size = new System.Drawing.Size(100, 22);
            this.textBoxMedecinCabinet.TabIndex = 10;
            this.textBoxMedecinCabinet.Visible = false;
            // 
            // textBoxMedecinVisiteur
            // 
            this.textBoxMedecinVisiteur.Location = new System.Drawing.Point(684, 138);
            this.textBoxMedecinVisiteur.Name = "textBoxMedecinVisiteur";
            this.textBoxMedecinVisiteur.Size = new System.Drawing.Size(100, 22);
            this.textBoxMedecinVisiteur.TabIndex = 9;
            this.textBoxMedecinVisiteur.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "cabinet";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "visiteur";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormListeMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 434);
            this.Controls.Add(this.textBoxMedecinCabinet);
            this.Controls.Add(this.textBoxMedecinVisiteur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrenomMedecin);
            this.Controls.Add(this.textBoxNomMedecin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonModifMedicin);
            this.Controls.Add(this.btnEditMedecin);
            this.Controls.Add(this.comboBoxMedecin);
            this.Name = "FormListeMedecin";
            this.Text = "FormListeMedecin";
            this.Load += new System.EventHandler(this.FormListeMedecin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMedecin;
        private System.Windows.Forms.Button btnEditMedecin;
        private System.Windows.Forms.Button buttonModifMedicin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomMedecin;
        private System.Windows.Forms.TextBox textBoxPrenomMedecin;
        private System.Windows.Forms.TextBox textBoxMedecinCabinet;
        private System.Windows.Forms.TextBox textBoxMedecinVisiteur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}