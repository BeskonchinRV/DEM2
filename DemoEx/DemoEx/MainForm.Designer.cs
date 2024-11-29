namespace DemoEx
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgTechIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairBDDataSet = new DemoEx.RepairBDDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoExDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoExDataSet = new DemoEx.DemoExDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new DemoEx.DemoExDataSetTableAdapters.ProductTableAdapter();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usersTableAdapter = new DemoEx.DemoExDataSetTableAdapters.UsersTableAdapter();
            this.radioButtonAZ = new System.Windows.Forms.RadioButton();
            this.radioButtonZA = new System.Windows.Forms.RadioButton();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonEditRequest = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.requestsTableAdapter = new DemoEx.RepairBDDataSetTableAdapters.RequestsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoExDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoExDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.orgTechIDDataGridViewTextBoxColumn,
            this.problemDescriptionDataGridViewTextBoxColumn,
            this.statusIDDataGridViewTextBoxColumn,
            this.completionDateDataGridViewTextBoxColumn,
            this.partIDDataGridViewTextBoxColumn,
            this.masterIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(864, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "requestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "requestID";
            this.requestIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 110;
            // 
            // orgTechIDDataGridViewTextBoxColumn
            // 
            this.orgTechIDDataGridViewTextBoxColumn.DataPropertyName = "orgTechID";
            this.orgTechIDDataGridViewTextBoxColumn.HeaderText = "orgTechID";
            this.orgTechIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orgTechIDDataGridViewTextBoxColumn.Name = "orgTechIDDataGridViewTextBoxColumn";
            this.orgTechIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // problemDescriptionDataGridViewTextBoxColumn
            // 
            this.problemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "problemDescription";
            this.problemDescriptionDataGridViewTextBoxColumn.HeaderText = "problemDescription";
            this.problemDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.problemDescriptionDataGridViewTextBoxColumn.Name = "problemDescriptionDataGridViewTextBoxColumn";
            this.problemDescriptionDataGridViewTextBoxColumn.Width = 110;
            // 
            // statusIDDataGridViewTextBoxColumn
            // 
            this.statusIDDataGridViewTextBoxColumn.DataPropertyName = "statusID";
            this.statusIDDataGridViewTextBoxColumn.HeaderText = "statusID";
            this.statusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusIDDataGridViewTextBoxColumn.Name = "statusIDDataGridViewTextBoxColumn";
            this.statusIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // completionDateDataGridViewTextBoxColumn
            // 
            this.completionDateDataGridViewTextBoxColumn.DataPropertyName = "completionDate";
            this.completionDateDataGridViewTextBoxColumn.HeaderText = "completionDate";
            this.completionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.completionDateDataGridViewTextBoxColumn.Name = "completionDateDataGridViewTextBoxColumn";
            this.completionDateDataGridViewTextBoxColumn.Width = 110;
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            this.partIDDataGridViewTextBoxColumn.DataPropertyName = "partID";
            this.partIDDataGridViewTextBoxColumn.HeaderText = "partID";
            this.partIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            this.partIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // masterIDDataGridViewTextBoxColumn
            // 
            this.masterIDDataGridViewTextBoxColumn.DataPropertyName = "masterID";
            this.masterIDDataGridViewTextBoxColumn.HeaderText = "masterID";
            this.masterIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masterIDDataGridViewTextBoxColumn.Name = "masterIDDataGridViewTextBoxColumn";
            this.masterIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "clientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "clientID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.repairBDDataSetBindingSource;
            // 
            // repairBDDataSetBindingSource
            // 
            this.repairBDDataSetBindingSource.DataSource = this.repairBDDataSet;
            this.repairBDDataSetBindingSource.Position = 0;
            // 
            // repairBDDataSet
            // 
            this.repairBDDataSet.DataSetName = "RepairBDDataSet";
            this.repairBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.demoExDataSetBindingSource;
            // 
            // demoExDataSetBindingSource
            // 
            this.demoExDataSetBindingSource.DataSource = this.demoExDataSet;
            this.demoExDataSetBindingSource.Position = 0;
            // 
            // demoExDataSet
            // 
            this.demoExDataSet.DataSetName = "DemoExDataSet";
            this.demoExDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.demoExDataSetBindingSource;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(101, 51);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск:";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // radioButtonAZ
            // 
            this.radioButtonAZ.AutoSize = true;
            this.radioButtonAZ.Location = new System.Drawing.Point(469, 54);
            this.radioButtonAZ.Name = "radioButtonAZ";
            this.radioButtonAZ.Size = new System.Drawing.Size(42, 17);
            this.radioButtonAZ.TabIndex = 5;
            this.radioButtonAZ.TabStop = true;
            this.radioButtonAZ.Text = "A-Z";
            this.radioButtonAZ.UseVisualStyleBackColor = true;
            this.radioButtonAZ.CheckedChanged += new System.EventHandler(this.radioButtonAZ_CheckedChanged);
            // 
            // radioButtonZA
            // 
            this.radioButtonZA.AutoSize = true;
            this.radioButtonZA.Location = new System.Drawing.Point(576, 54);
            this.radioButtonZA.Name = "radioButtonZA";
            this.radioButtonZA.Size = new System.Drawing.Size(42, 17);
            this.radioButtonZA.TabIndex = 6;
            this.radioButtonZA.TabStop = true;
            this.radioButtonZA.Text = "Z-A";
            this.radioButtonZA.UseVisualStyleBackColor = true;
            this.radioButtonZA.CheckedChanged += new System.EventHandler(this.radioButtonZA_CheckedChanged);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(67, 351);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUser.TabIndex = 7;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonEditRequest
            // 
            this.buttonEditRequest.Location = new System.Drawing.Point(170, 351);
            this.buttonEditRequest.Name = "buttonEditRequest";
            this.buttonEditRequest.Size = new System.Drawing.Size(75, 23);
            this.buttonEditRequest.TabIndex = 8;
            this.buttonEditRequest.Text = "Изменить";
            this.buttonEditRequest.UseVisualStyleBackColor = true;
            this.buttonEditRequest.Click += new System.EventHandler(this.buttonEditRequest_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(270, 351);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 454);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEditRequest);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.radioButtonZA);
            this.Controls.Add(this.radioButtonAZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoExDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoExDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource demoExDataSetBindingSource;
        private DemoExDataSet demoExDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DemoExDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DemoExDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.RadioButton radioButtonAZ;
        private System.Windows.Forms.RadioButton radioButtonZA;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonEditRequest;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.BindingSource repairBDDataSetBindingSource;
        private RepairBDDataSet repairBDDataSet;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private RepairBDDataSetTableAdapters.RequestsTableAdapter requestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgTechIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
    }
}