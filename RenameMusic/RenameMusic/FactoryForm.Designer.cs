namespace RenameMusic
{
    partial class FactoryForm
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
            this.labelAddFile = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.txtBoxFile = new System.Windows.Forms.TextBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.labTime = new System.Windows.Forms.Label();
            this.listFileName = new System.Windows.Forms.ListBox();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAddFile
            // 
            this.labelAddFile.AutoSize = true;
            this.labelAddFile.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAddFile.Location = new System.Drawing.Point(12, 32);
            this.labelAddFile.Name = "labelAddFile";
            this.labelAddFile.Size = new System.Drawing.Size(79, 20);
            this.labelAddFile.TabIndex = 1;
            this.labelAddFile.Text = "添加文件夹";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 351);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始改名";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(132, 351);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // txtBoxFile
            // 
            this.txtBoxFile.Location = new System.Drawing.Point(162, 31);
            this.txtBoxFile.Name = "txtBoxFile";
            this.txtBoxFile.Size = new System.Drawing.Size(168, 21);
            this.txtBoxFile.TabIndex = 6;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(347, 29);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddFile.TabIndex = 8;
            this.btnAddFile.Text = "添加";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(14, 287);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(0, 12);
            this.labTime.TabIndex = 9;
            this.labTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // listFileName
            // 
            this.listFileName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listFileName.FormattingEnabled = true;
            this.listFileName.ItemHeight = 17;
            this.listFileName.Location = new System.Drawing.Point(16, 124);
            this.listFileName.Name = "listFileName";
            this.listFileName.ScrollAlwaysVisible = true;
            this.listFileName.Size = new System.Drawing.Size(406, 140);
            this.listFileName.TabIndex = 13;
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFileCount.Location = new System.Drawing.Point(13, 82);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(0, 17);
            this.lblFileCount.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(240, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "作者：强子";
            // 
            // FactoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFileCount);
            this.Controls.Add(this.listFileName);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.txtBoxFile);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelAddFile);
            this.Name = "FactoryForm";
            this.Text = "FaactoryForm";
            this.Load += new System.EventHandler(this.FactoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddFile;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox txtBoxFile;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.ListBox listFileName;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}