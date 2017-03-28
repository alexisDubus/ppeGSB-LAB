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
            this.comboBoxMedecin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditViste = new System.Windows.Forms.Button();
            this.dateTimePickerCreation = new System.Windows.Forms.DateTimePicker();
            this.comboBoxVisite = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxMedecin
            // 
            this.comboBoxMedecin.FormattingEnabled = true;
            this.comboBoxMedecin.Location = new System.Drawing.Point(215, 233);
            this.comboBoxMedecin.Name = "comboBoxMedecin";
            this.comboBoxMedecin.Size = new System.Drawing.Size(308, 24);
            this.comboBoxMedecin.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Medecin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "date de création";
            // 
            // btnEditViste
            // 
            this.btnEditViste.Location = new System.Drawing.Point(215, 299);
            this.btnEditViste.Name = "btnEditViste";
            this.btnEditViste.Size = new System.Drawing.Size(75, 25);
            this.btnEditViste.TabIndex = 13;
            this.btnEditViste.Text = "Editer";
            this.btnEditViste.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerCreation
            // 
            this.dateTimePickerCreation.Location = new System.Drawing.Point(215, 155);
            this.dateTimePickerCreation.Name = "dateTimePickerCreation";
            this.dateTimePickerCreation.Size = new System.Drawing.Size(308, 22);
            this.dateTimePickerCreation.TabIndex = 22;
            // 
            // comboBoxVisite
            // 
            this.comboBoxVisite.FormattingEnabled = true;
            this.comboBoxVisite.Location = new System.Drawing.Point(215, 44);
            this.comboBoxVisite.Name = "comboBoxVisite";
            this.comboBoxVisite.Size = new System.Drawing.Size(308, 24);
            this.comboBoxVisite.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "visite";
            // 
            // FormViewVisiteVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 439);
            this.Controls.Add(this.comboBoxVisite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerCreation);
            this.Controls.Add(this.comboBoxMedecin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditViste);
            this.Name = "FormViewVisiteVisiteur";
            this.Text = "Editer les visites d\'un visiteur";
            this.Load += new System.EventHandler(this.FormViewVisiteVisiteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxMedecin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditViste;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreation;
        private System.Windows.Forms.ComboBox comboBoxVisite;
        private System.Windows.Forms.Label label2;
    }
}