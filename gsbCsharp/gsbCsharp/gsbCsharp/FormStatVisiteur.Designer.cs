namespace gsbCsharp
{
    partial class FormStatVisiteur
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStat2 = new System.Windows.Forms.Label();
            this.lblStat3 = new System.Windows.Forms.Label();
            this.lblStat4 = new System.Windows.Forms.Label();
            this.lblStatUtilisateur = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblStat2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStat3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStat4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 127);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1469, 485);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de visites par mois";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(418, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Temps total passé par jour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 322);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(369, 39);
            this.label7.TabIndex = 6;
            this.label7.Text = "Temps d\'attente moyen";
            // 
            // lblStat2
            // 
            this.lblStat2.AutoSize = true;
            this.lblStat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat2.Location = new System.Drawing.Point(1032, 0);
            this.lblStat2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStat2.Name = "lblStat2";
            this.lblStat2.Size = new System.Drawing.Size(36, 39);
            this.lblStat2.TabIndex = 3;
            this.lblStat2.Text = "0";
            // 
            // lblStat3
            // 
            this.lblStat3.AutoSize = true;
            this.lblStat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat3.Location = new System.Drawing.Point(1032, 161);
            this.lblStat3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStat3.Name = "lblStat3";
            this.lblStat3.Size = new System.Drawing.Size(36, 39);
            this.lblStat3.TabIndex = 5;
            this.lblStat3.Text = "0";
            // 
            // lblStat4
            // 
            this.lblStat4.AutoSize = true;
            this.lblStat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat4.Location = new System.Drawing.Point(1032, 322);
            this.lblStat4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStat4.Name = "lblStat4";
            this.lblStat4.Size = new System.Drawing.Size(36, 39);
            this.lblStat4.TabIndex = 7;
            this.lblStat4.Text = "0";
            // 
            // lblStatUtilisateur
            // 
            this.lblStatUtilisateur.AutoSize = true;
            this.lblStatUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatUtilisateur.Location = new System.Drawing.Point(39, 24);
            this.lblStatUtilisateur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatUtilisateur.Name = "lblStatUtilisateur";
            this.lblStatUtilisateur.Size = new System.Drawing.Size(148, 36);
            this.lblStatUtilisateur.TabIndex = 2;
            this.lblStatUtilisateur.Text = "Utilisateur";
            // 
            // FormStatVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 665);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblStatUtilisateur);
            this.Name = "FormStatVisiteur";
            this.Text = "FormStatVisiteur";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStat2;
        private System.Windows.Forms.Label lblStat3;
        private System.Windows.Forms.Label lblStat4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatUtilisateur;
    }
}