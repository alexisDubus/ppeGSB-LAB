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
            this.components = new System.ComponentModel.Container();
            this.textBoxNombreVisiteur = new System.Windows.Forms.TextBox();
            this.labelNombreVisiteur = new System.Windows.Forms.Label();
            this.dataGridViewVisiteur = new System.Windows.Forms.DataGridView();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxVisiteur = new System.Windows.Forms.ListBox();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxVisiteur = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombreVisiteur
            // 
            this.textBoxNombreVisiteur.Location = new System.Drawing.Point(168, 391);
            this.textBoxNombreVisiteur.Name = "textBoxNombreVisiteur";
            this.textBoxNombreVisiteur.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombreVisiteur.TabIndex = 12;
            // 
            // labelNombreVisiteur
            // 
            this.labelNombreVisiteur.AutoSize = true;
            this.labelNombreVisiteur.Location = new System.Drawing.Point(18, 394);
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
            this.dataGridViewVisiteur.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVisiteur.Name = "dataGridViewVisiteur";
            this.dataGridViewVisiteur.RowTemplate.Height = 24;
            this.dataGridViewVisiteur.Size = new System.Drawing.Size(313, 331);
            this.dataGridViewVisiteur.TabIndex = 10;
            this.dataGridViewVisiteur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVisiteur_CellContentClick);
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
            // listBoxVisiteur
            // 
            this.listBoxVisiteur.FormattingEnabled = true;
            this.listBoxVisiteur.ItemHeight = 16;
            this.listBoxVisiteur.Items.AddRange(new object[] {
            "nom, prenom"});
            this.listBoxVisiteur.Location = new System.Drawing.Point(595, 77);
            this.listBoxVisiteur.Name = "listBoxVisiteur";
            this.listBoxVisiteur.Size = new System.Drawing.Size(101, 36);
            this.listBoxVisiteur.TabIndex = 14;
            this.listBoxVisiteur.SelectedIndexChanged += new System.EventHandler(this.listBoxVisiteur_SelectedIndexChanged);
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataSource = typeof(Metier.Utilisateur);
            // 
            // comboBoxVisiteur
            // 
            this.comboBoxVisiteur.FormattingEnabled = true;
            this.comboBoxVisiteur.Location = new System.Drawing.Point(595, 12);
            this.comboBoxVisiteur.Name = "comboBoxVisiteur";
            this.comboBoxVisiteur.Size = new System.Drawing.Size(212, 24);
            this.comboBoxVisiteur.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(331, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(258, 331);
            this.dataGridView1.TabIndex = 16;
            // 
            // FormListeVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxVisiteur);
            this.Controls.Add(this.listBoxVisiteur);
            this.Controls.Add(this.textBoxNombreVisiteur);
            this.Controls.Add(this.labelNombreVisiteur);
            this.Controls.Add(this.dataGridViewVisiteur);
            this.Name = "FormListeVisiteur";
            this.Text = "FormListeVisiteur";
            this.Load += new System.EventHandler(this.FormListeVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ListBox listBoxVisiteur;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private System.Windows.Forms.ComboBox comboBoxVisiteur;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}