namespace _32.Connecting_Library_Application_to_SQL_Server
{
    partial class Edit
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
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.txtTitleName = new System.Windows.Forms.TextBox();
            this.txtNewTitleType = new System.Windows.Forms.TextBox();
            this.txtNewTitleName = new System.Windows.Forms.TextBox();
            this.txtNewTitlePrice = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(170, 67);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(100, 22);
            this.txtTitleID.TabIndex = 0;
            // 
            // txtTitleName
            // 
            this.txtTitleName.Location = new System.Drawing.Point(170, 133);
            this.txtTitleName.Name = "txtTitleName";
            this.txtTitleName.Size = new System.Drawing.Size(100, 22);
            this.txtTitleName.TabIndex = 0;
            // 
            // txtNewTitleType
            // 
            this.txtNewTitleType.Location = new System.Drawing.Point(462, 133);
            this.txtNewTitleType.Name = "txtNewTitleType";
            this.txtNewTitleType.Size = new System.Drawing.Size(100, 22);
            this.txtNewTitleType.TabIndex = 0;
            // 
            // txtNewTitleName
            // 
            this.txtNewTitleName.Location = new System.Drawing.Point(462, 67);
            this.txtNewTitleName.Name = "txtNewTitleName";
            this.txtNewTitleName.Size = new System.Drawing.Size(100, 22);
            this.txtNewTitleName.TabIndex = 0;
            // 
            // txtNewTitlePrice
            // 
            this.txtNewTitlePrice.Location = new System.Drawing.Point(462, 214);
            this.txtNewTitlePrice.Name = "txtNewTitlePrice";
            this.txtNewTitlePrice.Size = new System.Drawing.Size(100, 22);
            this.txtNewTitlePrice.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(308, 316);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(66, 72);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 16);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Title Type";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(324, 67);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(103, 16);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "New Title Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "New Title Price";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 432);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtNewTitlePrice);
            this.Controls.Add(this.txtNewTitleName);
            this.Controls.Add(this.txtNewTitleType);
            this.Controls.Add(this.txtTitleName);
            this.Controls.Add(this.txtTitleID);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.TextBox txtTitleName;
        private System.Windows.Forms.TextBox txtNewTitleType;
        private System.Windows.Forms.TextBox txtNewTitleName;
        private System.Windows.Forms.TextBox txtNewTitlePrice;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label5;
    }
}