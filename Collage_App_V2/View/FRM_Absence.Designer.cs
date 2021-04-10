
namespace Collage_App_V2.View
{
    partial class FRM_Absence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Absence));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gcAbsence = new DevExpress.XtraGrid.GridControl();
            this.cLSAbsenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvAbsence = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_Absence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colabsence_count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_Absence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_Student = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeletAbsence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryDeleteAbsence = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlStep = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDepartment = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlTypeOfStudy = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlIdStudent = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlStudentName = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonAddAbsence = new DevExpress.XtraEditors.SimpleButton();
            this.txtAge = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlTotalAbsence = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLSAbsenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDeleteAbsence)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1228, 837);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "سجل الغيابات";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.gcAbsence, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67002F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.94962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.5063F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1224, 794);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gcAbsence
            // 
            this.gcAbsence.DataSource = this.cLSAbsenceBindingSource;
            this.gcAbsence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAbsence.Location = new System.Drawing.Point(126, 182);
            this.gcAbsence.MainView = this.gvAbsence;
            this.gcAbsence.Name = "gcAbsence";
            this.gcAbsence.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryDeleteAbsence});
            this.gcAbsence.Size = new System.Drawing.Size(973, 469);
            this.gcAbsence.TabIndex = 0;
            this.gcAbsence.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAbsence});
            // 
            // cLSAbsenceBindingSource
            // 
            this.cLSAbsenceBindingSource.DataSource = typeof(Collage_App_V2.Model.CLS_Absence);
            // 
            // gvAbsence
            // 
            this.gvAbsence.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvAbsence.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvAbsence.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvAbsence.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvAbsence.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvAbsence.Appearance.Row.Options.UseFont = true;
            this.gvAbsence.Appearance.Row.Options.UseTextOptions = true;
            this.gvAbsence.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvAbsence.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_Absence,
            this.colabsence_count,
            this.coldate_Absence,
            this.colid_Student,
            this.colDeletAbsence});
            this.gvAbsence.GridControl = this.gcAbsence;
            this.gvAbsence.Name = "gvAbsence";
            this.gvAbsence.OptionsView.ShowGroupPanel = false;
            // 
            // colid_Absence
            // 
            this.colid_Absence.FieldName = "id_Absence";
            this.colid_Absence.MinWidth = 25;
            this.colid_Absence.Name = "colid_Absence";
            this.colid_Absence.Width = 94;
            // 
            // colabsence_count
            // 
            this.colabsence_count.FieldName = "absence_count";
            this.colabsence_count.MinWidth = 25;
            this.colabsence_count.Name = "colabsence_count";
            this.colabsence_count.Width = 94;
            // 
            // coldate_Absence
            // 
            this.coldate_Absence.Caption = "تاريخ الغياب";
            this.coldate_Absence.FieldName = "date_Absence";
            this.coldate_Absence.MinWidth = 25;
            this.coldate_Absence.Name = "coldate_Absence";
            this.coldate_Absence.OptionsColumn.AllowEdit = false;
            this.coldate_Absence.OptionsColumn.AllowFocus = false;
            this.coldate_Absence.OptionsColumn.AllowMove = false;
            this.coldate_Absence.Visible = true;
            this.coldate_Absence.VisibleIndex = 0;
            this.coldate_Absence.Width = 741;
            // 
            // colid_Student
            // 
            this.colid_Student.FieldName = "id_Student";
            this.colid_Student.MinWidth = 25;
            this.colid_Student.Name = "colid_Student";
            this.colid_Student.Width = 94;
            // 
            // colDeletAbsence
            // 
            this.colDeletAbsence.Caption = "حذف";
            this.colDeletAbsence.ColumnEdit = this.repositoryDeleteAbsence;
            this.colDeletAbsence.MinWidth = 25;
            this.colDeletAbsence.Name = "colDeletAbsence";
            this.colDeletAbsence.Visible = true;
            this.colDeletAbsence.VisibleIndex = 1;
            this.colDeletAbsence.Width = 211;
            // 
            // repositoryDeleteAbsence
            // 
            this.repositoryDeleteAbsence.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryDeleteAbsence.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryDeleteAbsence.Name = "repositoryDeleteAbsence";
            this.repositoryDeleteAbsence.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryDeleteAbsence.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryDeleteAbsence_ButtonClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.labelControl4, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControlStep, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControlDepartment, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControlTypeOfStudy, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControlIdStudent, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControlStudentName, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(126, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(973, 173);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(201, 115);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(106, 28);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "نوع الدراسة :";
            // 
            // labelControlStep
            // 
            this.labelControlStep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControlStep.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlStep.Appearance.Options.UseFont = true;
            this.labelControlStep.Location = new System.Drawing.Point(377, 115);
            this.labelControlStep.Name = "labelControlStep";
            this.labelControlStep.Size = new System.Drawing.Size(128, 28);
            this.labelControlStep.TabIndex = 7;
            this.labelControlStep.Text = "labelControl2";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(511, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 28);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "المرحلة :";
            // 
            // labelControlDepartment
            // 
            this.labelControlDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControlDepartment.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlDepartment.Appearance.Options.UseFont = true;
            this.labelControlDepartment.Location = new System.Drawing.Point(687, 115);
            this.labelControlDepartment.Name = "labelControlDepartment";
            this.labelControlDepartment.Size = new System.Drawing.Size(128, 28);
            this.labelControlDepartment.TabIndex = 5;
            this.labelControlDepartment.Text = "labelControl2";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(821, 115);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 28);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "القسم :";
            // 
            // labelControlTypeOfStudy
            // 
            this.labelControlTypeOfStudy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControlTypeOfStudy.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlTypeOfStudy.Appearance.Options.UseFont = true;
            this.labelControlTypeOfStudy.Location = new System.Drawing.Point(67, 115);
            this.labelControlTypeOfStudy.Name = "labelControlTypeOfStudy";
            this.labelControlTypeOfStudy.Size = new System.Drawing.Size(128, 28);
            this.labelControlTypeOfStudy.TabIndex = 6;
            this.labelControlTypeOfStudy.Text = "labelControl2";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(821, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(73, 28);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "المعرف :";
            // 
            // labelControlIdStudent
            // 
            this.labelControlIdStudent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControlIdStudent.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlIdStudent.Appearance.Options.UseFont = true;
            this.labelControlIdStudent.Location = new System.Drawing.Point(753, 29);
            this.labelControlIdStudent.Name = "labelControlIdStudent";
            this.labelControlIdStudent.Size = new System.Drawing.Size(62, 28);
            this.labelControlIdStudent.TabIndex = 9;
            this.labelControlIdStudent.Text = "المعرف";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(511, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم الطالب :";
            // 
            // labelControlStudentName
            // 
            this.labelControlStudentName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControlStudentName.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlStudentName.Appearance.Options.UseFont = true;
            this.labelControlStudentName.Location = new System.Drawing.Point(377, 29);
            this.labelControlStudentName.Name = "labelControlStudentName";
            this.labelControlStudentName.Size = new System.Drawing.Size(128, 28);
            this.labelControlStudentName.TabIndex = 1;
            this.labelControlStudentName.Text = "labelControl2";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.simpleButtonAddAbsence, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtAge, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelControl6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelControlTotalAbsence, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(126, 657);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.78313F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.21687F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(973, 134);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // simpleButtonAddAbsence
            // 
            this.simpleButtonAddAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonAddAbsence.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonAddAbsence.Appearance.Options.UseFont = true;
            this.simpleButtonAddAbsence.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAddAbsence.ImageOptions.Image")));
            this.simpleButtonAddAbsence.Location = new System.Drawing.Point(733, 47);
            this.simpleButtonAddAbsence.Name = "simpleButtonAddAbsence";
            this.simpleButtonAddAbsence.Size = new System.Drawing.Size(237, 46);
            this.simpleButtonAddAbsence.TabIndex = 23;
            this.simpleButtonAddAbsence.Text = "أضافة تاريخ الغياب";
            this.simpleButtonAddAbsence.Click += new System.EventHandler(this.simpleButtonAddAbsence_Click);
            // 
            // txtAge
            // 
            this.txtAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAge.EditValue = null;
            this.txtAge.Location = new System.Drawing.Point(490, 55);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtAge.Properties.Appearance.Options.UseFont = true;
            this.txtAge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAge.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAge.Size = new System.Drawing.Size(237, 30);
            this.txtAge.TabIndex = 28;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(733, 8);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(141, 28);
            this.labelControl6.TabIndex = 29;
            this.labelControl6.Text = "مجموع الغيابات :";
            // 
            // labelControlTotalAbsence
            // 
            this.labelControlTotalAbsence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControlTotalAbsence.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlTotalAbsence.Appearance.Options.UseFont = true;
            this.labelControlTotalAbsence.Location = new System.Drawing.Point(715, 8);
            this.labelControlTotalAbsence.Name = "labelControlTotalAbsence";
            this.labelControlTotalAbsence.Size = new System.Drawing.Size(12, 28);
            this.labelControlTotalAbsence.TabIndex = 30;
            this.labelControlTotalAbsence.Text = "0";
            // 
            // FRM_Absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 837);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Money Twins";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1238, 872);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1238, 872);
            this.Name = "FRM_Absence";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLSAbsenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDeleteAbsence)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gcAbsence;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAbsence;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.LabelControl labelControlStep;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LabelControl labelControlDepartment;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.LabelControl labelControlTypeOfStudy;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.LabelControl labelControlIdStudent;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LabelControl labelControlStudentName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddAbsence;
        private System.Windows.Forms.BindingSource cLSAbsenceBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_Absence;
        private DevExpress.XtraGrid.Columns.GridColumn colabsence_count;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_Absence;
        private DevExpress.XtraGrid.Columns.GridColumn colid_Student;
        private DevExpress.XtraGrid.Columns.GridColumn colDeletAbsence;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryDeleteAbsence;
        private DevExpress.XtraEditors.DateEdit txtAge;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.LabelControl labelControlTotalAbsence;
    }
}