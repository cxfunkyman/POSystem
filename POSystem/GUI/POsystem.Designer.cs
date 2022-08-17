namespace POSystem
{
    partial class POsystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POsystem));
            this.groupLaPresse = new System.Windows.Forms.GroupBox();
            this.deptdeptBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new POSystem.DataSet2();
            this.btnOuvrirPDF = new System.Windows.Forms.Button();
            this.btnEffacerChamps = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelChampObligatoire = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModifierApprobe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDeuxiemeAprovation = new System.Windows.Forms.Label();
            this.textBoxDeuxiemeAprovation = new System.Windows.Forms.TextBox();
            this.textBoxApprobe = new System.Windows.Forms.TextBox();
            this.groupBoxStatut = new System.Windows.Forms.GroupBox();
            this.radioButtonEnAttente = new System.Windows.Forms.RadioButton();
            this.labelStatut = new System.Windows.Forms.Label();
            this.radioPartielle = new System.Windows.Forms.RadioButton();
            this.radioComplete = new System.Windows.Forms.RadioButton();
            this.btnModifierStatut = new System.Windows.Forms.Button();
            this.radioButtonNG = new System.Windows.Forms.RadioButton();
            this.radioButtonLP = new System.Windows.Forms.RadioButton();
            this.labelDateNow = new System.Windows.Forms.Label();
            this.btnSortir = new System.Windows.Forms.Button();
            this.btnExporterversExcel = new System.Windows.Forms.Button();
            this.textBoxDernierPO = new System.Windows.Forms.TextBox();
            this.labelDernierPO = new System.Windows.Forms.Label();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.textBoxPDFDocument = new System.Windows.Forms.TextBox();
            this.textBoxComentaire = new System.Windows.Forms.TextBox();
            this.textBoxSoumission = new System.Windows.Forms.TextBox();
            this.textBoxDemandePar = new System.Windows.Forms.TextBox();
            this.textBoxFournisseur = new System.Windows.Forms.TextBox();
            this.textBoxNumeroPO = new System.Windows.Forms.TextBox();
            this.labelSoumission = new System.Windows.Forms.Label();
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.labelPDFDossier = new System.Windows.Forms.Label();
            this.labelDemandePar = new System.Windows.Forms.Label();
            this.labelFournisseur = new System.Windows.Forms.Label();
            this.labelNumeroPO = new System.Windows.Forms.Label();
            this.labelListePO = new System.Windows.Forms.Label();
            this.btnNewPO = new System.Windows.Forms.Button();
            this.btnAjouterPDF = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.groupDepartement = new System.Windows.Forms.GroupBox();
            this.comboBoxListeDepartement = new System.Windows.Forms.ComboBox();
            this.deptdeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new POSystem.DataSet1();
            this.btnListeDepartement = new System.Windows.Forms.Button();
            this.btnEfaccerDeuxieme = new System.Windows.Forms.Button();
            this.btnModifierDepartements = new System.Windows.Forms.Button();
            this.listViewDepartement = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.departementstestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDept = new POSystem.DataSetDept();
            this.departements_testTableAdapter = new POSystem.DataSetDeptTableAdapters.departements_testTableAdapter();
            this.dept_deptTableAdapter = new POSystem.DataSet1TableAdapters.Dept_deptTableAdapter();
            this.menuStripFileAdmin = new System.Windows.Forms.MenuStrip();
            this.adminStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dept_deptTableAdapter1 = new POSystem.DataSet2TableAdapters.Dept_deptTableAdapter();
            this.groupLaPresse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptdeptBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxStatut.SuspendLayout();
            this.groupDepartement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptdeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementstestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDept)).BeginInit();
            this.menuStripFileAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLaPresse
            // 
            this.groupLaPresse.Controls.Add(this.btnOuvrirPDF);
            this.groupLaPresse.Controls.Add(this.btnEffacerChamps);
            this.groupLaPresse.Controls.Add(this.label2);
            this.groupLaPresse.Controls.Add(this.label1);
            this.groupLaPresse.Controls.Add(this.labelChampObligatoire);
            this.groupLaPresse.Controls.Add(this.groupBox1);
            this.groupLaPresse.Controls.Add(this.groupBoxStatut);
            this.groupLaPresse.Controls.Add(this.radioButtonNG);
            this.groupLaPresse.Controls.Add(this.radioButtonLP);
            this.groupLaPresse.Controls.Add(this.labelDateNow);
            this.groupLaPresse.Controls.Add(this.btnSortir);
            this.groupLaPresse.Controls.Add(this.btnExporterversExcel);
            this.groupLaPresse.Controls.Add(this.textBoxDernierPO);
            this.groupLaPresse.Controls.Add(this.labelDernierPO);
            this.groupLaPresse.Controls.Add(this.textBoxRecherche);
            this.groupLaPresse.Controls.Add(this.textBoxPDFDocument);
            this.groupLaPresse.Controls.Add(this.textBoxComentaire);
            this.groupLaPresse.Controls.Add(this.textBoxSoumission);
            this.groupLaPresse.Controls.Add(this.textBoxDemandePar);
            this.groupLaPresse.Controls.Add(this.textBoxFournisseur);
            this.groupLaPresse.Controls.Add(this.textBoxNumeroPO);
            this.groupLaPresse.Controls.Add(this.labelSoumission);
            this.groupLaPresse.Controls.Add(this.labelCommentaire);
            this.groupLaPresse.Controls.Add(this.labelPDFDossier);
            this.groupLaPresse.Controls.Add(this.labelDemandePar);
            this.groupLaPresse.Controls.Add(this.labelFournisseur);
            this.groupLaPresse.Controls.Add(this.labelNumeroPO);
            this.groupLaPresse.Controls.Add(this.labelListePO);
            this.groupLaPresse.Controls.Add(this.btnNewPO);
            this.groupLaPresse.Controls.Add(this.btnAjouterPDF);
            this.groupLaPresse.Controls.Add(this.btnModifier);
            this.groupLaPresse.Controls.Add(this.btnList);
            this.groupLaPresse.Controls.Add(this.btnSupprimer);
            this.groupLaPresse.Controls.Add(this.btnRecherche);
            this.groupLaPresse.Controls.Add(this.groupDepartement);
            this.groupLaPresse.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLaPresse.Location = new System.Drawing.Point(13, 35);
            this.groupLaPresse.Name = "groupLaPresse";
            this.groupLaPresse.Size = new System.Drawing.Size(909, 947);
            this.groupLaPresse.TabIndex = 47;
            this.groupLaPresse.TabStop = false;
            this.groupLaPresse.Text = "La Presse";
            // 
            // deptdeptBindingSource1
            // 
            this.deptdeptBindingSource1.DataMember = "Dept_dept";
            this.deptdeptBindingSource1.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOuvrirPDF
            // 
            this.btnOuvrirPDF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuvrirPDF.Location = new System.Drawing.Point(764, 287);
            this.btnOuvrirPDF.Name = "btnOuvrirPDF";
            this.btnOuvrirPDF.Size = new System.Drawing.Size(126, 41);
            this.btnOuvrirPDF.TabIndex = 18;
            this.btnOuvrirPDF.Text = "&Ouvrir";
            this.btnOuvrirPDF.UseVisualStyleBackColor = true;
            this.btnOuvrirPDF.Click += new System.EventHandler(this.btnOuvrirPDF_Click);
            // 
            // btnEffacerChamps
            // 
            this.btnEffacerChamps.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacerChamps.Location = new System.Drawing.Point(630, 199);
            this.btnEffacerChamps.Name = "btnEffacerChamps";
            this.btnEffacerChamps.Size = new System.Drawing.Size(126, 41);
            this.btnEffacerChamps.TabIndex = 16;
            this.btnEffacerChamps.Text = "Effacer C&hamps";
            this.btnEffacerChamps.UseVisualStyleBackColor = true;
            this.btnEffacerChamps.Click += new System.EventHandler(this.btnEffacerChamps_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Numero PO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(365, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 14);
            this.label1.TabIndex = 41;
            this.label1.Text = "* Champ Obligatoire";
            // 
            // labelChampObligatoire
            // 
            this.labelChampObligatoire.AutoSize = true;
            this.labelChampObligatoire.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChampObligatoire.ForeColor = System.Drawing.Color.Red;
            this.labelChampObligatoire.Location = new System.Drawing.Point(365, 149);
            this.labelChampObligatoire.Name = "labelChampObligatoire";
            this.labelChampObligatoire.Size = new System.Drawing.Size(116, 14);
            this.labelChampObligatoire.TabIndex = 40;
            this.labelChampObligatoire.Text = "* Champ Obligatoire";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModifierApprobe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelDeuxiemeAprovation);
            this.groupBox1.Controls.Add(this.textBoxDeuxiemeAprovation);
            this.groupBox1.Controls.Add(this.textBoxApprobe);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 75);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // btnModifierApprobe
            // 
            this.btnModifierApprobe.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierApprobe.Location = new System.Drawing.Point(696, 22);
            this.btnModifierApprobe.Name = "btnModifierApprobe";
            this.btnModifierApprobe.Size = new System.Drawing.Size(179, 39);
            this.btnModifierApprobe.TabIndex = 25;
            this.btnModifierApprobe.Text = "Modifier A&pprobe";
            this.btnModifierApprobe.UseVisualStyleBackColor = true;
            this.btnModifierApprobe.Click += new System.EventHandler(this.btnModifierApprobe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 14);
            this.label3.TabIndex = 43;
            this.label3.Text = "* Champ Obligatoire";
            // 
            // labelDeuxiemeAprovation
            // 
            this.labelDeuxiemeAprovation.AutoSize = true;
            this.labelDeuxiemeAprovation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeuxiemeAprovation.Location = new System.Drawing.Point(347, 33);
            this.labelDeuxiemeAprovation.Name = "labelDeuxiemeAprovation";
            this.labelDeuxiemeAprovation.Size = new System.Drawing.Size(145, 17);
            this.labelDeuxiemeAprovation.TabIndex = 44;
            this.labelDeuxiemeAprovation.Text = "Deuxième Aprovation";
            // 
            // textBoxDeuxiemeAprovation
            // 
            this.textBoxDeuxiemeAprovation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeuxiemeAprovation.Location = new System.Drawing.Point(494, 29);
            this.textBoxDeuxiemeAprovation.Name = "textBoxDeuxiemeAprovation";
            this.textBoxDeuxiemeAprovation.ReadOnly = true;
            this.textBoxDeuxiemeAprovation.Size = new System.Drawing.Size(196, 25);
            this.textBoxDeuxiemeAprovation.TabIndex = 24;
            this.textBoxDeuxiemeAprovation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxApprobe
            // 
            this.textBoxApprobe.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApprobe.Location = new System.Drawing.Point(125, 29);
            this.textBoxApprobe.Name = "textBoxApprobe";
            this.textBoxApprobe.ReadOnly = true;
            this.textBoxApprobe.Size = new System.Drawing.Size(196, 25);
            this.textBoxApprobe.TabIndex = 23;
            this.textBoxApprobe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxStatut
            // 
            this.groupBoxStatut.Controls.Add(this.radioButtonEnAttente);
            this.groupBoxStatut.Controls.Add(this.labelStatut);
            this.groupBoxStatut.Controls.Add(this.radioPartielle);
            this.groupBoxStatut.Controls.Add(this.radioComplete);
            this.groupBoxStatut.Controls.Add(this.btnModifierStatut);
            this.groupBoxStatut.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStatut.Location = new System.Drawing.Point(12, 338);
            this.groupBoxStatut.Name = "groupBoxStatut";
            this.groupBoxStatut.Size = new System.Drawing.Size(885, 69);
            this.groupBoxStatut.TabIndex = 34;
            this.groupBoxStatut.TabStop = false;
            this.groupBoxStatut.Text = "Réception";
            // 
            // radioButtonEnAttente
            // 
            this.radioButtonEnAttente.AutoSize = true;
            this.radioButtonEnAttente.Checked = true;
            this.radioButtonEnAttente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEnAttente.Location = new System.Drawing.Point(222, 26);
            this.radioButtonEnAttente.Name = "radioButtonEnAttente";
            this.radioButtonEnAttente.Size = new System.Drawing.Size(92, 21);
            this.radioButtonEnAttente.TabIndex = 19;
            this.radioButtonEnAttente.TabStop = true;
            this.radioButtonEnAttente.Text = "En Attente";
            this.radioButtonEnAttente.UseVisualStyleBackColor = true;
            // 
            // labelStatut
            // 
            this.labelStatut.AutoSize = true;
            this.labelStatut.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatut.Location = new System.Drawing.Point(152, 29);
            this.labelStatut.Name = "labelStatut";
            this.labelStatut.Size = new System.Drawing.Size(46, 17);
            this.labelStatut.TabIndex = 42;
            this.labelStatut.Text = "Statut";
            // 
            // radioPartielle
            // 
            this.radioPartielle.AutoSize = true;
            this.radioPartielle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPartielle.Location = new System.Drawing.Point(350, 28);
            this.radioPartielle.Name = "radioPartielle";
            this.radioPartielle.Size = new System.Drawing.Size(78, 21);
            this.radioPartielle.TabIndex = 20;
            this.radioPartielle.Text = "Partielle";
            this.radioPartielle.UseVisualStyleBackColor = true;
            // 
            // radioComplete
            // 
            this.radioComplete.AutoSize = true;
            this.radioComplete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioComplete.Location = new System.Drawing.Point(467, 28);
            this.radioComplete.Name = "radioComplete";
            this.radioComplete.Size = new System.Drawing.Size(89, 21);
            this.radioComplete.TabIndex = 21;
            this.radioComplete.Text = "Compléte";
            this.radioComplete.UseVisualStyleBackColor = true;
            // 
            // btnModifierStatut
            // 
            this.btnModifierStatut.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierStatut.Location = new System.Drawing.Point(595, 19);
            this.btnModifierStatut.Name = "btnModifierStatut";
            this.btnModifierStatut.Size = new System.Drawing.Size(141, 39);
            this.btnModifierStatut.TabIndex = 22;
            this.btnModifierStatut.Text = "Modi&fier Statut";
            this.btnModifierStatut.UseVisualStyleBackColor = true;
            this.btnModifierStatut.Click += new System.EventHandler(this.btnModifierStatut_Click);
            // 
            // radioButtonNG
            // 
            this.radioButtonNG.AutoSize = true;
            this.radioButtonNG.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNG.Location = new System.Drawing.Point(190, 108);
            this.radioButtonNG.Name = "radioButtonNG";
            this.radioButtonNG.Size = new System.Drawing.Size(47, 21);
            this.radioButtonNG.TabIndex = 3;
            this.radioButtonNG.Text = "NG";
            this.radioButtonNG.UseVisualStyleBackColor = true;
            // 
            // radioButtonLP
            // 
            this.radioButtonLP.AutoSize = true;
            this.radioButtonLP.Checked = true;
            this.radioButtonLP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLP.Location = new System.Drawing.Point(132, 108);
            this.radioButtonLP.Name = "radioButtonLP";
            this.radioButtonLP.Size = new System.Drawing.Size(44, 21);
            this.radioButtonLP.TabIndex = 2;
            this.radioButtonLP.TabStop = true;
            this.radioButtonLP.Text = "LP";
            this.radioButtonLP.UseVisualStyleBackColor = true;
            // 
            // labelDateNow
            // 
            this.labelDateNow.AutoSize = true;
            this.labelDateNow.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateNow.Location = new System.Drawing.Point(381, 916);
            this.labelDateNow.Name = "labelDateNow";
            this.labelDateNow.Size = new System.Drawing.Size(0, 16);
            this.labelDateNow.TabIndex = 31;
            // 
            // btnSortir
            // 
            this.btnSortir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortir.Location = new System.Drawing.Point(809, 905);
            this.btnSortir.Name = "btnSortir";
            this.btnSortir.Size = new System.Drawing.Size(88, 35);
            this.btnSortir.TabIndex = 31;
            this.btnSortir.Text = "Sor&tir";
            this.btnSortir.UseVisualStyleBackColor = true;
            this.btnSortir.Click += new System.EventHandler(this.btnSortir_Click);
            // 
            // btnExporterversExcel
            // 
            this.btnExporterversExcel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExporterversExcel.Location = new System.Drawing.Point(764, 200);
            this.btnExporterversExcel.Name = "btnExporterversExcel";
            this.btnExporterversExcel.Size = new System.Drawing.Size(126, 40);
            this.btnExporterversExcel.TabIndex = 17;
            this.btnExporterversExcel.Text = "&Exporter Excel";
            this.btnExporterversExcel.UseVisualStyleBackColor = true;
            this.btnExporterversExcel.Click += new System.EventHandler(this.btnExporterversExcel_Click);
            // 
            // textBoxDernierPO
            // 
            this.textBoxDernierPO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxDernierPO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBoxDernierPO.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDernierPO.Location = new System.Drawing.Point(102, 909);
            this.textBoxDernierPO.Name = "textBoxDernierPO";
            this.textBoxDernierPO.ReadOnly = true;
            this.textBoxDernierPO.Size = new System.Drawing.Size(88, 25);
            this.textBoxDernierPO.TabIndex = 46;
            // 
            // labelDernierPO
            // 
            this.labelDernierPO.AutoSize = true;
            this.labelDernierPO.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDernierPO.Location = new System.Drawing.Point(14, 913);
            this.labelDernierPO.Name = "labelDernierPO";
            this.labelDernierPO.Size = new System.Drawing.Size(82, 17);
            this.labelDernierPO.TabIndex = 45;
            this.labelDernierPO.Text = "Dernier PO";
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.AccessibleDescription = "";
            this.textBoxRecherche.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecherche.Location = new System.Drawing.Point(574, 43);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(174, 25);
            this.textBoxRecherche.TabIndex = 10;
            this.textBoxRecherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRecherche_KeyDown);
            // 
            // textBoxPDFDocument
            // 
            this.textBoxPDFDocument.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPDFDocument.Location = new System.Drawing.Point(131, 296);
            this.textBoxPDFDocument.Name = "textBoxPDFDocument";
            this.textBoxPDFDocument.Size = new System.Drawing.Size(587, 25);
            this.textBoxPDFDocument.TabIndex = 9;
            // 
            // textBoxComentaire
            // 
            this.textBoxComentaire.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComentaire.Location = new System.Drawing.Point(131, 258);
            this.textBoxComentaire.Name = "textBoxComentaire";
            this.textBoxComentaire.Size = new System.Drawing.Size(429, 25);
            this.textBoxComentaire.TabIndex = 8;
            // 
            // textBoxSoumission
            // 
            this.textBoxSoumission.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoumission.Location = new System.Drawing.Point(131, 219);
            this.textBoxSoumission.Name = "textBoxSoumission";
            this.textBoxSoumission.Size = new System.Drawing.Size(429, 25);
            this.textBoxSoumission.TabIndex = 7;
            // 
            // textBoxDemandePar
            // 
            this.textBoxDemandePar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDemandePar.Location = new System.Drawing.Point(131, 181);
            this.textBoxDemandePar.Name = "textBoxDemandePar";
            this.textBoxDemandePar.Size = new System.Drawing.Size(232, 25);
            this.textBoxDemandePar.TabIndex = 6;
            // 
            // textBoxFournisseur
            // 
            this.textBoxFournisseur.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFournisseur.Location = new System.Drawing.Point(131, 142);
            this.textBoxFournisseur.Name = "textBoxFournisseur";
            this.textBoxFournisseur.Size = new System.Drawing.Size(232, 25);
            this.textBoxFournisseur.TabIndex = 5;
            // 
            // textBoxNumeroPO
            // 
            this.textBoxNumeroPO.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroPO.Location = new System.Drawing.Point(252, 105);
            this.textBoxNumeroPO.Name = "textBoxNumeroPO";
            this.textBoxNumeroPO.ReadOnly = true;
            this.textBoxNumeroPO.Size = new System.Drawing.Size(111, 25);
            this.textBoxNumeroPO.TabIndex = 4;
            // 
            // labelSoumission
            // 
            this.labelSoumission.AutoSize = true;
            this.labelSoumission.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoumission.Location = new System.Drawing.Point(15, 223);
            this.labelSoumission.Name = "labelSoumission";
            this.labelSoumission.Size = new System.Drawing.Size(111, 17);
            this.labelSoumission.TabIndex = 37;
            this.labelSoumission.Text = "No. Soumission";
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.AutoSize = true;
            this.labelCommentaire.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentaire.Location = new System.Drawing.Point(15, 262);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(97, 17);
            this.labelCommentaire.TabIndex = 38;
            this.labelCommentaire.Text = "Commentaire";
            // 
            // labelPDFDossier
            // 
            this.labelPDFDossier.AutoSize = true;
            this.labelPDFDossier.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPDFDossier.Location = new System.Drawing.Point(15, 300);
            this.labelPDFDossier.Name = "labelPDFDossier";
            this.labelPDFDossier.Size = new System.Drawing.Size(93, 17);
            this.labelPDFDossier.TabIndex = 39;
            this.labelPDFDossier.Text = "PDF Dossier";
            // 
            // labelDemandePar
            // 
            this.labelDemandePar.AutoSize = true;
            this.labelDemandePar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDemandePar.Location = new System.Drawing.Point(15, 185);
            this.labelDemandePar.Name = "labelDemandePar";
            this.labelDemandePar.Size = new System.Drawing.Size(99, 17);
            this.labelDemandePar.TabIndex = 36;
            this.labelDemandePar.Text = "Demande Par";
            // 
            // labelFournisseur
            // 
            this.labelFournisseur.AutoSize = true;
            this.labelFournisseur.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFournisseur.Location = new System.Drawing.Point(15, 146);
            this.labelFournisseur.Name = "labelFournisseur";
            this.labelFournisseur.Size = new System.Drawing.Size(86, 17);
            this.labelFournisseur.TabIndex = 35;
            this.labelFournisseur.Text = "Fournisseur";
            // 
            // labelNumeroPO
            // 
            this.labelNumeroPO.AutoSize = true;
            this.labelNumeroPO.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroPO.Location = new System.Drawing.Point(15, 108);
            this.labelNumeroPO.Name = "labelNumeroPO";
            this.labelNumeroPO.Size = new System.Drawing.Size(86, 17);
            this.labelNumeroPO.TabIndex = 34;
            this.labelNumeroPO.Text = "Numero PO";
            // 
            // labelListePO
            // 
            this.labelListePO.AutoSize = true;
            this.labelListePO.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListePO.Location = new System.Drawing.Point(19, 40);
            this.labelListePO.Name = "labelListePO";
            this.labelListePO.Size = new System.Drawing.Size(65, 17);
            this.labelListePO.TabIndex = 32;
            this.labelListePO.Text = "Liste PO";
            // 
            // btnNewPO
            // 
            this.btnNewPO.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPO.Location = new System.Drawing.Point(131, 24);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(294, 69);
            this.btnNewPO.TabIndex = 1;
            this.btnNewPO.Text = "Sauvegardez et &Ajouter un Nouveau PO";
            this.btnNewPO.UseVisualStyleBackColor = true;
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // btnAjouterPDF
            // 
            this.btnAjouterPDF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPDF.Location = new System.Drawing.Point(630, 147);
            this.btnAjouterPDF.Name = "btnAjouterPDF";
            this.btnAjouterPDF.Size = new System.Drawing.Size(126, 41);
            this.btnAjouterPDF.TabIndex = 14;
            this.btnAjouterPDF.Text = "Aj&outer PDF";
            this.btnAjouterPDF.UseVisualStyleBackColor = true;
            this.btnAjouterPDF.Click += new System.EventHandler(this.btnAjouterPDF_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(630, 91);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(126, 41);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "&Modifier détails";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(764, 147);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(126, 41);
            this.btnList.TabIndex = 15;
            this.btnList.Text = "&Liste";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(764, 91);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(126, 41);
            this.btnSupprimer.TabIndex = 13;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Location = new System.Drawing.Point(764, 35);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(126, 41);
            this.btnRecherche.TabIndex = 11;
            this.btnRecherche.Text = "&Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // groupDepartement
            // 
            this.groupDepartement.Controls.Add(this.comboBoxListeDepartement);
            this.groupDepartement.Controls.Add(this.btnListeDepartement);
            this.groupDepartement.Controls.Add(this.btnEfaccerDeuxieme);
            this.groupDepartement.Controls.Add(this.btnModifierDepartements);
            this.groupDepartement.Controls.Add(this.listViewDepartement);
            this.groupDepartement.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDepartement.Location = new System.Drawing.Point(12, 489);
            this.groupDepartement.Name = "groupDepartement";
            this.groupDepartement.Size = new System.Drawing.Size(885, 407);
            this.groupDepartement.TabIndex = 49;
            this.groupDepartement.TabStop = false;
            this.groupDepartement.Text = "Départements";
            // 
            // comboBoxListeDepartement
            // 
            this.comboBoxListeDepartement.DataSource = this.deptdeptBindingSource;
            this.comboBoxListeDepartement.DisplayMember = "departement";
            this.comboBoxListeDepartement.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxListeDepartement.FormattingEnabled = true;
            this.comboBoxListeDepartement.Location = new System.Drawing.Point(8, 29);
            this.comboBoxListeDepartement.Name = "comboBoxListeDepartement";
            this.comboBoxListeDepartement.Size = new System.Drawing.Size(239, 25);
            this.comboBoxListeDepartement.TabIndex = 26;
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
            // btnListeDepartement
            // 
            this.btnListeDepartement.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeDepartement.Location = new System.Drawing.Point(34, 297);
            this.btnListeDepartement.Name = "btnListeDepartement";
            this.btnListeDepartement.Size = new System.Drawing.Size(89, 41);
            this.btnListeDepartement.TabIndex = 28;
            this.btnListeDepartement.Text = "List&e";
            this.btnListeDepartement.UseVisualStyleBackColor = true;
            this.btnListeDepartement.Click += new System.EventHandler(this.btnListeDepartement_Click);
            // 
            // btnEfaccerDeuxieme
            // 
            this.btnEfaccerDeuxieme.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfaccerDeuxieme.Location = new System.Drawing.Point(34, 349);
            this.btnEfaccerDeuxieme.Name = "btnEfaccerDeuxieme";
            this.btnEfaccerDeuxieme.Size = new System.Drawing.Size(184, 41);
            this.btnEfaccerDeuxieme.TabIndex = 30;
            this.btnEfaccerDeuxieme.Text = "Effacer Deu&xieme";
            this.btnEfaccerDeuxieme.UseVisualStyleBackColor = true;
            this.btnEfaccerDeuxieme.Click += new System.EventHandler(this.btnEfaccerDeuxieme_Click);
            // 
            // btnModifierDepartements
            // 
            this.btnModifierDepartements.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierDepartements.Location = new System.Drawing.Point(129, 297);
            this.btnModifierDepartements.Name = "btnModifierDepartements";
            this.btnModifierDepartements.Size = new System.Drawing.Size(89, 41);
            this.btnModifierDepartements.TabIndex = 29;
            this.btnModifierDepartements.Text = "Mo&difier";
            this.btnModifierDepartements.UseVisualStyleBackColor = true;
            this.btnModifierDepartements.Click += new System.EventHandler(this.btnModifierDepartements_Click);
            // 
            // listViewDepartement
            // 
            this.listViewDepartement.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewDepartement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewDepartement.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDepartement.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listViewDepartement.FullRowSelect = true;
            this.listViewDepartement.GridLines = true;
            this.listViewDepartement.HideSelection = false;
            this.listViewDepartement.Location = new System.Drawing.Point(253, 29);
            this.listViewDepartement.MultiSelect = false;
            this.listViewDepartement.Name = "listViewDepartement";
            this.listViewDepartement.Size = new System.Drawing.Size(622, 360);
            this.listViewDepartement.TabIndex = 27;
            this.listViewDepartement.UseCompatibleStateImageBehavior = false;
            this.listViewDepartement.View = System.Windows.Forms.View.Details;
            this.listViewDepartement.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewDepartement_MouseDoubleClick);
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
            // departements_testTableAdapter
            // 
            this.departements_testTableAdapter.ClearBeforeFill = true;
            // 
            // dept_deptTableAdapter
            // 
            this.dept_deptTableAdapter.ClearBeforeFill = true;
            // 
            // menuStripFileAdmin
            // 
            this.menuStripFileAdmin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripFileAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminStripMenuItem1});
            this.menuStripFileAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuStripFileAdmin.Name = "menuStripFileAdmin";
            this.menuStripFileAdmin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripFileAdmin.Size = new System.Drawing.Size(933, 25);
            this.menuStripFileAdmin.TabIndex = 1;
            this.menuStripFileAdmin.Text = "menuStrip1";
            // 
            // adminStripMenuItem1
            // 
            this.adminStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginStripMenuItem,
            this.editStripMenuItem1,
            this.logoutStripMenuItem1});
            this.adminStripMenuItem1.Name = "adminStripMenuItem1";
            this.adminStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.adminStripMenuItem1.Size = new System.Drawing.Size(61, 21);
            this.adminStripMenuItem1.Text = "Admin";
            // 
            // loginStripMenuItem
            // 
            this.loginStripMenuItem.Name = "loginStripMenuItem";
            this.loginStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.loginStripMenuItem.Text = "Login";
            this.loginStripMenuItem.Click += new System.EventHandler(this.loginStripMenuItem_Click);
            // 
            // editStripMenuItem1
            // 
            this.editStripMenuItem1.Name = "editStripMenuItem1";
            this.editStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.editStripMenuItem1.Text = "Modifier les utilisateurs";
            this.editStripMenuItem1.Click += new System.EventHandler(this.editStripMenuItem1_Click);
            // 
            // logoutStripMenuItem1
            // 
            this.logoutStripMenuItem1.Name = "logoutStripMenuItem1";
            this.logoutStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.logoutStripMenuItem1.Text = "Se déconnecter";
            this.logoutStripMenuItem1.Click += new System.EventHandler(this.logoutStripMenuItem1_Click);
            // 
            // dept_deptTableAdapter1
            // 
            this.dept_deptTableAdapter1.ClearBeforeFill = true;
            // 
            // POsystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 992);
            this.Controls.Add(this.groupLaPresse);
            this.Controls.Add(this.menuStripFileAdmin);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripFileAdmin;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(949, 1031);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(949, 1030);
            this.Name = "POsystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PO Système";
            this.Load += new System.EventHandler(this.POsystem_Load);
            this.groupLaPresse.ResumeLayout(false);
            this.groupLaPresse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptdeptBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxStatut.ResumeLayout(false);
            this.groupBoxStatut.PerformLayout();
            this.groupDepartement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deptdeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departementstestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDept)).EndInit();
            this.menuStripFileAdmin.ResumeLayout(false);
            this.menuStripFileAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupLaPresse;
        private System.Windows.Forms.Button btnNewPO;
        private System.Windows.Forms.Button btnAjouterPDF;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.GroupBox groupDepartement;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.TextBox textBoxPDFDocument;
        private System.Windows.Forms.TextBox textBoxComentaire;
        private System.Windows.Forms.TextBox textBoxSoumission;
        private System.Windows.Forms.TextBox textBoxDemandePar;
        private System.Windows.Forms.TextBox textBoxFournisseur;
        private System.Windows.Forms.TextBox textBoxNumeroPO;
        private System.Windows.Forms.Label labelSoumission;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.Label labelPDFDossier;
        private System.Windows.Forms.Label labelDemandePar;
        private System.Windows.Forms.Label labelFournisseur;
        private System.Windows.Forms.Label labelNumeroPO;
        private System.Windows.Forms.Label labelListePO;
        private System.Windows.Forms.TextBox textBoxDernierPO;
        private System.Windows.Forms.Label labelDernierPO;
        private System.Windows.Forms.ListView listViewDepartement;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnExporterversExcel;
        private System.Windows.Forms.Button btnSortir;
        private System.Windows.Forms.Label labelStatut;
        private System.Windows.Forms.RadioButton radioComplete;
        private System.Windows.Forms.RadioButton radioPartielle;
        private System.Windows.Forms.Button btnModifierStatut;
        private System.Windows.Forms.Label labelDateNow;
        private System.Windows.Forms.RadioButton radioButtonNG;
        private System.Windows.Forms.RadioButton radioButtonLP;
        private System.Windows.Forms.TextBox textBoxApprobe;
        private System.Windows.Forms.GroupBox groupBoxStatut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDeuxiemeAprovation;
        private System.Windows.Forms.TextBox textBoxDeuxiemeAprovation;
        private System.Windows.Forms.RadioButton radioButtonEnAttente;
        private System.Windows.Forms.Label labelChampObligatoire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEffacerChamps;
        private System.Windows.Forms.Button btnModifierApprobe;
        private System.Windows.Forms.Button btnEfaccerDeuxieme;
        private DataSetDept dataSetDept;
        private System.Windows.Forms.BindingSource departementstestBindingSource;
        private DataSetDeptTableAdapters.departements_testTableAdapter departements_testTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxListeDepartement;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource deptdeptBindingSource;
        private DataSet1TableAdapters.Dept_deptTableAdapter dept_deptTableAdapter;
        private System.Windows.Forms.Button btnOuvrirPDF;
        private System.Windows.Forms.MenuStrip menuStripFileAdmin;
        private System.Windows.Forms.ToolStripMenuItem adminStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem editStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem logoutStripMenuItem1;
        internal System.Windows.Forms.Button btnListeDepartement;
        public System.Windows.Forms.Button btnModifierDepartements;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource deptdeptBindingSource1;
        private DataSet2TableAdapters.Dept_deptTableAdapter dept_deptTableAdapter1;
    }
}

