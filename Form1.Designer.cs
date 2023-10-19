namespace _32.Connecting_Library_Application_to_SQL_Server
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTitle = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabAuthors = new System.Windows.Forms.TabPage();
            this.tabPublishers = new System.Windows.Forms.TabPage();
            this.tabStores = new System.Windows.Forms.TabPage();
            this.pubsDataSet = new _32.Connecting_Library_Application_to_SQL_Server.pubsDataSet();
            this.pubsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pubsDataSet1 = new _32.Connecting_Library_Application_to_SQL_Server.pubsDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabMain.SuspendLayout();
            this.tabTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabTitle);
            this.tabMain.Controls.Add(this.tabAuthors);
            this.tabMain.Controls.Add(this.tabPublishers);
            this.tabMain.Controls.Add(this.tabStores);
            this.tabMain.Location = new System.Drawing.Point(2, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(796, 401);
            this.tabMain.TabIndex = 0;
            // 
            // tabTitle
            // 
            this.tabTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabTitle.Controls.Add(this.dataGridView1);
            this.tabTitle.Controls.Add(this.btnClose);
            this.tabTitle.Controls.Add(this.btnRefresh);
            this.tabTitle.Controls.Add(this.btnDelete);
            this.tabTitle.Controls.Add(this.btnEdit);
            this.tabTitle.Controls.Add(this.btnAdd);
            this.tabTitle.Location = new System.Drawing.Point(4, 25);
            this.tabTitle.Name = "tabTitle";
            this.tabTitle.Padding = new System.Windows.Forms.Padding(3);
            this.tabTitle.Size = new System.Drawing.Size(788, 372);
            this.tabTitle.TabIndex = 0;
            this.tabTitle.Text = "Titles";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 298);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(631, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(531, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 35);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(293, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 35);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(185, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 35);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(71, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabAuthors
            // 
            this.tabAuthors.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabAuthors.Controls.Add(this.dataGridView2);
            this.tabAuthors.Location = new System.Drawing.Point(4, 25);
            this.tabAuthors.Name = "tabAuthors";
            this.tabAuthors.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuthors.Size = new System.Drawing.Size(788, 372);
            this.tabAuthors.TabIndex = 1;
            this.tabAuthors.Text = "Authors";
            this.tabAuthors.Click += new System.EventHandler(this.tabAuthors_Click);
            // 
            // tabPublishers
            // 
            this.tabPublishers.Location = new System.Drawing.Point(4, 25);
            this.tabPublishers.Name = "tabPublishers";
            this.tabPublishers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPublishers.Size = new System.Drawing.Size(788, 372);
            this.tabPublishers.TabIndex = 2;
            this.tabPublishers.Text = "Publishers";
            this.tabPublishers.UseVisualStyleBackColor = true;
            // 
            // tabStores
            // 
            this.tabStores.Location = new System.Drawing.Point(4, 25);
            this.tabStores.Name = "tabStores";
            this.tabStores.Padding = new System.Windows.Forms.Padding(3);
            this.tabStores.Size = new System.Drawing.Size(788, 372);
            this.tabStores.TabIndex = 3;
            this.tabStores.Text = "Stores";
            this.tabStores.UseVisualStyleBackColor = true;
            // 
            // pubsDataSet
            // 
            this.pubsDataSet.DataSetName = "pubsDataSet";
            this.pubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pubsDataSetBindingSource
            // 
            this.pubsDataSetBindingSource.DataSource = this.pubsDataSet;
            this.pubsDataSetBindingSource.Position = 0;
            // 
            // pubsDataSet1
            // 
            this.pubsDataSet1.DataSetName = "pubsDataSet";
            this.pubsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(186, 99);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.Text = "Library Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabAuthors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTitle;
        private System.Windows.Forms.TabPage tabAuthors;
        private System.Windows.Forms.TabPage tabPublishers;
        private System.Windows.Forms.TabPage tabStores;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pubsDataSetBindingSource;
        private pubsDataSet pubsDataSet;
        private pubsDataSet pubsDataSet1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

