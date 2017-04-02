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
            this.txtBoxHeure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxMinArrivee = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxHeureArrivee = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxMinDepart = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxHeureDepart = new System.Windows.Forms.TextBox();
            this.checkBoxRDV = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCreateMedecin
            // 
            this.btnCreateMedecin.Location = new System.Drawing.Point(51, 328);
            this.btnCreateMedecin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateMedecin.Name = "btnCreateMedecin";
            this.btnCreateMedecin.Size = new System.Drawing.Size(75, 25);
            this.btnCreateMedecin.TabIndex = 22;
            this.btnCreateMedecin.Text = "Ajouter";
            this.btnCreateMedecin.UseVisualStyleBackColor = true;
            this.btnCreateMedecin.Click += new System.EventHandler(this.btnCreateMedecin_Click);
            // 
            // dateTimeViste
            // 
            this.dateTimeViste.Location = new System.Drawing.Point(195, 50);
            this.dateTimeViste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeViste.Name = "dateTimeViste";
            this.dateTimeViste.Size = new System.Drawing.Size(308, 22);
            this.dateTimeViste.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Date de visite";
            // 
            // comboBoxMedecin
            // 
            this.comboBoxMedecin.FormattingEnabled = true;
            this.comboBoxMedecin.Location = new System.Drawing.Point(195, 196);
            this.comboBoxMedecin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMedecin.Name = "comboBoxMedecin";
            this.comboBoxMedecin.Size = new System.Drawing.Size(308, 24);
            this.comboBoxMedecin.TabIndex = 25;
            this.comboBoxMedecin.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedecin_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Médecin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoxHeure
            // 
            this.txtBoxHeure.Location = new System.Drawing.Point(195, 87);
            this.txtBoxHeure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxHeure.Name = "txtBoxHeure";
            this.txtBoxHeure.Size = new System.Drawing.Size(80, 22);
            this.txtBoxHeure.TabIndex = 29;
            this.txtBoxHeure.TextChanged += new System.EventHandler(this.txtBoxHeure_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Heure de visite";
            // 
            // txtBoxMin
            // 
            this.txtBoxMin.Location = new System.Drawing.Point(309, 87);
            this.txtBoxMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxMin.Name = "txtBoxMin";
            this.txtBoxMin.Size = new System.Drawing.Size(80, 22);
            this.txtBoxMin.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "h";
            // 
            // txtBoxMinArrivee
            // 
            this.txtBoxMinArrivee.Location = new System.Drawing.Point(309, 123);
            this.txtBoxMinArrivee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxMinArrivee.Name = "txtBoxMinArrivee";
            this.txtBoxMinArrivee.Size = new System.Drawing.Size(80, 22);
            this.txtBoxMinArrivee.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Heure d\'arrivée";
            // 
            // txtBoxHeureArrivee
            // 
            this.txtBoxHeureArrivee.Location = new System.Drawing.Point(195, 123);
            this.txtBoxHeureArrivee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxHeureArrivee.Name = "txtBoxHeureArrivee";
            this.txtBoxHeureArrivee.Size = new System.Drawing.Size(80, 22);
            this.txtBoxHeureArrivee.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 166);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "min";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 166);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "h";
            // 
            // txtBoxMinDepart
            // 
            this.txtBoxMinDepart.Location = new System.Drawing.Point(309, 162);
            this.txtBoxMinDepart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxMinDepart.Name = "txtBoxMinDepart";
            this.txtBoxMinDepart.Size = new System.Drawing.Size(80, 22);
            this.txtBoxMinDepart.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 162);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 17);
            this.label12.TabIndex = 40;
            this.label12.Text = "Heure de départ";
            // 
            // txtBoxHeureDepart
            // 
            this.txtBoxHeureDepart.Location = new System.Drawing.Point(195, 162);
            this.txtBoxHeureDepart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxHeureDepart.Name = "txtBoxHeureDepart";
            this.txtBoxHeureDepart.Size = new System.Drawing.Size(80, 22);
            this.txtBoxHeureDepart.TabIndex = 39;
            // 
            // checkBoxRDV
            // 
            this.checkBoxRDV.AutoSize = true;
            this.checkBoxRDV.Location = new System.Drawing.Point(51, 285);
            this.checkBoxRDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxRDV.Name = "checkBoxRDV";
            this.checkBoxRDV.Size = new System.Drawing.Size(135, 21);
            this.checkBoxRDV.TabIndex = 44;
            this.checkBoxRDV.Text = "Sur rendez-vous";
            this.checkBoxRDV.UseVisualStyleBackColor = true;
            // 
            // FormCreateVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 681);
            this.Controls.Add(this.checkBoxRDV);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMedecin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeViste);
            this.Controls.Add(this.btnCreateMedecin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtBoxHeure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxMinArrivee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxHeureArrivee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxMinDepart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxHeureDepart;
        private System.Windows.Forms.CheckBox checkBoxRDV;
    }
}