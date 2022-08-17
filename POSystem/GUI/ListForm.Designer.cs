
namespace POSystem.GUI
{
    partial class ListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            this.btnRetour = new System.Windows.Forms.Button();
            this.listViewListPO = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxListeDepartement = new System.Windows.Forms.ComboBox();
            this.labelSortby = new System.Windows.Forms.Label();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(437, 11);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(88, 35);
            this.btnRetour.TabIndex = 53;
            this.btnRetour.Text = "&Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // listViewListPO
            // 
            this.listViewListPO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewListPO.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewListPO.GridLines = true;
            this.listViewListPO.HideSelection = false;
            this.listViewListPO.Location = new System.Drawing.Point(12, 55);
            this.listViewListPO.Name = "listViewListPO";
            this.listViewListPO.Size = new System.Drawing.Size(1786, 861);
            this.listViewListPO.TabIndex = 51;
            this.listViewListPO.UseCompatibleStateImageBehavior = false;
            this.listViewListPO.View = System.Windows.Forms.View.Details;
            this.listViewListPO.SelectedIndexChanged += new System.EventHandler(this.listViewListPO_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numéro de PO";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fournisseur";
            this.columnHeader2.Width = 178;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Demandé par";
            this.columnHeader3.Width = 220;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No de Soumission";
            this.columnHeader4.Width = 228;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Commentaire";
            this.columnHeader5.Width = 331;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Statut";
            this.columnHeader6.Width = 125;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Approuvé et Signé par";
            this.columnHeader7.Width = 314;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Date de Création";
            this.columnHeader8.Width = 127;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Dernière Mise à Jour";
            this.columnHeader9.Width = 149;
            // 
            // comboBoxListeDepartement
            // 
            this.comboBoxListeDepartement.DisplayMember = "departement";
            this.comboBoxListeDepartement.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxListeDepartement.FormattingEnabled = true;
            this.comboBoxListeDepartement.Items.AddRange(new object[] {
            "Liste complète ascendante",
            "Liste complète descendante",
            "Fournisseur",
            "Demandé par",
            "Statut",
            "Approuvé par"});
            this.comboBoxListeDepartement.Location = new System.Drawing.Point(635, 17);
            this.comboBoxListeDepartement.Name = "comboBoxListeDepartement";
            this.comboBoxListeDepartement.Size = new System.Drawing.Size(231, 25);
            this.comboBoxListeDepartement.TabIndex = 26;
            this.comboBoxListeDepartement.Text = "Liste PO";
            this.comboBoxListeDepartement.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeDepartement_SelectedIndexChanged);
            // 
            // labelSortby
            // 
            this.labelSortby.AutoSize = true;
            this.labelSortby.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortby.Location = new System.Drawing.Point(575, 21);
            this.labelSortby.Name = "labelSortby";
            this.labelSortby.Size = new System.Drawing.Size(54, 17);
            this.labelSortby.TabIndex = 54;
            this.labelSortby.Text = "Sort by";
            // 
            // btnRecherche
            // 
            this.btnRecherche.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Location = new System.Drawing.Point(1107, 11);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(90, 35);
            this.btnRecherche.TabIndex = 49;
            this.btnRecherche.Text = "&Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.AccessibleDescription = "";
            this.textBoxRecherche.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecherche.Location = new System.Drawing.Point(1203, 17);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(174, 25);
            this.textBoxRecherche.TabIndex = 50;
            this.textBoxRecherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRecherche_KeyDown);
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.DisplayMember = "departement";
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Fournisseur",
            "Demandé par",
            "Soumission",
            "Statut",
            "Approuvé par"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(906, 18);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(177, 25);
            this.comboBoxSearchBy.TabIndex = 27;
            this.comboBoxSearchBy.Text = "Sélectionner une option";
            this.comboBoxSearchBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchBy_SelectedIndexChanged);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 931);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.textBoxRecherche);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.labelSortby);
            this.Controls.Add(this.comboBoxListeDepartement);
            this.Controls.Add(this.listViewListPO);
            this.Controls.Add(this.btnRetour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1826, 970);
            this.MinimumSize = new System.Drawing.Size(1826, 970);
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste complète de PO";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ListView listViewListPO;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ComboBox comboBoxListeDepartement;
        private System.Windows.Forms.Label labelSortby;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
    }
}