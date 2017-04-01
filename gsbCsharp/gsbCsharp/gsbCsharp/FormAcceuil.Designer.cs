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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.VisiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeVisiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMedecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cabinetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterCabinetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteVisiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisiteurToolStripMenuItem,
            this.medecinToolStripMenuItem,
            this.cabinetToolStripMenuItem,
            this.visiteVisiteurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1195, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // VisiteurToolStripMenuItem
            // 
            this.VisiteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeVisiteurToolStripMenuItem});
            this.VisiteurToolStripMenuItem.Name = "VisiteurToolStripMenuItem";
            this.VisiteurToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.VisiteurToolStripMenuItem.Text = "Visiteur";
            // 
            // listeVisiteurToolStripMenuItem
            // 
            this.listeVisiteurToolStripMenuItem.Name = "listeVisiteurToolStripMenuItem";
            this.listeVisiteurToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.listeVisiteurToolStripMenuItem.Text = "Liste";
            this.listeVisiteurToolStripMenuItem.Click += new System.EventHandler(this.listeVisiteurToolStripMenuItem_Click);
            // 
            // medecinToolStripMenuItem
            // 
            this.medecinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterMedecinToolStripMenuItem,
            this.listeToolStripMenuItem});
            this.medecinToolStripMenuItem.Name = "medecinToolStripMenuItem";
            this.medecinToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.medecinToolStripMenuItem.Text = "Medecins";
            // 
            // ajouterMedecinToolStripMenuItem
            // 
            this.ajouterMedecinToolStripMenuItem.Name = "ajouterMedecinToolStripMenuItem";
            this.ajouterMedecinToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.ajouterMedecinToolStripMenuItem.Text = "Ajouter";
            this.ajouterMedecinToolStripMenuItem.Click += new System.EventHandler(this.ajouterMedecinToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // cabinetToolStripMenuItem
            // 
            this.cabinetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterCabinetToolStripMenuItem});
            this.cabinetToolStripMenuItem.Name = "cabinetToolStripMenuItem";
            this.cabinetToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.cabinetToolStripMenuItem.Text = "Cabinet";
            // 
            // ajouterCabinetToolStripMenuItem
            // 
            this.ajouterCabinetToolStripMenuItem.Name = "ajouterCabinetToolStripMenuItem";
            this.ajouterCabinetToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.ajouterCabinetToolStripMenuItem.Text = "Ajouter";
            this.ajouterCabinetToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // visiteVisiteurToolStripMenuItem
            // 
            this.visiteVisiteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeToolStripMenuItem1});
            this.visiteVisiteurToolStripMenuItem.Name = "visiteVisiteurToolStripMenuItem";
            this.visiteVisiteurToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.visiteVisiteurToolStripMenuItem.Text = "Visite";
            this.visiteVisiteurToolStripMenuItem.Click += new System.EventHandler(this.visiteVisiteurToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem1
            // 
            this.listeToolStripMenuItem1.Name = "listeToolStripMenuItem1";
            this.listeToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.listeToolStripMenuItem1.Text = "Liste";
            this.listeToolStripMenuItem1.Click += new System.EventHandler(this.listeToolStripMenuItem1_Click);
            // 
            // FormAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gsbCsharp.Properties.Resources.DNA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 506);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAcceuil";
            this.Text = "GSB : acceuil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAcceuil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem VisiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeVisiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterMedecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cabinetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterCabinetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteVisiteurToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem1;
    }
}

