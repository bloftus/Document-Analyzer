namespace WindowsFormsApp1
{
    partial class OptionsForm
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
            this.groupBold = new System.Windows.Forms.GroupBox();
            this.radBold = new System.Windows.Forms.RadioButton();
            this.radNoBold = new System.Windows.Forms.RadioButton();
            this.grpSpacing = new System.Windows.Forms.GroupBox();
            this.radNoSpacing = new System.Windows.Forms.RadioButton();
            this.radSpacing = new System.Windows.Forms.RadioButton();
            this.radNoIndent = new System.Windows.Forms.RadioButton();
            this.radIndent = new System.Windows.Forms.RadioButton();
            this.groupIndent = new System.Windows.Forms.GroupBox();
            this.groupFont = new System.Windows.Forms.GroupBox();
            this.radNoFont = new System.Windows.Forms.RadioButton();
            this.radFont = new System.Windows.Forms.RadioButton();
            this.groupKeepWithNext = new System.Windows.Forms.GroupBox();
            this.radNoKeepWithNext = new System.Windows.Forms.RadioButton();
            this.radKeepWithNext = new System.Windows.Forms.RadioButton();
            this.groupKeepTogether = new System.Windows.Forms.GroupBox();
            this.radNoKeepTogether = new System.Windows.Forms.RadioButton();
            this.radKeepTogether = new System.Windows.Forms.RadioButton();
            this.btnCloseOptions = new System.Windows.Forms.Button();
            this.groupBullets = new System.Windows.Forms.GroupBox();
            this.radNoBullet = new System.Windows.Forms.RadioButton();
            this.radBullet = new System.Windows.Forms.RadioButton();
            this.groupBold.SuspendLayout();
            this.grpSpacing.SuspendLayout();
            this.groupIndent.SuspendLayout();
            this.groupFont.SuspendLayout();
            this.groupKeepWithNext.SuspendLayout();
            this.groupKeepTogether.SuspendLayout();
            this.groupBullets.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toggle On or Off the formatting that will be output to your document.";
            // 
            // groupBold
            // 
            this.groupBold.Controls.Add(this.radNoBold);
            this.groupBold.Controls.Add(this.radBold);
            this.groupBold.Location = new System.Drawing.Point(20, 64);
            this.groupBold.Name = "groupBold";
            this.groupBold.Padding = new System.Windows.Forms.Padding(0);
            this.groupBold.Size = new System.Drawing.Size(101, 40);
            this.groupBold.TabIndex = 1;
            this.groupBold.TabStop = false;
            this.groupBold.Text = "Bold";
            // 
            // radBold
            // 
            this.radBold.AutoSize = true;
            this.radBold.Checked = true;
            this.radBold.Location = new System.Drawing.Point(7, 15);
            this.radBold.Name = "radBold";
            this.radBold.Size = new System.Drawing.Size(43, 17);
            this.radBold.TabIndex = 0;
            this.radBold.TabStop = true;
            this.radBold.Text = "Yes";
            this.radBold.UseVisualStyleBackColor = true;
            // 
            // radNoBold
            // 
            this.radNoBold.AutoSize = true;
            this.radNoBold.Location = new System.Drawing.Point(57, 15);
            this.radNoBold.Name = "radNoBold";
            this.radNoBold.Size = new System.Drawing.Size(39, 17);
            this.radNoBold.TabIndex = 1;
            this.radNoBold.Text = "No";
            this.radNoBold.UseVisualStyleBackColor = true;
            // 
            // grpSpacing
            // 
            this.grpSpacing.Controls.Add(this.radNoSpacing);
            this.grpSpacing.Controls.Add(this.radSpacing);
            this.grpSpacing.Location = new System.Drawing.Point(20, 205);
            this.grpSpacing.Name = "grpSpacing";
            this.grpSpacing.Padding = new System.Windows.Forms.Padding(0);
            this.grpSpacing.Size = new System.Drawing.Size(101, 40);
            this.grpSpacing.TabIndex = 2;
            this.grpSpacing.TabStop = false;
            this.grpSpacing.Text = "Spacing";
            // 
            // radNoSpacing
            // 
            this.radNoSpacing.AutoSize = true;
            this.radNoSpacing.Location = new System.Drawing.Point(57, 15);
            this.radNoSpacing.Name = "radNoSpacing";
            this.radNoSpacing.Size = new System.Drawing.Size(39, 17);
            this.radNoSpacing.TabIndex = 1;
            this.radNoSpacing.Text = "No";
            this.radNoSpacing.UseVisualStyleBackColor = true;
            // 
            // radSpacing
            // 
            this.radSpacing.AutoSize = true;
            this.radSpacing.Checked = true;
            this.radSpacing.Location = new System.Drawing.Point(7, 15);
            this.radSpacing.Name = "radSpacing";
            this.radSpacing.Size = new System.Drawing.Size(43, 17);
            this.radSpacing.TabIndex = 0;
            this.radSpacing.TabStop = true;
            this.radSpacing.Text = "Yes";
            this.radSpacing.UseVisualStyleBackColor = true;
            // 
            // radNoIndent
            // 
            this.radNoIndent.AutoSize = true;
            this.radNoIndent.Location = new System.Drawing.Point(57, 15);
            this.radNoIndent.Name = "radNoIndent";
            this.radNoIndent.Size = new System.Drawing.Size(39, 17);
            this.radNoIndent.TabIndex = 1;
            this.radNoIndent.Text = "No";
            this.radNoIndent.UseVisualStyleBackColor = true;
            // 
            // radIndent
            // 
            this.radIndent.AutoSize = true;
            this.radIndent.Checked = true;
            this.radIndent.Location = new System.Drawing.Point(7, 15);
            this.radIndent.Name = "radIndent";
            this.radIndent.Size = new System.Drawing.Size(43, 17);
            this.radIndent.TabIndex = 0;
            this.radIndent.TabStop = true;
            this.radIndent.Text = "Yes";
            this.radIndent.UseVisualStyleBackColor = true;
            // 
            // groupIndent
            // 
            this.groupIndent.Controls.Add(this.radNoIndent);
            this.groupIndent.Controls.Add(this.radIndent);
            this.groupIndent.Location = new System.Drawing.Point(20, 158);
            this.groupIndent.Name = "groupIndent";
            this.groupIndent.Padding = new System.Windows.Forms.Padding(0);
            this.groupIndent.Size = new System.Drawing.Size(101, 40);
            this.groupIndent.TabIndex = 3;
            this.groupIndent.TabStop = false;
            this.groupIndent.Text = "Indent";
            // 
            // groupFont
            // 
            this.groupFont.Controls.Add(this.radNoFont);
            this.groupFont.Controls.Add(this.radFont);
            this.groupFont.Location = new System.Drawing.Point(20, 111);
            this.groupFont.Name = "groupFont";
            this.groupFont.Padding = new System.Windows.Forms.Padding(0);
            this.groupFont.Size = new System.Drawing.Size(101, 40);
            this.groupFont.TabIndex = 4;
            this.groupFont.TabStop = false;
            this.groupFont.Text = "Font Size";
            // 
            // radNoFont
            // 
            this.radNoFont.AutoSize = true;
            this.radNoFont.Location = new System.Drawing.Point(57, 15);
            this.radNoFont.Name = "radNoFont";
            this.radNoFont.Size = new System.Drawing.Size(39, 17);
            this.radNoFont.TabIndex = 1;
            this.radNoFont.Text = "No";
            this.radNoFont.UseVisualStyleBackColor = true;
            // 
            // radFont
            // 
            this.radFont.AutoSize = true;
            this.radFont.Checked = true;
            this.radFont.Location = new System.Drawing.Point(7, 15);
            this.radFont.Name = "radFont";
            this.radFont.Size = new System.Drawing.Size(43, 17);
            this.radFont.TabIndex = 0;
            this.radFont.TabStop = true;
            this.radFont.Text = "Yes";
            this.radFont.UseVisualStyleBackColor = true;
            // 
            // groupKeepWithNext
            // 
            this.groupKeepWithNext.Controls.Add(this.radNoKeepWithNext);
            this.groupKeepWithNext.Controls.Add(this.radKeepWithNext);
            this.groupKeepWithNext.Location = new System.Drawing.Point(20, 252);
            this.groupKeepWithNext.Name = "groupKeepWithNext";
            this.groupKeepWithNext.Padding = new System.Windows.Forms.Padding(0);
            this.groupKeepWithNext.Size = new System.Drawing.Size(101, 40);
            this.groupKeepWithNext.TabIndex = 5;
            this.groupKeepWithNext.TabStop = false;
            this.groupKeepWithNext.Text = "Keep With Next";
            // 
            // radNoKeepWithNext
            // 
            this.radNoKeepWithNext.AutoSize = true;
            this.radNoKeepWithNext.Location = new System.Drawing.Point(57, 15);
            this.radNoKeepWithNext.Name = "radNoKeepWithNext";
            this.radNoKeepWithNext.Size = new System.Drawing.Size(39, 17);
            this.radNoKeepWithNext.TabIndex = 1;
            this.radNoKeepWithNext.Text = "No";
            this.radNoKeepWithNext.UseVisualStyleBackColor = true;
            // 
            // radKeepWithNext
            // 
            this.radKeepWithNext.AutoSize = true;
            this.radKeepWithNext.Checked = true;
            this.radKeepWithNext.Location = new System.Drawing.Point(7, 15);
            this.radKeepWithNext.Name = "radKeepWithNext";
            this.radKeepWithNext.Size = new System.Drawing.Size(43, 17);
            this.radKeepWithNext.TabIndex = 0;
            this.radKeepWithNext.TabStop = true;
            this.radKeepWithNext.Text = "Yes";
            this.radKeepWithNext.UseVisualStyleBackColor = true;
            // 
            // groupKeepTogether
            // 
            this.groupKeepTogether.Controls.Add(this.radNoKeepTogether);
            this.groupKeepTogether.Controls.Add(this.radKeepTogether);
            this.groupKeepTogether.Location = new System.Drawing.Point(20, 299);
            this.groupKeepTogether.Name = "groupKeepTogether";
            this.groupKeepTogether.Padding = new System.Windows.Forms.Padding(0);
            this.groupKeepTogether.Size = new System.Drawing.Size(101, 40);
            this.groupKeepTogether.TabIndex = 6;
            this.groupKeepTogether.TabStop = false;
            this.groupKeepTogether.Text = "Keep Together";
            // 
            // radNoKeepTogether
            // 
            this.radNoKeepTogether.AutoSize = true;
            this.radNoKeepTogether.Location = new System.Drawing.Point(57, 15);
            this.radNoKeepTogether.Name = "radNoKeepTogether";
            this.radNoKeepTogether.Size = new System.Drawing.Size(39, 17);
            this.radNoKeepTogether.TabIndex = 1;
            this.radNoKeepTogether.Text = "No";
            this.radNoKeepTogether.UseVisualStyleBackColor = true;
            // 
            // radKeepTogether
            // 
            this.radKeepTogether.AutoSize = true;
            this.radKeepTogether.Checked = true;
            this.radKeepTogether.Location = new System.Drawing.Point(7, 15);
            this.radKeepTogether.Name = "radKeepTogether";
            this.radKeepTogether.Size = new System.Drawing.Size(43, 17);
            this.radKeepTogether.TabIndex = 0;
            this.radKeepTogether.TabStop = true;
            this.radKeepTogether.Text = "Yes";
            this.radKeepTogether.UseVisualStyleBackColor = true;
            // 
            // btnCloseOptions
            // 
            this.btnCloseOptions.Location = new System.Drawing.Point(33, 393);
            this.btnCloseOptions.Name = "btnCloseOptions";
            this.btnCloseOptions.Size = new System.Drawing.Size(75, 23);
            this.btnCloseOptions.TabIndex = 7;
            this.btnCloseOptions.Text = "Close";
            this.btnCloseOptions.UseVisualStyleBackColor = true;
            // 
            // groupBullets
            // 
            this.groupBullets.Controls.Add(this.radNoBullet);
            this.groupBullets.Controls.Add(this.radBullet);
            this.groupBullets.Location = new System.Drawing.Point(20, 346);
            this.groupBullets.Name = "groupBullets";
            this.groupBullets.Padding = new System.Windows.Forms.Padding(0);
            this.groupBullets.Size = new System.Drawing.Size(101, 40);
            this.groupBullets.TabIndex = 7;
            this.groupBullets.TabStop = false;
            this.groupBullets.Text = "Bullet";
            // 
            // radNoBullet
            // 
            this.radNoBullet.AutoSize = true;
            this.radNoBullet.Location = new System.Drawing.Point(57, 15);
            this.radNoBullet.Name = "radNoBullet";
            this.radNoBullet.Size = new System.Drawing.Size(39, 17);
            this.radNoBullet.TabIndex = 1;
            this.radNoBullet.Text = "No";
            this.radNoBullet.UseVisualStyleBackColor = true;
            // 
            // radBullet
            // 
            this.radBullet.AutoSize = true;
            this.radBullet.Checked = true;
            this.radBullet.Location = new System.Drawing.Point(7, 15);
            this.radBullet.Name = "radBullet";
            this.radBullet.Size = new System.Drawing.Size(43, 17);
            this.radBullet.TabIndex = 0;
            this.radBullet.TabStop = true;
            this.radBullet.Text = "Yes";
            this.radBullet.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCloseOptions;
            this.ClientSize = new System.Drawing.Size(141, 434);
            this.Controls.Add(this.groupBullets);
            this.Controls.Add(this.btnCloseOptions);
            this.Controls.Add(this.groupKeepTogether);
            this.Controls.Add(this.groupKeepWithNext);
            this.Controls.Add(this.groupFont);
            this.Controls.Add(this.groupIndent);
            this.Controls.Add(this.grpSpacing);
            this.Controls.Add(this.groupBold);
            this.Controls.Add(this.label1);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.groupBold.ResumeLayout(false);
            this.groupBold.PerformLayout();
            this.grpSpacing.ResumeLayout(false);
            this.grpSpacing.PerformLayout();
            this.groupIndent.ResumeLayout(false);
            this.groupIndent.PerformLayout();
            this.groupFont.ResumeLayout(false);
            this.groupFont.PerformLayout();
            this.groupKeepWithNext.ResumeLayout(false);
            this.groupKeepWithNext.PerformLayout();
            this.groupKeepTogether.ResumeLayout(false);
            this.groupKeepTogether.PerformLayout();
            this.groupBullets.ResumeLayout(false);
            this.groupBullets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBold;
        private System.Windows.Forms.RadioButton radBold;
        private System.Windows.Forms.RadioButton radNoBold;
        private System.Windows.Forms.GroupBox grpSpacing;
        private System.Windows.Forms.RadioButton radNoSpacing;
        private System.Windows.Forms.RadioButton radSpacing;
        private System.Windows.Forms.RadioButton radNoIndent;
        private System.Windows.Forms.RadioButton radIndent;
        private System.Windows.Forms.GroupBox groupIndent;
        private System.Windows.Forms.GroupBox groupFont;
        private System.Windows.Forms.RadioButton radNoFont;
        private System.Windows.Forms.RadioButton radFont;
        private System.Windows.Forms.GroupBox groupKeepWithNext;
        private System.Windows.Forms.RadioButton radNoKeepWithNext;
        private System.Windows.Forms.RadioButton radKeepWithNext;
        private System.Windows.Forms.GroupBox groupKeepTogether;
        private System.Windows.Forms.RadioButton radNoKeepTogether;
        private System.Windows.Forms.RadioButton radKeepTogether;
        private System.Windows.Forms.Button btnCloseOptions;
        private System.Windows.Forms.GroupBox groupBullets;
        private System.Windows.Forms.RadioButton radNoBullet;
        private System.Windows.Forms.RadioButton radBullet;
    }
}