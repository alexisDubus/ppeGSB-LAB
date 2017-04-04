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
            this.btnStat = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowMedecin = new System.Windows.Forms.Button();
            this.dataGridViewMedecin = new System.Windows.Forms.DataGridView();
            this.textBoxDepartements = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.Label();
            this.btnSearchByNom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxVisiteur
            // 
            this.comboBoxVisiteur.FormattingEnabled = true;
            this.comboBoxVisiteur.Location = new System.Drawing.Point(56, 53);
            this.comboBoxVisiteur.Name = "comboBoxVisiteur";
            this.comboBoxVisiteur.Size = new System.Drawing.Size(434, 24);
            this.comboBoxVisiteur.TabIndex = 1;
            this.comboBoxVisiteur.Text = "Cliquer pour choisir un visiteur";
            this.comboBoxVisiteur.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisiteur_SelectedIndexChanged_2);
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(496, 54);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(178, 24);
            this.btnStat.TabIndex = 3;
            this.btnStat.Text = "Voir les Statistiques";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(941, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(203, 24);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Rechercher par CP";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowMedecin
            // 
            this.btnShowMedecin.Location = new System.Drawing.Point(56, 484);
            this.btnShowMedecin.Name = "btnShowMedecin";
            this.btnShowMedecin.Size = new System.Drawing.Size(170, 27);
            this.btnShowMedecin.TabIndex = 7;
            this.btnShowMedecin.Text = "Voir ce médecin";
            this.btnShowMedecin.UseVisualStyleBackColor = true;
            this.btnShowMedecin.Click += new System.EventHandler(this.btnShowMedecin_Click);
            // 
            // dataGridViewMedecin
            // 
            this.dataGridViewMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedecin.Location = new System.Drawing.Point(56, 138);
            this.dataGridViewMedecin.Name = "dataGridViewMedecin";
            this.dataGridViewMedecin.RowTemplate.Height = 24;
            this.dataGridViewMedecin.Size = new System.Drawing.Size(354, 283);
            this.dataGridViewMedecin.TabIndex = 8;
            // 
            // textBoxDepartements
            // 
            this.textBoxDepartements.AccessibleDescription = "";
            this.textBoxDepartements.AccessibleName = "";
            this.textBoxDepartements.Location = new System.Drawing.Point(753, 57);
            this.textBoxDepartements.Name = "textBoxDepartements";
            this.textBoxDepartements.Size = new System.Drawing.Size(182, 22);
            this.textBoxDepartements.TabIndex = 9;
            this.textBoxDepartements.Tag = "";
            // 
            // textBoxNom
            // 
            this.textBoxNom.AccessibleDescription = "";
            this.textBoxNom.AccessibleName = "";
            this.textBoxNom.Location = new System.Drawing.Point(753, 102);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(182, 22);
            this.textBoxNom.TabIndex = 11;
            this.textBoxNom.Tag = "";
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = true;
            this.textBox1.Location = new System.Drawing.Point(53, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 17);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Médecins du visiteur : ";
            // 
            // btnSearchByNom
            // 
            this.btnSearchByNom.Location = new System.Drawing.Point(941, 102);
            this.btnSearchByNom.Name = "btnSearchByNom";
            this.btnSearchByNom.Size = new System.Drawing.Size(203, 24);
            this.btnSearchByNom.TabIndex = 13;
            this.btnSearchByNom.Text = "Rechercher par nom";
            this.btnSearchByNom.UseVisualStyleBackColor = true;
            this.btnSearchByNom.Click += new System.EventHandler(this.btnSearchByNom_Click);
            // 
            // FormListeVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 622);
            this.Controls.Add(this.btnSearchByNom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxDepartements);
            this.Controls.Add(this.dataGridViewMedecin);
            this.Controls.Add(this.btnShowMedecin);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.comboBoxVisiteur);
            this.Name = "FormListeVisiteur";
            this.Text = "Liste des visiteurs";
            this.Load += new System.EventHandler(this.FormListeVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedecin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxVisiteur;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowMedecin;
        private System.Windows.Forms.DataGridView dataGridViewMedecin;
        private System.Windows.Forms.TextBox textBoxDepartements;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.Button btnSearchByNom;
    }
}