
namespace Collage_App_V2.View
{
    partial class FRM_Score
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Score));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gcScores = new DevExpress.XtraGrid.GridControl();
            this.cLSScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvScores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_Score = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_Student = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubject_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colterm1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colterm2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryEditScore = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colScoreDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryDeleteSubject = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
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
            this.simpleButtonAddStudyBook = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLSScoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryEditScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDeleteSubject)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.groupControl1.Size = new System.Drawing.Size(1220, 837);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "درجات الطالب";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.gcScores, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67002F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.94962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.5063F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1216, 794);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gcScores
            // 
            this.gcScores.DataSource = this.cLSScoreBindingSource;
            this.gcScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcScores.Location = new System.Drawing.Point(126, 182);
            this.gcScores.MainView = this.gvScores;
            this.gcScores.Name = "gcScores";
            this.gcScores.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryEditScore,
            this.repositoryDeleteSubject});
            this.gcScores.Size = new System.Drawing.Size(966, 469);
            this.gcScores.TabIndex = 0;
            this.gcScores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvScores});
            // 
            // cLSScoreBindingSource
            // 
            this.cLSScoreBindingSource.DataSource = typeof(Collage_App_V2.Model.CLS_Score);
            // 
            // gvScores
            // 
            this.gvScores.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvScores.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvScores.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvScores.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvScores.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvScores.Appearance.Row.Options.UseFont = true;
            this.gvScores.Appearance.Row.Options.UseTextOptions = true;
            this.gvScores.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvScores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_Score,
            this.colid_Student,
            this.colsubject_name,
            this.colterm1,
            this.colterm2,
            this.colfinal,
            this.colScoreEdit,
            this.colScoreDelete});
            this.gvScores.GridControl = this.gcScores;
            this.gvScores.Name = "gvScores";
            this.gvScores.OptionsView.ShowGroupPanel = false;
            // 
            // colid_Score
            // 
            this.colid_Score.FieldName = "id_Score";
            this.colid_Score.MinWidth = 25;
            this.colid_Score.Name = "colid_Score";
            this.colid_Score.OptionsColumn.AllowEdit = false;
            this.colid_Score.OptionsColumn.AllowFocus = false;
            this.colid_Score.OptionsColumn.AllowMove = false;
            this.colid_Score.Width = 94;
            // 
            // colid_Student
            // 
            this.colid_Student.FieldName = "id_Student";
            this.colid_Student.MinWidth = 25;
            this.colid_Student.Name = "colid_Student";
            this.colid_Student.OptionsColumn.AllowEdit = false;
            this.colid_Student.OptionsColumn.AllowFocus = false;
            this.colid_Student.OptionsColumn.AllowMove = false;
            this.colid_Student.Width = 94;
            // 
            // colsubject_name
            // 
            this.colsubject_name.Caption = "اسم المادة";
            this.colsubject_name.FieldName = "subject_name";
            this.colsubject_name.MinWidth = 25;
            this.colsubject_name.Name = "colsubject_name";
            this.colsubject_name.OptionsColumn.AllowEdit = false;
            this.colsubject_name.OptionsColumn.AllowFocus = false;
            this.colsubject_name.OptionsColumn.AllowMove = false;
            this.colsubject_name.Visible = true;
            this.colsubject_name.VisibleIndex = 0;
            this.colsubject_name.Width = 94;
            // 
            // colterm1
            // 
            this.colterm1.Caption = "الفصل الاول";
            this.colterm1.FieldName = "term1";
            this.colterm1.MinWidth = 25;
            this.colterm1.Name = "colterm1";
            this.colterm1.OptionsColumn.AllowEdit = false;
            this.colterm1.OptionsColumn.AllowFocus = false;
            this.colterm1.OptionsColumn.AllowMove = false;
            this.colterm1.Visible = true;
            this.colterm1.VisibleIndex = 1;
            this.colterm1.Width = 94;
            // 
            // colterm2
            // 
            this.colterm2.Caption = "الفصل الثاني";
            this.colterm2.FieldName = "term2";
            this.colterm2.MinWidth = 25;
            this.colterm2.Name = "colterm2";
            this.colterm2.OptionsColumn.AllowEdit = false;
            this.colterm2.OptionsColumn.AllowFocus = false;
            this.colterm2.OptionsColumn.AllowMove = false;
            this.colterm2.Visible = true;
            this.colterm2.VisibleIndex = 2;
            this.colterm2.Width = 94;
            // 
            // colfinal
            // 
            this.colfinal.Caption = "الفاينل";
            this.colfinal.FieldName = "final";
            this.colfinal.MinWidth = 25;
            this.colfinal.Name = "colfinal";
            this.colfinal.OptionsColumn.AllowEdit = false;
            this.colfinal.OptionsColumn.AllowFocus = false;
            this.colfinal.OptionsColumn.AllowMove = false;
            this.colfinal.Visible = true;
            this.colfinal.VisibleIndex = 3;
            this.colfinal.Width = 94;
            // 
            // colScoreEdit
            // 
            this.colScoreEdit.Caption = "تعديل الدرجات";
            this.colScoreEdit.ColumnEdit = this.repositoryEditScore;
            this.colScoreEdit.MinWidth = 25;
            this.colScoreEdit.Name = "colScoreEdit";
            this.colScoreEdit.OptionsFilter.AllowAutoFilter = false;
            this.colScoreEdit.OptionsFilter.AllowFilter = false;
            this.colScoreEdit.Visible = true;
            this.colScoreEdit.VisibleIndex = 4;
            this.colScoreEdit.Width = 94;
            // 
            // repositoryEditScore
            // 
            this.repositoryEditScore.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryEditScore.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryEditScore.Name = "repositoryEditScore";
            this.repositoryEditScore.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryEditScore.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryEditScore_ButtonClick);
            // 
            // colScoreDelete
            // 
            this.colScoreDelete.Caption = "حذف مادة";
            this.colScoreDelete.ColumnEdit = this.repositoryDeleteSubject;
            this.colScoreDelete.MinWidth = 25;
            this.colScoreDelete.Name = "colScoreDelete";
            this.colScoreDelete.OptionsFilter.AllowAutoFilter = false;
            this.colScoreDelete.OptionsFilter.AllowFilter = false;
            this.colScoreDelete.Visible = true;
            this.colScoreDelete.VisibleIndex = 5;
            this.colScoreDelete.Width = 94;
            // 
            // repositoryDeleteSubject
            // 
            this.repositoryDeleteSubject.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryDeleteSubject.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryDeleteSubject.Name = "repositoryDeleteSubject";
            this.repositoryDeleteSubject.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryDeleteSubject.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryDeleteSubject_ButtonClick);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(966, 173);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(199, 115);
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
            this.labelControlStep.Location = new System.Drawing.Point(373, 115);
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
            this.labelControl3.Location = new System.Drawing.Point(507, 115);
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
            this.labelControlDepartment.Location = new System.Drawing.Point(681, 115);
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
            this.labelControl2.Location = new System.Drawing.Point(815, 115);
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
            this.labelControlTypeOfStudy.Location = new System.Drawing.Point(65, 115);
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
            this.labelControl5.Location = new System.Drawing.Point(815, 29);
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
            this.labelControlIdStudent.Location = new System.Drawing.Point(747, 29);
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
            this.labelControl1.Location = new System.Drawing.Point(507, 29);
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
            this.labelControlStudentName.Location = new System.Drawing.Point(373, 29);
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
            this.tableLayoutPanel3.Controls.Add(this.simpleButtonAddStudyBook, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(126, 657);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(966, 134);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // simpleButtonAddStudyBook
            // 
            this.simpleButtonAddStudyBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonAddStudyBook.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonAddStudyBook.Appearance.Options.UseFont = true;
            this.simpleButtonAddStudyBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAddStudyBook.ImageOptions.Image")));
            this.simpleButtonAddStudyBook.Location = new System.Drawing.Point(728, 8);
            this.simpleButtonAddStudyBook.Name = "simpleButtonAddStudyBook";
            this.simpleButtonAddStudyBook.Size = new System.Drawing.Size(235, 51);
            this.simpleButtonAddStudyBook.TabIndex = 23;
            this.simpleButtonAddStudyBook.Text = "أضافة مادة";
            this.simpleButtonAddStudyBook.Click += new System.EventHandler(this.simpleButtonAddStudyBook_Click);
            // 
            // FRM_Score
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 837);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookAndFeel.SkinName = "Money Twins";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1230, 872);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1230, 872);
            this.Name = "FRM_Score";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLSScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryEditScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDeleteSubject)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddStudyBook;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.LabelControl labelControlStep;
        public DevExpress.XtraEditors.LabelControl labelControlStudentName;
        public DevExpress.XtraEditors.LabelControl labelControlDepartment;
        public DevExpress.XtraEditors.LabelControl labelControlTypeOfStudy;
        public DevExpress.XtraEditors.LabelControl labelControlIdStudent;
        private System.Windows.Forms.BindingSource cLSScoreBindingSource;
        private DevExpress.XtraGrid.GridControl gcScores;
        private DevExpress.XtraGrid.Views.Grid.GridView gvScores;
        private DevExpress.XtraGrid.Columns.GridColumn colid_Score;
        private DevExpress.XtraGrid.Columns.GridColumn colid_Student;
        private DevExpress.XtraGrid.Columns.GridColumn colsubject_name;
        private DevExpress.XtraGrid.Columns.GridColumn colterm1;
        private DevExpress.XtraGrid.Columns.GridColumn colterm2;
        private DevExpress.XtraGrid.Columns.GridColumn colfinal;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryEditScore;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryDeleteSubject;
    }
}