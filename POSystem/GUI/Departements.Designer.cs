namespace POSystem.GUI
{
    partial class Departements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departements));
            this.listViewDepartementD = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRetour = new System.Windows.Forms.Button();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.textBoxApprobation = new System.Windows.Forms.TextBox();
            this.textBoxDepartement = new System.Windows.Forms.TextBox();
            this.labelDepartements = new System.Windows.Forms.Label();
            this.labelApprobations = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNewApprovation = new System.Windows.Forms.Button();
            this.comboBoxListeDepartement = new System.Windows.Forms.ComboBox();
            this.deptdeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new POSystem.DataSet1();
            this.departementstestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDept = new POSystem.DataSetDept();
            this.departementstestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radioButtonSansLimite = new System.Windows.Forms.RadioButton();
            this.radioButtonCAD = new System.Windows.Forms.RadioButton();
            this.departements_testTableAdapter = new POSystem.DataSetDeptTableAdapters.departements_testTableAdapter();
            this.btnListe = new System.Windows.Forms.Button();
            this.dept_deptTableAdapter = new POSystem.DataSet1TableAdapters.Dept_deptTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.deptdeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementstestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementstestBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewDepartementD
            // 
            this.listViewDepartementD.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewDepartementD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewDepartementD.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDepartementD.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listViewDepartementD.FullRowSelect = true;
            this.listViewDepartementD.GridLines = true;
            this.listViewDepartementD.HideSelection = false;
            this.listViewDepartementD.Location = new System.Drawing.Point(16, 185);
            this.listViewDepartementD.MultiSelect = false;
            this.listViewDepartementD.Name = "listViewDepartementD";
            this.listViewDepartementD.Size = new System.Drawing.Size(622, 360);
            this.listViewDepartementD.TabIndex = 4;
            this.listViewDepartementD.UseCompatibleStateImageBehavior = false;
            this.listViewDepartementD.View = System.Windows.Forms.View.Details;
            this.listViewDepartementD.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewDepartementD_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Départements";
            this.columnHeader1.Width = 181;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Approbations requises et signées";
            this.columnHeader2.Width = 311;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Montant";
            this.columnHeader3.Width = 176;
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(16, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(88, 41);
            this.btnRetour.TabIndex = 27;
            this.btnRetour.Text = "&Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontant.Location = new System.Drawing.Point(121, 143);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(232, 25);
            this.textBoxMontant.TabIndex = 31;
            // 
            // textBoxApprobation
            // 
            this.textBoxApprobation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApprobation.Location = new System.Drawing.Point(121, 105);
            this.textBoxApprobation.Name = "textBoxApprobation";
            this.textBoxApprobation.Size = new System.Drawing.Size(232, 25);
            this.textBoxApprobation.TabIndex = 30;
            // 
            // textBoxDepartement
            // 
            this.textBoxDepartement.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDepartement.Location = new System.Drawing.Point(121, 66);
            this.textBoxDepartement.Name = "textBoxDepartement";
            this.textBoxDepartement.Size = new System.Drawing.Size(232, 25);
            this.textBoxDepartement.TabIndex = 29;
            // 
            // labelDepartements
            // 
            this.labelDepartements.AutoSize = true;
            this.labelDepartements.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartements.Location = new System.Drawing.Point(14, 69);
            this.labelDepartements.Name = "labelDepartements";
            this.labelDepartements.Size = new System.Drawing.Size(101, 17);
            this.labelDepartements.TabIndex = 32;
            this.labelDepartements.Text = "Départements";
            // 
            // labelApprobations
            // 
            this.labelApprobations.AutoSize = true;
            this.labelApprobations.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApprobations.Location = new System.Drawing.Point(14, 108);
            this.labelApprobations.Name = "labelApprobations";
            this.labelApprobations.Size = new System.Drawing.Size(93, 17);
            this.labelApprobations.TabIndex = 33;
            this.labelApprobations.Text = "Approbations";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontant.Location = new System.Drawing.Point(14, 146);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(59, 17);
            this.labelMontant.TabIndex = 34;
            this.labelMontant.Text = "Montant";
            // 
            // btnEffacer
            // 
            this.btnEffacer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacer.Location = new System.Drawing.Point(512, 72);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(126, 41);
            this.btnEffacer.TabIndex = 42;
            this.btnEffacer.Text = "Effacer C&hamps";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(369, 72);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(126, 41);
            this.btnModifier.TabIndex = 41;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnNewApprovation
            // 
            this.btnNewApprovation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewApprovation.Location = new System.Drawing.Point(369, 122);
            this.btnNewApprovation.Name = "btnNewApprovation";
            this.btnNewApprovation.Size = new System.Drawing.Size(126, 41);
            this.btnNewApprovation.TabIndex = 44;
            this.btnNewApprovation.Text = "Sauvegardez";
            this.btnNewApprovation.UseVisualStyleBackColor = true;
            this.btnNewApprovation.Click += new System.EventHandler(this.btnNewApprovation_Click);
            // 
            // comboBoxListeDepartement
            // 
            this.comboBoxListeDepartement.DataSource = this.deptdeptBindingSource;
            this.comboBoxListeDepartement.DisplayMember = "departement";
            this.comboBoxListeDepartement.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxListeDepartement.FormattingEnabled = true;
            this.comboBoxListeDepartement.Location = new System.Drawing.Point(399, 12);
            this.comboBoxListeDepartement.Name = "comboBoxListeDepartement";
            this.comboBoxListeDepartement.Size = new System.Drawing.Size(239, 25);
            this.comboBoxListeDepartement.TabIndex = 45;
            this.comboBoxListeDepartement.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeDepartement_SelectedIndexChanged);
            // 
            // deptdeptBindingSource
            // 
            this.deptdeptBindingSource.DataMember = "Dept_dept";
            this.deptdeptBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departementstestBindingSource
            // 
            this.departementstestBindingSource.DataMember = "departements_test";
            this.departementstestBindingSource.DataSource = this.dataSetDept;
            // 
            // dataSetDept
            // 
            this.dataSetDept.DataSetName = "DataSetDept";
            this.dataSetDept.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departementstestBindingSource1
            // 
            this.departementstestBindingSource1.DataMember = "departements_test";
            this.departementstestBindingSource1.DataSource = this.dataSetDept;
            // 
            // radioButtonSansLimite
            // 
            this.radioButtonSansLimite.AutoSize = true;
            this.radioButtonSansLimite.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSansLimite.Location = new System.Drawing.Point(222, 22);
            this.radioButtonSansLimite.Name = "radioButtonSansLimite";
            this.radioButtonSansLimite.Size = new System.Drawing.Size(103, 21);
            this.radioButtonSansLimite.TabIndex = 47;
            this.radioButtonSansLimite.Text = "Sans Limite";
            this.radioButtonSansLimite.UseVisualStyleBackColor = true;
            this.radioButtonSansLimite.CheckedChanged += new System.EventHandler(this.radioButtonSansLimite_CheckedChanged);
            // 
            // radioButtonCAD
            // 
            this.radioButtonCAD.AutoSize = true;
            this.radioButtonCAD.Checked = true;
            this.radioButtonCAD.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCAD.Location = new System.Drawing.Point(145, 22);
            this.radioButtonCAD.Name = "radioButtonCAD";
            this.radioButtonCAD.Size = new System.Drawing.Size(65, 21);
            this.radioButtonCAD.TabIndex = 46;
            this.radioButtonCAD.TabStop = true;
            this.radioButtonCAD.Text = "CAD$";
            this.radioButtonCAD.UseVisualStyleBackColor = true;
            this.radioButtonCAD.CheckedChanged += new System.EventHandler(this.radioButtonCAD_CheckedChanged);
            // 
            // departements_testTableAdapter
            // 
            this.departements_testTableAdapter.ClearBeforeFill = true;
            // 
            // btnListe
            // 
            this.btnListe.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListe.Location = new System.Drawing.Point(512, 122);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(126, 41);
            this.btnListe.TabIndex = 48;
            this.btnListe.Text = "Liste";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // dept_deptTableAdapter
            // 
            this.dept_deptTableAdapter.ClearBeforeFill = true;
            // 
            // Departements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(653, 560);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.radioButtonSansLimite);
            this.Controls.Add(this.radioButtonCAD);
            this.Controls.Add(this.comboBoxListeDepartement);
            this.Controls.Add(this.btnNewApprovation);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelApprobations);
            this.Controls.Add(this.labelDepartements);
            this.Controls.Add(this.textBoxMontant);
            this.Controls.Add(this.textBoxApprobation);
            this.Controls.Add(this.textBoxDepartement);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.listViewDepartementD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(669, 599);
            this.MinimumSize = new System.Drawing.Size(669, 39);
            this.Name = "Departements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departements";
            this.Load += new System.EventHandler(this.Departements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deptdeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementstestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementstestBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDepartementD;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.TextBox textBoxMontant;
        private System.Windows.Forms.TextBox textBoxApprobation;
        private System.Windows.Forms.TextBox textBoxDepartement;
        private System.Windows.Forms.Label labelDepartements;
        private System.Windows.Forms.Label labelApprobations;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnNewApprovation;
        private System.Windows.Forms.ComboBox comboBoxListeDepartement;
        private System.Windows.Forms.RadioButton radioButtonSansLimite;
        private System.Windows.Forms.RadioButton radioButtonCAD;
        private DataSetDept dataSetDept;
        private System.Windows.Forms.BindingSource departementstestBindingSource;
        private DataSetDeptTableAdapters.departements_testTableAdapter departements_testTableAdapter;
        private System.Windows.Forms.BindingSource departementstestBindingSource1;
        private System.Windows.Forms.Button btnListe;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource deptdeptBindingSource;
        private DataSet1TableAdapters.Dept_deptTableAdapter dept_deptTableAdapter;
    }
}