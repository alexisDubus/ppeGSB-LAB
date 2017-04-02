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
            this.label7 = new System.Windows.Forms.Label();
            this.dataTimeArrivee = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxMinArrivee = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxHeureArrivee = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxMinDepart = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxHeureDepart = new System.Windows.Forms.TextBox();
            this.dateTimeDepart = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateMedecin
            // 
            this.btnCreateMedecin.Location = new System.Drawing.Point(68, 349);
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
            this.dateTimeViste.Location = new System.Drawing.Point(176, 96);
            this.dateTimeViste.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeViste.Name = "dateTimeViste";
            this.dateTimeViste.Size = new System.Drawing.Size(232, 20);
            this.dateTimeViste.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Date du rendez-vous";
            // 
            // comboBoxMedecin
            // 
            this.comboBoxMedecin.FormattingEnabled = true;
            this.comboBoxMedecin.Location = new System.Drawing.Point(176, 287);
            this.comboBoxMedecin.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMedecin.Name = "comboBoxMedecin";
            this.comboBoxMedecin.Size = new System.Drawing.Size(232, 21);
            this.comboBoxMedecin.TabIndex = 25;
            this.comboBoxMedecin.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedecin_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Médecin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxVisiteur
            // 
            this.comboBoxVisiteur.FormattingEnabled = true;
            this.comboBoxVisiteur.Location = new System.Drawing.Point(176, 314);
            this.comboBoxVisiteur.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxVisiteur.Name = "comboBoxVisiteur";
            this.comboBoxVisiteur.Size = new System.Drawing.Size(232, 21);
            this.comboBoxVisiteur.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Visiteur";
            // 
            // txtBoxHeure
            // 
            this.txtBoxHeure.Location = new System.Drawing.Point(176, 126);
            this.txtBoxHeure.Name = "txtBoxHeure";
            this.txtBoxHeure.Size = new System.Drawing.Size(61, 20);
            this.txtBoxHeure.TabIndex = 29;
            this.txtBoxHeure.TextChanged += new System.EventHandler(this.txtBoxHeure_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Heure du rendez-vous";
            // 
            // txtBoxMin
            // 
            this.txtBoxMin.Location = new System.Drawing.Point(262, 126);
            this.txtBoxMin.Name = "txtBoxMin";
            this.txtBoxMin.Size = new System.Drawing.Size(61, 20);
            this.txtBoxMin.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Date d\'arrivée";
            // 
            // dataTimeArrivee
            // 
            this.dataTimeArrivee.Location = new System.Drawing.Point(176, 158);
            this.dataTimeArrivee.Margin = new System.Windows.Forms.Padding(2);
            this.dataTimeArrivee.Name = "dataTimeArrivee";
            this.dataTimeArrivee.Size = new System.Drawing.Size(232, 20);
            this.dataTimeArrivee.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "h";
            // 
            // txtBoxMinArrivee
            // 
            this.txtBoxMinArrivee.Location = new System.Drawing.Point(262, 196);
            this.txtBoxMinArrivee.Name = "txtBoxMinArrivee";
            this.txtBoxMinArrivee.Size = new System.Drawing.Size(61, 20);
            this.txtBoxMinArrivee.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Heure d\'arrivée";
            // 
            // txtBoxHeureArrivee
            // 
            this.txtBoxHeureArrivee.Location = new System.Drawing.Point(176, 196);
            this.txtBoxHeureArrivee.Name = "txtBoxHeureArrivee";
            this.txtBoxHeureArrivee.Size = new System.Drawing.Size(61, 20);
            this.txtBoxHeureArrivee.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "min";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "h";
            // 
            // txtBoxMinDepart
            // 
            this.txtBoxMinDepart.Location = new System.Drawing.Point(262, 259);
            this.txtBoxMinDepart.Name = "txtBoxMinDepart";
            this.txtBoxMinDepart.Size = new System.Drawing.Size(61, 20);
            this.txtBoxMinDepart.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Heure de départ";
            // 
            // txtBoxHeureDepart
            // 
            this.txtBoxHeureDepart.Location = new System.Drawing.Point(176, 259);
            this.txtBoxHeureDepart.Name = "txtBoxHeureDepart";
            this.txtBoxHeureDepart.Size = new System.Drawing.Size(61, 20);
            this.txtBoxHeureDepart.TabIndex = 43;
            // 
            // dateTimeDepart
            // 
            this.dateTimeDepart.Location = new System.Drawing.Point(176, 221);
            this.dateTimeDepart.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeDepart.Name = "dateTimeDepart";
            this.dateTimeDepart.Size = new System.Drawing.Size(232, 20);
            this.dateTimeDepart.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(65, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Date de départ";
            // 
            // FormCreateVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 553);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBoxMinDepart);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBoxHeureDepart);
            this.Controls.Add(this.dateTimeDepart);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxMinArrivee);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxHeureArrivee);
            this.Controls.Add(this.dataTimeArrivee);
            this.Controls.Add(this.label7);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dataTimeArrivee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxMinArrivee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxHeureArrivee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxMinDepart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxHeureDepart;
        private System.Windows.Forms.DateTimePicker dateTimeDepart;
        private System.Windows.Forms.Label label14;
    }
}