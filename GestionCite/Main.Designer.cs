﻿namespace GestionCite
{
    partial class Main
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listFinalByAnneeGridControl = new DevExpress.XtraGrid.GridControl();
            this.listFinalThisYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionCiteDataSet = new GestionCite.GestionCiteDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrenom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNDossier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNaissance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVille = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEtablissement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNiveau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChambre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPavion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.listFinalThisYearTableAdapter = new GestionCite.GestionCiteDataSetTableAdapters.ListFinalThisYearTableAdapter();
            this.tableAdapterManager = new GestionCite.GestionCiteDataSetTableAdapters.TableAdapterManager();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.listFinalByAnneeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFinalThisYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listFinalByAnneeGridControl
            // 
            this.listFinalByAnneeGridControl.DataSource = this.listFinalThisYearBindingSource;
            this.listFinalByAnneeGridControl.Location = new System.Drawing.Point(3, 128);
            this.listFinalByAnneeGridControl.MainView = this.gridView1;
            this.listFinalByAnneeGridControl.Name = "listFinalByAnneeGridControl";
            this.listFinalByAnneeGridControl.Size = new System.Drawing.Size(914, 509);
            this.listFinalByAnneeGridControl.TabIndex = 5;
            this.listFinalByAnneeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // listFinalThisYearBindingSource
            // 
            this.listFinalThisYearBindingSource.DataMember = "ListFinalThisYear";
            this.listFinalThisYearBindingSource.DataSource = this.gestionCiteDataSet;
            // 
            // gestionCiteDataSet
            // 
            this.gestionCiteDataSet.DataSetName = "GestionCiteDataSet";
            this.gestionCiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNom,
            this.colPrenom,
            this.colCIN,
            this.colCNE,
            this.colNDossier,
            this.colNaissance,
            this.colVille,
            this.colEtablissement,
            this.colNiveau,
            this.colDepartement,
            this.colChambre,
            this.colPavion});
            this.gridView1.GridControl = this.listFinalByAnneeGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colNom
            // 
            this.colNom.AppearanceCell.Options.UseTextOptions = true;
            this.colNom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNom.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNom.AppearanceHeader.Options.UseTextOptions = true;
            this.colNom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNom.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNom.FieldName = "Nom";
            this.colNom.Name = "colNom";
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 0;
            // 
            // colPrenom
            // 
            this.colPrenom.AppearanceCell.Options.UseTextOptions = true;
            this.colPrenom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrenom.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPrenom.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrenom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrenom.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPrenom.FieldName = "Prenom";
            this.colPrenom.Name = "colPrenom";
            this.colPrenom.Visible = true;
            this.colPrenom.VisibleIndex = 1;
            // 
            // colCIN
            // 
            this.colCIN.AppearanceCell.Options.UseTextOptions = true;
            this.colCIN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCIN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCIN.AppearanceHeader.Options.UseTextOptions = true;
            this.colCIN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCIN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCIN.FieldName = "CIN";
            this.colCIN.Name = "colCIN";
            this.colCIN.Visible = true;
            this.colCIN.VisibleIndex = 2;
            // 
            // colCNE
            // 
            this.colCNE.AppearanceCell.Options.UseTextOptions = true;
            this.colCNE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCNE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCNE.AppearanceHeader.Options.UseTextOptions = true;
            this.colCNE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCNE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCNE.FieldName = "CNE";
            this.colCNE.Name = "colCNE";
            this.colCNE.Visible = true;
            this.colCNE.VisibleIndex = 3;
            // 
            // colNDossier
            // 
            this.colNDossier.AppearanceCell.Options.UseTextOptions = true;
            this.colNDossier.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNDossier.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNDossier.AppearanceHeader.Options.UseTextOptions = true;
            this.colNDossier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNDossier.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNDossier.FieldName = "N Dossier";
            this.colNDossier.Name = "colNDossier";
            this.colNDossier.Visible = true;
            this.colNDossier.VisibleIndex = 4;
            // 
            // colNaissance
            // 
            this.colNaissance.AppearanceCell.Options.UseTextOptions = true;
            this.colNaissance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNaissance.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNaissance.AppearanceHeader.Options.UseTextOptions = true;
            this.colNaissance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNaissance.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNaissance.FieldName = "Naissance";
            this.colNaissance.Name = "colNaissance";
            this.colNaissance.Visible = true;
            this.colNaissance.VisibleIndex = 5;
            // 
            // colVille
            // 
            this.colVille.AppearanceCell.Options.UseTextOptions = true;
            this.colVille.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVille.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colVille.AppearanceHeader.Options.UseTextOptions = true;
            this.colVille.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVille.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colVille.FieldName = "Ville";
            this.colVille.Name = "colVille";
            this.colVille.Visible = true;
            this.colVille.VisibleIndex = 6;
            // 
            // colEtablissement
            // 
            this.colEtablissement.AppearanceCell.Options.UseTextOptions = true;
            this.colEtablissement.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEtablissement.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEtablissement.AppearanceHeader.Options.UseTextOptions = true;
            this.colEtablissement.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEtablissement.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEtablissement.FieldName = "Etablissement";
            this.colEtablissement.Name = "colEtablissement";
            this.colEtablissement.Visible = true;
            this.colEtablissement.VisibleIndex = 7;
            // 
            // colNiveau
            // 
            this.colNiveau.AppearanceCell.Options.UseTextOptions = true;
            this.colNiveau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNiveau.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNiveau.AppearanceHeader.Options.UseTextOptions = true;
            this.colNiveau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNiveau.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNiveau.FieldName = "Niveau";
            this.colNiveau.Name = "colNiveau";
            this.colNiveau.Visible = true;
            this.colNiveau.VisibleIndex = 8;
            // 
            // colDepartement
            // 
            this.colDepartement.AppearanceCell.Options.UseTextOptions = true;
            this.colDepartement.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepartement.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDepartement.AppearanceHeader.Options.UseTextOptions = true;
            this.colDepartement.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepartement.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDepartement.FieldName = "Departement";
            this.colDepartement.Name = "colDepartement";
            this.colDepartement.Visible = true;
            this.colDepartement.VisibleIndex = 9;
            // 
            // colChambre
            // 
            this.colChambre.AppearanceCell.Options.UseTextOptions = true;
            this.colChambre.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChambre.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colChambre.AppearanceHeader.Options.UseTextOptions = true;
            this.colChambre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChambre.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colChambre.FieldName = "Chambre";
            this.colChambre.Name = "colChambre";
            this.colChambre.Visible = true;
            this.colChambre.VisibleIndex = 10;
            // 
            // colPavion
            // 
            this.colPavion.AppearanceCell.Options.UseTextOptions = true;
            this.colPavion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPavion.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPavion.AppearanceHeader.Options.UseTextOptions = true;
            this.colPavion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPavion.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPavion.FieldName = "Pavion";
            this.colPavion.Name = "colPavion";
            this.colPavion.Visible = true;
            this.colPavion.VisibleIndex = 11;
            // 
            // listFinalThisYearTableAdapter
            // 
            this.listFinalThisYearTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DateAnneeInscriptionTableAdapter = null;
            this.tableAdapterManager.EtudiantsQuitteTableAdapter = null;
            this.tableAdapterManager.EtudiantTableAdapter = null;
            this.tableAdapterManager.InscriptionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionCite.GestionCiteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textEdit1.Location = new System.Drawing.Point(168, 43);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AutoHeight = false;
            this.textEdit1.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("textEdit1.Properties.ContextImageOptions.SvgImage")));
            this.textEdit1.Size = new System.Drawing.Size(363, 43);
            this.textEdit1.TabIndex = 26;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton1.Location = new System.Drawing.Point(537, 43);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(180, 43);
            this.simpleButton1.TabIndex = 27;
            this.simpleButton1.Text = "Imprimer fich d\'etudiant";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(886, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(31, 31);
            this.pictureEdit1.TabIndex = 29;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.listFinalByAnneeGridControl);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(920, 640);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listFinalByAnneeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFinalThisYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCiteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl listFinalByAnneeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colPrenom;
        private DevExpress.XtraGrid.Columns.GridColumn colCIN;
        private DevExpress.XtraGrid.Columns.GridColumn colCNE;
        private DevExpress.XtraGrid.Columns.GridColumn colNDossier;
        private DevExpress.XtraGrid.Columns.GridColumn colNaissance;
        private DevExpress.XtraGrid.Columns.GridColumn colVille;
        private DevExpress.XtraGrid.Columns.GridColumn colEtablissement;
        private DevExpress.XtraGrid.Columns.GridColumn colNiveau;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartement;
        private DevExpress.XtraGrid.Columns.GridColumn colChambre;
        private DevExpress.XtraGrid.Columns.GridColumn colPavion;
        private System.Windows.Forms.BindingSource listFinalThisYearBindingSource;
        private GestionCiteDataSet gestionCiteDataSet;
        private GestionCiteDataSetTableAdapters.ListFinalThisYearTableAdapter listFinalThisYearTableAdapter;
        private GestionCiteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
