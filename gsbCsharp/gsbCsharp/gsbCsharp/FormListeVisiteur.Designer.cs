namespace gsbCsharp
{
    partial class FormListeVisiteur
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
            this.comboBoxVisiteur = new System.Windows.Forms.ComboBox();
            this.btnMedecin = new System.Windows.Forms.Button();
            this.btnStat = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxListeDepartement = new System.Windows.Forms.ComboBox();
            this.comboBoxListeMedecin = new System.Windows.Forms.ComboBox();
            this.btnShowMedecin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxVisiteur
            // 
            this.comboBoxVisiteur.FormattingEnabled = true;
            this.comboBoxVisiteur.Location = new System.Drawing.Point(56, 53);
            this.comboBoxVisiteur.Name = "comboBoxVisiteur";
            this.comboBoxVisiteur.Size = new System.Drawing.Size(402, 24);
            this.comboBoxVisiteur.TabIndex = 1;
            this.comboBoxVisiteur.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisiteur_SelectedIndexChanged_2);
            // 
            // btnMedecin
            // 
            this.btnMedecin.Location = new System.Drawing.Point(56, 136);
            this.btnMedecin.Name = "btnMedecin";
            this.btnMedecin.Size = new System.Drawing.Size(186, 23);
            this.btnMedecin.TabIndex = 2;
            this.btnMedecin.Text = "Voir les Médecins";
            this.btnMedecin.UseVisualStyleBackColor = true;
            this.btnMedecin.Click += new System.EventHandler(this.btnMedecin_Click);
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(313, 136);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(145, 23);
            this.btnStat.TabIndex = 3;
            this.btnStat.Text = "Voir les Statistiques";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(762, 136);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(182, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxListeDepartement
            // 
            this.comboBoxListeDepartement.FormattingEnabled = true;
            this.comboBoxListeDepartement.Location = new System.Drawing.Point(762, 53);
            this.comboBoxListeDepartement.Name = "comboBoxListeDepartement";
            this.comboBoxListeDepartement.Size = new System.Drawing.Size(182, 24);
            this.comboBoxListeDepartement.TabIndex = 5;
            // 
            // comboBoxListeMedecin
            // 
            this.comboBoxListeMedecin.FormattingEnabled = true;
            this.comboBoxListeMedecin.Location = new System.Drawing.Point(56, 284);
            this.comboBoxListeMedecin.Name = "comboBoxListeMedecin";
            this.comboBoxListeMedecin.Size = new System.Drawing.Size(186, 24);
            this.comboBoxListeMedecin.TabIndex = 6;
            this.comboBoxListeMedecin.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeMedecin_SelectedIndexChanged);
            // 
            // btnShowMedecin
            // 
            this.btnShowMedecin.Location = new System.Drawing.Point(56, 352);
            this.btnShowMedecin.Name = "btnShowMedecin";
            this.btnShowMedecin.Size = new System.Drawing.Size(186, 23);
            this.btnShowMedecin.TabIndex = 7;
            this.btnShowMedecin.Text = "Voir ce médecin";
            this.btnShowMedecin.UseVisualStyleBackColor = true;
            // 
            // FormListeVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 503);
            this.Controls.Add(this.btnShowMedecin);
            this.Controls.Add(this.comboBoxListeMedecin);
            this.Controls.Add(this.comboBoxListeDepartement);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.btnMedecin);
            this.Controls.Add(this.comboBoxVisiteur);
            this.Name = "FormListeVisiteur";
            this.Text = "FormListeVisiteur";
            this.Load += new System.EventHandler(this.FormListeVisiteur_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxVisiteur;
        private System.Windows.Forms.Button btnMedecin;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxListeDepartement;
        private System.Windows.Forms.ComboBox comboBoxListeMedecin;
        private System.Windows.Forms.Button btnShowMedecin;
    }
}