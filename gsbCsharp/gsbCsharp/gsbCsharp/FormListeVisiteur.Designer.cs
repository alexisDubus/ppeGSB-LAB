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
            this.textBoxNombreVisiteur = new System.Windows.Forms.TextBox();
            this.labelNombreVisiteur = new System.Windows.Forms.Label();
            this.dataGridViewVisiteur = new System.Windows.Forms.DataGridView();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombreVisiteur
            // 
            this.textBoxNombreVisiteur.Location = new System.Drawing.Point(931, 139);
            this.textBoxNombreVisiteur.Name = "textBoxNombreVisiteur";
            this.textBoxNombreVisiteur.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombreVisiteur.TabIndex = 12;
            // 
            // labelNombreVisiteur
            // 
            this.labelNombreVisiteur.AutoSize = true;
            this.labelNombreVisiteur.Location = new System.Drawing.Point(781, 142);
            this.labelNombreVisiteur.Name = "labelNombreVisiteur";
            this.labelNombreVisiteur.Size = new System.Drawing.Size(128, 17);
            this.labelNombreVisiteur.TabIndex = 11;
            this.labelNombreVisiteur.Text = "utilisateur au total: ";
            // 
            // dataGridViewVisiteur
            // 
            this.dataGridViewVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisiteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prenom,
            this.email,
            this.nom,
            this.getlogin});
            this.dataGridViewVisiteur.Location = new System.Drawing.Point(45, 95);
            this.dataGridViewVisiteur.Name = "dataGridViewVisiteur";
            this.dataGridViewVisiteur.RowTemplate.Height = 24;
            this.dataGridViewVisiteur.Size = new System.Drawing.Size(647, 199);
            this.dataGridViewVisiteur.TabIndex = 10;
            // 
            // prenom
            // 
            this.prenom.DataPropertyName = "nom";
            this.prenom.HeaderText = "prenom";
            this.prenom.Name = "prenom";
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.Name = "nom";
            // 
            // getlogin
            // 
            this.getlogin.HeaderText = "login";
            this.getlogin.Name = "getlogin";
            // 
            // FormListeVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 503);
            this.Controls.Add(this.textBoxNombreVisiteur);
            this.Controls.Add(this.labelNombreVisiteur);
            this.Controls.Add(this.dataGridViewVisiteur);
            this.Name = "FormListeVisiteur";
            this.Text = "FormListeVisiteur";
            this.Load += new System.EventHandler(this.FormListeVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombreVisiteur;
        private System.Windows.Forms.Label labelNombreVisiteur;
        private System.Windows.Forms.DataGridView dataGridViewVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn getlogin;
    }
}