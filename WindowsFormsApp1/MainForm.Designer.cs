namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocDir = new System.Windows.Forms.TextBox();
            this.btnSelectDocDir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectOutputDir = new System.Windows.Forms.Button();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.btnAnalyzeDocs = new System.Windows.Forms.Button();
            this.btnLoadList = new System.Windows.Forms.Button();
            this.btnExportMacro = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportList = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory with Documents:";
            // 
            // txtDocDir
            // 
            this.txtDocDir.Location = new System.Drawing.Point(13, 49);
            this.txtDocDir.Name = "txtDocDir";
            this.txtDocDir.Size = new System.Drawing.Size(374, 20);
            this.txtDocDir.TabIndex = 1;
            // 
            // btnSelectDocDir
            // 
            this.btnSelectDocDir.Location = new System.Drawing.Point(396, 48);
            this.btnSelectDocDir.Name = "btnSelectDocDir";
            this.btnSelectDocDir.Size = new System.Drawing.Size(32, 23);
            this.btnSelectDocDir.TabIndex = 2;
            this.btnSelectDocDir.Text = "...";
            this.btnSelectDocDir.UseVisualStyleBackColor = true;
            this.btnSelectDocDir.Click += new System.EventHandler(this.btnSelectDocDir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output Directory";
            // 
            // btnSelectOutputDir
            // 
            this.btnSelectOutputDir.Location = new System.Drawing.Point(396, 94);
            this.btnSelectOutputDir.Name = "btnSelectOutputDir";
            this.btnSelectOutputDir.Size = new System.Drawing.Size(32, 23);
            this.btnSelectOutputDir.TabIndex = 5;
            this.btnSelectOutputDir.Text = "...";
            this.btnSelectOutputDir.UseVisualStyleBackColor = true;
            this.btnSelectOutputDir.Click += new System.EventHandler(this.btnSelectOutputDir_Click);
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Location = new System.Drawing.Point(12, 95);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(374, 20);
            this.txtOutputDir.TabIndex = 4;
            // 
            // btnAnalyzeDocs
            // 
            this.btnAnalyzeDocs.Location = new System.Drawing.Point(13, 127);
            this.btnAnalyzeDocs.Name = "btnAnalyzeDocs";
            this.btnAnalyzeDocs.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyzeDocs.TabIndex = 7;
            this.btnAnalyzeDocs.Text = "Analyze";
            this.btnAnalyzeDocs.UseVisualStyleBackColor = true;
            this.btnAnalyzeDocs.Click += new System.EventHandler(this.btnAnalyzeDocs_Click);
            // 
            // btnLoadList
            // 
            this.btnLoadList.Location = new System.Drawing.Point(94, 127);
            this.btnLoadList.Name = "btnLoadList";
            this.btnLoadList.Size = new System.Drawing.Size(75, 23);
            this.btnLoadList.TabIndex = 8;
            this.btnLoadList.Text = "Load List";
            this.btnLoadList.UseVisualStyleBackColor = true;
            this.btnLoadList.Click += new System.EventHandler(this.btnLoadList_Click);
            // 
            // btnExportMacro
            // 
            this.btnExportMacro.Location = new System.Drawing.Point(256, 127);
            this.btnExportMacro.Name = "btnExportMacro";
            this.btnExportMacro.Size = new System.Drawing.Size(91, 23);
            this.btnExportMacro.TabIndex = 12;
            this.btnExportMacro.Text = "Export Macro File";
            this.btnExportMacro.UseVisualStyleBackColor = true;
            this.btnExportMacro.Click += new System.EventHandler(this.btnExportMacro_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // btnExportList
            // 
            this.btnExportList.Location = new System.Drawing.Point(175, 127);
            this.btnExportList.Name = "btnExportList";
            this.btnExportList.Size = new System.Drawing.Size(75, 23);
            this.btnExportList.TabIndex = 14;
            this.btnExportList.Text = "Export List";
            this.btnExportList.UseVisualStyleBackColor = true;
            this.btnExportList.Click += new System.EventHandler(this.btnExportList_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(365, 127);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "label3";
            this.lblStatus.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 162);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnExportList);
            this.Controls.Add(this.btnExportMacro);
            this.Controls.Add(this.btnLoadList);
            this.Controls.Add(this.btnAnalyzeDocs);
            this.Controls.Add(this.btnSelectOutputDir);
            this.Controls.Add(this.txtOutputDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectDocDir);
            this.Controls.Add(this.txtDocDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Document Analyzer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocDir;
        private System.Windows.Forms.Button btnSelectDocDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectOutputDir;
        private System.Windows.Forms.TextBox txtOutputDir;
        private System.Windows.Forms.Button btnAnalyzeDocs;
        private System.Windows.Forms.Button btnLoadList;
        private System.Windows.Forms.Button btnExportMacro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnExportList;
        private System.Windows.Forms.Label lblStatus;
    }
}

