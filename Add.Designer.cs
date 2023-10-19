namespace _32.Connecting_Library_Application_to_SQL_Server
{
    partial class Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitleType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPublishDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboPublisherID = new System.Windows.Forms.ComboBox();
            this.pubsDataSet = new _32.Connecting_Library_Application_to_SQL_Server.pubsDataSet();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publishersTableAdapter = new _32.Connecting_Library_Application_to_SQL_Server.pubsDataSetTableAdapters.publishersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title ID";
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(331, 38);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(139, 22);
            this.txtTitleID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title Name";
            // 
            // txtTitleName
            // 
            this.txtTitleName.Location = new System.Drawing.Point(331, 91);
            this.txtTitleName.Name = "txtTitleName";
            this.txtTitleName.Size = new System.Drawing.Size(139, 22);
            this.txtTitleName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title Type";
            // 
            // txtTitleType
            // 
            this.txtTitleType.Location = new System.Drawing.Point(331, 141);
            this.txtTitleType.Name = "txtTitleType";
            this.txtTitleType.Size = new System.Drawing.Size(139, 22);
            this.txtTitleType.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(331, 237);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(139, 22);
            this.txtPrice.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Publish Date";
            // 
            // txtPublishDate
            // 
            this.txtPublishDate.Location = new System.Drawing.Point(331, 292);
            this.txtPublishDate.Name = "txtPublishDate";
            this.txtPublishDate.Size = new System.Drawing.Size(139, 22);
            this.txtPublishDate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Publisher ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(255, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboPublisherID
            // 
            this.comboPublisherID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.publishersBindingSource, "pub_name", true));
            this.comboPublisherID.DataSource = this.publishersBindingSource;
            this.comboPublisherID.DisplayMember = "pub_id";
            this.comboPublisherID.FormattingEnabled = true;
            this.comboPublisherID.Location = new System.Drawing.Point(331, 186);
            this.comboPublisherID.Name = "comboPublisherID";
            this.comboPublisherID.Size = new System.Drawing.Size(139, 24);
            this.comboPublisherID.TabIndex = 4;
            this.comboPublisherID.ValueMember = "pub_id";
            // 
            // pubsDataSet
            // 
            this.pubsDataSet.DataSetName = "pubsDataSet";
            this.pubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "publishers";
            this.publishersBindingSource.DataSource = this.pubsDataSet;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.comboPublisherID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPublishDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitleType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitleName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitleID);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitleType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPublishDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboPublisherID;
        private pubsDataSet pubsDataSet;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private pubsDataSetTableAdapters.publishersTableAdapter publishersTableAdapter;
    }
}