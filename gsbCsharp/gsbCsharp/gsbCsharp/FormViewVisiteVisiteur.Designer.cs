namespace gsbCsharp
{
    partial class FormViewVisiteVisiteur
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
            this.btnEditVisite = new System.Windows.Forms.Button();
            this.comboBoxVisite = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxMinDepart = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxHeureDepart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxMinArrivee = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxHeureArrivee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxHeure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMedecin = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimeViste = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnEditVisite
            // 
            this.btnEditVisite.Location = new System.Drawing.Point(53, 250);
            this.btnEditVisite.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditVisite.Name = "btnEditVisite";
            this.btnEditVisite.Size = new System.Drawing.Size(56, 20);
            this.btnEditVisite.TabIndex = 13;
            this.btnEditVisite.Text = "Editer";
            this.btnEditVisite.UseVisualStyleBackColor = true;
            this.btnEditVisite.Click += new System.EventHandler(this.btnEditViste_Click_1);
            // 
            // comboBoxVisite
            // 
            this.comboBoxVisite.FormattingEnabled = true;
            this.comboBoxVisite.Location = new System.Drawing.Point(161, 36);
            this.comboBoxVisite.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxVisite.Name = "comboBoxVisite";
            this.comboBoxVisite.Size = new System.Drawing.Size(232, 21);
            this.comboBoxVisite.TabIndex = 24;
            this.comboBoxVisite.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisite_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "visite";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(161, 250);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(78, 20);
            this.btnSupprimer.TabIndex = 25;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "min";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "h";
            // 
            // txtBoxMinDepart
            // 
            this.txtBoxMinDepart.Location = new System.Drawing.Point(247, 164);
            this.txtBoxMinDepart.Name = "txtBoxMinDepart";
            this.txtBoxMinDepart.Size = new System.Drawing.Size(61, 20);
            this.txtBoxMinDepart.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Heure de départ";
            // 
            // txtBoxHeureDepart
            // 
            this.txtBoxHeureDepart.Location = new System.Drawing.Point(161, 164);
            this.txtBoxHeureDepart.Name = "txtBoxHeureDepart";
            this.txtBoxHeureDepart.Size = new System.Drawing.Size(61, 20);
            this.txtBoxHeureDepart.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "h";
            // 
            // txtBoxMinArrivee
            // 
            this.txtBoxMinArrivee.Location = new System.Drawing.Point(247, 132);
            this.txtBoxMinArrivee.Name = "txtBoxMinArrivee";
            this.txtBoxMinArrivee.Size = new System.Drawing.Size(61, 20);
            this.txtBoxMinArrivee.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Heure d\'arrivée";
            // 
            // txtBoxHeureArrivee
            // 
            this.txtBoxHeureArrivee.Location = new System.Drawing.Point(161, 132);
            this.txtBoxHeureArrivee.Name = "txtBoxHeureArrivee";
            this.txtBoxHeureArrivee.Size = new System.Drawing.Size(61, 20);
            this.txtBoxHeureArrivee.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "h";
            // 
            // txtBoxMin
            // 
            this.txtBoxMin.Location = new System.Drawing.Point(247, 103);
            this.txtBoxMin.Name = "txtBoxMin";
            this.txtBoxMin.Size = new System.Drawing.Size(61, 20);
            this.txtBoxMin.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Heure du rendez-vous";
            // 
            // txtBoxHeure
            // 
            this.txtBoxHeure.Location = new System.Drawing.Point(161, 103);
            this.txtBoxHeure.Name = "txtBoxHeure";
            this.txtBoxHeure.Size = new System.Drawing.Size(61, 20);
            this.txtBoxHeure.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Médecin";
            // 
            // comboBoxMedecin
            // 
            this.comboBoxMedecin.FormattingEnabled = true;
            this.comboBoxMedecin.Location = new System.Drawing.Point(161, 192);
            this.comboBoxMedecin.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMedecin.Name = "comboBoxMedecin";
            this.comboBoxMedecin.Size = new System.Drawing.Size(232, 21);
            this.comboBoxMedecin.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Date du rendez-vous";
            // 
            // dateTimeViste
            // 
            this.dateTimeViste.Location = new System.Drawing.Point(161, 73);
            this.dateTimeViste.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeViste.Name = "dateTimeViste";
            this.dateTimeViste.Size = new System.Drawing.Size(232, 20);
            this.dateTimeViste.TabIndex = 44;
            // 
            // FormViewVisiteVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 357);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBoxMinDepart);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBoxHeureDepart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxMinArrivee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxHeureArrivee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxHeure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMedecin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimeViste);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.comboBoxVisite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditVisite);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormViewVisiteVisiteur";
            this.Text = "Editer les visites d\'un visiteur";
            this.Load += new System.EventHandler(this.FormViewVisiteVisiteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditVisite;
        private System.Windows.Forms.ComboBox comboBoxVisite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxMinDepart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxHeureDepart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxMinArrivee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxHeureArrivee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxHeure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMedecin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimeViste;
    }
}