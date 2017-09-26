namespace DownLoad
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnImportDataList = new System.Windows.Forms.Button();
            this.btnGetLocalList = new System.Windows.Forms.Button();
            this.btnSelectFilePath = new System.Windows.Forms.Button();
            this.btnStartDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaveFilePath = new System.Windows.Forms.TextBox();
            this.btnExportDataList = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnGetDataList = new System.Windows.Forms.Button();
            this.dgvAllData = new System.Windows.Forms.DataGridView();
            this.cbUsePro = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllData)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbUsePro);
            this.splitContainer1.Panel1.Controls.Add(this.btnImportDataList);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetLocalList);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectFilePath);
            this.splitContainer1.Panel1.Controls.Add(this.btnStartDownload);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSaveFilePath);
            this.splitContainer1.Panel1.Controls.Add(this.btnExportDataList);
            this.splitContainer1.Panel1.Controls.Add(this.lblPassword);
            this.splitContainer1.Panel1.Controls.Add(this.lblUserName);
            this.splitContainer1.Panel1.Controls.Add(this.txtPassword);
            this.splitContainer1.Panel1.Controls.Add(this.txtUserName);
            this.splitContainer1.Panel1.Controls.Add(this.btnLogin);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetDataList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAllData);
            this.splitContainer1.Size = new System.Drawing.Size(1667, 776);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnImportDataList
            // 
            this.btnImportDataList.Location = new System.Drawing.Point(387, 231);
            this.btnImportDataList.Name = "btnImportDataList";
            this.btnImportDataList.Size = new System.Drawing.Size(95, 23);
            this.btnImportDataList.TabIndex = 13;
            this.btnImportDataList.Text = "导入数据列表";
            this.btnImportDataList.UseVisualStyleBackColor = true;
            this.btnImportDataList.Visible = false;
            this.btnImportDataList.Click += new System.EventHandler(this.btnImportDataList_Click);
            // 
            // btnGetLocalList
            // 
            this.btnGetLocalList.Location = new System.Drawing.Point(271, 231);
            this.btnGetLocalList.Name = "btnGetLocalList";
            this.btnGetLocalList.Size = new System.Drawing.Size(108, 23);
            this.btnGetLocalList.TabIndex = 12;
            this.btnGetLocalList.Text = "获取本地列表";
            this.btnGetLocalList.UseVisualStyleBackColor = true;
            this.btnGetLocalList.Click += new System.EventHandler(this.btnGetLocalList_Click);
            // 
            // btnSelectFilePath
            // 
            this.btnSelectFilePath.Location = new System.Drawing.Point(387, 96);
            this.btnSelectFilePath.Name = "btnSelectFilePath";
            this.btnSelectFilePath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFilePath.TabIndex = 10;
            this.btnSelectFilePath.Text = "...";
            this.btnSelectFilePath.UseVisualStyleBackColor = true;
            this.btnSelectFilePath.Click += new System.EventHandler(this.btnSelectFilePath_Click);
            // 
            // btnStartDownload
            // 
            this.btnStartDownload.Location = new System.Drawing.Point(89, 231);
            this.btnStartDownload.Name = "btnStartDownload";
            this.btnStartDownload.Size = new System.Drawing.Size(75, 23);
            this.btnStartDownload.TabIndex = 9;
            this.btnStartDownload.Text = "下载";
            this.btnStartDownload.UseVisualStyleBackColor = true;
            this.btnStartDownload.Click += new System.EventHandler(this.btnStartDownload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "保存路径:";
            // 
            // txtSaveFilePath
            // 
            this.txtSaveFilePath.Location = new System.Drawing.Point(89, 96);
            this.txtSaveFilePath.Name = "txtSaveFilePath";
            this.txtSaveFilePath.ReadOnly = true;
            this.txtSaveFilePath.Size = new System.Drawing.Size(246, 21);
            this.txtSaveFilePath.TabIndex = 7;
            // 
            // btnExportDataList
            // 
            this.btnExportDataList.Location = new System.Drawing.Point(170, 231);
            this.btnExportDataList.Name = "btnExportDataList";
            this.btnExportDataList.Size = new System.Drawing.Size(95, 23);
            this.btnExportDataList.TabIndex = 6;
            this.btnExportDataList.Text = "导出下载列表";
            this.btnExportDataList.UseVisualStyleBackColor = true;
            this.btnExportDataList.Click += new System.EventHandler(this.btnExportDataList_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(22, 57);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(47, 12);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "密  码:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(22, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(47, 12);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "用户名:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(89, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(246, 21);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "sufan2008300379";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(89, 21);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(246, 21);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "sufan_89@hotmail.com";
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(387, 35);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnGetDataList
            // 
            this.btnGetDataList.Location = new System.Drawing.Point(7, 231);
            this.btnGetDataList.Name = "btnGetDataList";
            this.btnGetDataList.Size = new System.Drawing.Size(75, 23);
            this.btnGetDataList.TabIndex = 0;
            this.btnGetDataList.Text = "获取列表";
            this.btnGetDataList.UseVisualStyleBackColor = true;
            this.btnGetDataList.Click += new System.EventHandler(this.btnGetDataList_Click);
            // 
            // dgvAllData
            // 
            this.dgvAllData.AllowUserToAddRows = false;
            this.dgvAllData.AllowUserToDeleteRows = false;
            this.dgvAllData.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllData.Location = new System.Drawing.Point(0, 0);
            this.dgvAllData.Name = "dgvAllData";
            this.dgvAllData.ReadOnly = true;
            this.dgvAllData.RowTemplate.Height = 23;
            this.dgvAllData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllData.Size = new System.Drawing.Size(1667, 503);
            this.dgvAllData.TabIndex = 1;
            // 
            // cbUsePro
            // 
            this.cbUsePro.AutoSize = true;
            this.cbUsePro.Location = new System.Drawing.Point(503, 35);
            this.cbUsePro.Name = "cbUsePro";
            this.cbUsePro.Size = new System.Drawing.Size(72, 16);
            this.cbUsePro.TabIndex = 16;
            this.cbUsePro.Text = "使用代理";
            this.cbUsePro.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 776);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "下载DEM数据";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnGetDataList;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnExportDataList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaveFilePath;
        private System.Windows.Forms.Button btnStartDownload;
        private System.Windows.Forms.DataGridView dgvAllData;
        private System.Windows.Forms.Button btnSelectFilePath;
        private System.Windows.Forms.Button btnGetLocalList;
        private System.Windows.Forms.Button btnImportDataList;
        private System.Windows.Forms.CheckBox cbUsePro;
    }
}

