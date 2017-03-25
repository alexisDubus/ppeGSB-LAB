namespace gsbCsharp
{
    partial class FormAcceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.VisiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creationVisiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeVisiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewVisiteur = new System.Windows.Forms.DataGridView();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelNombreVisiteur = new System.Windows.Forms.Label();
            this.textBoxNombreVisiteur = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisiteurToolStripMenuItem,
            this.medecinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1194, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // VisiteurToolStripMenuItem
            // 
            this.VisiteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creationVisiteurToolStripMenuItem,
            this.listeVisiteurToolStripMenuItem});
            this.VisiteurToolStripMenuItem.Name = "VisiteurToolStripMenuItem";
            this.VisiteurToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.VisiteurToolStripMenuItem.Text = "Visiteur";
            // 
            // creationVisiteurToolStripMenuItem
            // 
            this.creationVisiteurToolStripMenuItem.Name = "creationVisiteurToolStripMenuItem";
            this.creationVisiteurToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.creationVisiteurToolStripMenuItem.Text = "Création";
            this.creationVisiteurToolStripMenuItem.Click += new System.EventHandler(this.creationVisiteurToolStripMenuItem_Click);
            // 
            // listeVisiteurToolStripMenuItem
            // 
            this.listeVisiteurToolStripMenuItem.Name = "listeVisiteurToolStripMenuItem";
            this.listeVisiteurToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.listeVisiteurToolStripMenuItem.Text = "Liste";
            this.listeVisiteurToolStripMenuItem.Click += new System.EventHandler(this.listeVisiteurToolStripMenuItem_Click);
            // 
            // medecinToolStripMenuItem
            // 
            this.medecinToolStripMenuItem.Name = "medecinToolStripMenuItem";
            this.medecinToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.medecinToolStripMenuItem.Text = "Voir les forfaits";
            // 
            // dataGridViewVisiteur
            // 
            this.dataGridViewVisiteur.AutoGenerateColumns = false;
            this.dataGridViewVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisiteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prenom,
            this.email,
            this.nom,
            this.getlogin});
            this.dataGridViewVisiteur.DataSource = this.visiteBindingSource;
            this.dataGridViewVisiteur.Location = new System.Drawing.Point(39, 31);
            this.dataGridViewVisiteur.Name = "dataGridViewVisiteur";
            this.dataGridViewVisiteur.RowTemplate.Height = 24;
            this.dataGridViewVisiteur.Size = new System.Drawing.Size(681, 454);
            this.dataGridViewVisiteur.TabIndex = 6;
            this.dataGridViewVisiteur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVisiteur_CellContentClick_2);
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
            // visiteBindingSource
            // 
            this.visiteBindingSource.DataSource = typeof(Metier.Visite);
            this.visiteBindingSource.CurrentChanged += new System.EventHandler(this.visiteBindingSource_CurrentChanged);
            // 
            // labelNombreVisiteur
            // 
            this.labelNombreVisiteur.AutoSize = true;
            this.labelNombreVisiteur.Location = new System.Drawing.Point(775, 78);
            this.labelNombreVisiteur.Name = "labelNombreVisiteur";
            this.labelNombreVisiteur.Size = new System.Drawing.Size(128, 17);
            this.labelNombreVisiteur.TabIndex = 8;
            this.labelNombreVisiteur.Text = "utilisateur au total: ";
            this.labelNombreVisiteur.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNombreVisiteur
            // 
            this.textBoxNombreVisiteur.Location = new System.Drawing.Point(967, 78);
            this.textBoxNombreVisiteur.Name = "textBoxNombreVisiteur";
            this.textBoxNombreVisiteur.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombreVisiteur.TabIndex = 9;
            // 
            // FormAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 506);
            this.Controls.Add(this.textBoxNombreVisiteur);
            this.Controls.Add(this.labelNombreVisiteur);
            this.Controls.Add(this.dataGridViewVisiteur);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormAcceuil";
            this.Text = "GSB : acceuil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAcceuil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem VisiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creationVisiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeVisiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medecinToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewVisiteur;
        private System.Windows.Forms.BindingSource visiteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn getlogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.Label labelNombreVisiteur;
        private System.Windows.Forms.TextBox textBoxNombreVisiteur;
    }
}

