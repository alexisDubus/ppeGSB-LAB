namespace gsbCsharp
{
    partial class FormCreateVisite
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
            this.btnCreateMedecin = new System.Windows.Forms.Button();
            this.dateTimeViste = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMedecin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxVisiteur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxHeure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateMedecin
            // 
            this.btnCreateMedecin.Location = new System.Drawing.Point(68, 241);
            this.btnCreateMedecin.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateMedecin.Name = "btnCreateMedecin";
            this.btnCreateMedecin.Size = new System.Drawing.Size(56, 20);
            this.btnCreateMedecin.TabIndex = 22;
            this.btnCreateMedecin.Text = "Ajouter";
            this.btnCreateMedecin.UseVisualStyleBackColor = true;
            this.btnCreateMedecin.Click += new System.EventHandler(this.btnCreateMedecin_Click);
            // 
            // dateTimeViste
            // 
            this.dateTimeViste.Location = new System.Drawing.Point(176, 117);
            this.dateTimeViste.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeViste.Name = "dateTimeViste";
            this.dateTimeViste.Size = new System.Drawing.Size(232, 20);
            this.dateTimeViste.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Date du rendez-vous";
            // 
            // comboBoxMedecin
            // 
            this.comboBoxMedecin.FormattingEnabled = true;
            this.comboBoxMedecin.Location = new System.Drawing.Point(176, 179);
            this.comboBoxMedecin.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMedecin.Name = "comboBoxMedecin";
            this.comboBoxMedecin.Size = new System.Drawing.Size(232, 21);
            this.comboBoxMedecin.TabIndex = 25;
            this.comboBoxMedecin.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedecin_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Médecin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxVisiteur
            // 
            this.comboBoxVisiteur.FormattingEnabled = true;
            this.comboBoxVisiteur.Location = new System.Drawing.Point(176, 206);
            this.comboBoxVisiteur.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxVisiteur.Name = "comboBoxVisiteur";
            this.comboBoxVisiteur.Size = new System.Drawing.Size(232, 21);
            this.comboBoxVisiteur.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Visiteur";
            // 
            // txtBoxHeure
            // 
            this.txtBoxHeure.Location = new System.Drawing.Point(176, 147);
            this.txtBoxHeure.Name = "txtBoxHeure";
            this.txtBoxHeure.Size = new System.Drawing.Size(61, 20);
            this.txtBoxHeure.TabIndex = 29;
            this.txtBoxHeure.TextChanged += new System.EventHandler(this.txtBoxHeure_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Heure du rendez-vous";
            // 
            // txtBoxMin
            // 
            this.txtBoxMin.Location = new System.Drawing.Point(262, 147);
            this.txtBoxMin.Name = "txtBoxMin";
            this.txtBoxMin.Size = new System.Drawing.Size(61, 20);
            this.txtBoxMin.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "min";
            // 
            // FormCreateVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxHeure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxVisiteur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMedecin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeViste);
            this.Controls.Add(this.btnCreateMedecin);
            this.Name = "FormCreateVisite";
            this.Text = "FormCreateVisite";
            this.Load += new System.EventHandler(this.FormCreateVisite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateMedecin;
        private System.Windows.Forms.DateTimePicker dateTimeViste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMedecin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxVisiteur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxHeure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}