namespace gsbCsharp
{
    partial class FormStatistiques
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
            this.lblStatUtilisateur = new System.Windows.Forms.Label();
            this.tableStats = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // lblStatUtilisateur
            // 
            this.lblStatUtilisateur.AutoSize = true;
            this.lblStatUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatUtilisateur.Location = new System.Drawing.Point(22, 22);
            this.lblStatUtilisateur.Name = "lblStatUtilisateur";
            this.lblStatUtilisateur.Size = new System.Drawing.Size(108, 25);
            this.lblStatUtilisateur.TabIndex = 0;
            this.lblStatUtilisateur.Text = "Utilisateur";
            // 
            // tableStats
            // 
            this.tableStats.ColumnCount = 2;
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStats.Location = new System.Drawing.Point(27, 70);
            this.tableStats.Name = "tableStats";
            this.tableStats.RowCount = 4;
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableStats.Size = new System.Drawing.Size(613, 297);
            this.tableStats.TabIndex = 1;
            this.tableStats.Paint += new System.Windows.Forms.PaintEventHandler(this.tableStats_Paint);
            // 
            // FormStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 407);
            this.Controls.Add(this.tableStats);
            this.Controls.Add(this.lblStatUtilisateur);
            this.Name = "FormStatistiques";
            this.Text = "FormStatistiques";
            this.Load += new System.EventHandler(this.FormStatistiques_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatUtilisateur;
        private System.Windows.Forms.TableLayoutPanel tableStats;
    }
}