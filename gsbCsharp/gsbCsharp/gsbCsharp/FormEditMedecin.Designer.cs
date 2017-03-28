namespace gsbCsharp
{
    partial class FormEditMedecin
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
            this.comboBoxMedecinVisiteur = new System.Windows.Forms.ComboBox();
            this.comboBoxMedecinCabinet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrenomMedecin = new System.Windows.Forms.TextBox();
            this.textBoxNomMedecin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditMedecin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMedecinVisiteur
            // 
            this.comboBoxMedecinVisiteur.FormattingEnabled = true;
            this.comboBoxMedecinVisiteur.Location = new System.Drawing.Point(190, 143);
            this.comboBoxMedecinVisiteur.Name = "comboBoxMedecinVisiteur";
            this.comboBoxMedecinVisiteur.Size = new System.Drawing.Size(308, 24);
            this.comboBoxMedecinVisiteur.TabIndex = 21;
            // 
            // comboBoxMedecinCabinet
            // 
            this.comboBoxMedecinCabinet.FormattingEnabled = true;
            this.comboBoxMedecinCabinet.Location = new System.Drawing.Point(190, 182);
            this.comboBoxMedecinCabinet.Name = "comboBoxMedecinCabinet";
            this.comboBoxMedecinCabinet.Size = new System.Drawing.Size(308, 24);
            this.comboBoxMedecinCabinet.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "cabinet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "visiteur";
            // 
            // textBoxPrenomMedecin
            // 
            this.textBoxPrenomMedecin.Location = new System.Drawing.Point(190, 95);
            this.textBoxPrenomMedecin.Name = "textBoxPrenomMedecin";
            this.textBoxPrenomMedecin.Size = new System.Drawing.Size(308, 22);
            this.textBoxPrenomMedecin.TabIndex = 17;
            // 
            // textBoxNomMedecin
            // 
            this.textBoxNomMedecin.Location = new System.Drawing.Point(190, 54);
            this.textBoxNomMedecin.Name = "textBoxNomMedecin";
            this.textBoxNomMedecin.Size = new System.Drawing.Size(308, 22);
            this.textBoxNomMedecin.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "nom";
            // 
            // btnEditMedecin
            // 
            this.btnEditMedecin.Location = new System.Drawing.Point(190, 233);
            this.btnEditMedecin.Name = "btnEditMedecin";
            this.btnEditMedecin.Size = new System.Drawing.Size(75, 25);
            this.btnEditMedecin.TabIndex = 13;
            this.btnEditMedecin.Text = "Editer";
            this.btnEditMedecin.UseVisualStyleBackColor = true;
            this.btnEditMedecin.Click += new System.EventHandler(this.btnEditMedecin_Click);
            // 
            // FormEditMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 442);
            this.Controls.Add(this.comboBoxMedecinVisiteur);
            this.Controls.Add(this.comboBoxMedecinCabinet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrenomMedecin);
            this.Controls.Add(this.textBoxNomMedecin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditMedecin);
            this.Name = "FormEditMedecin";
            this.Text = "Modifier un Médecin";
            this.Load += new System.EventHandler(this.FormEditMedecin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMedecinVisiteur;
        private System.Windows.Forms.ComboBox comboBoxMedecinCabinet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrenomMedecin;
        private System.Windows.Forms.TextBox textBoxNomMedecin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditMedecin;
    }
}