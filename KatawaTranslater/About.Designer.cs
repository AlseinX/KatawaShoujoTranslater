namespace KatawaTranslater
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblChinese = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.lblJapanese = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.flpContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::KatawaTranslater.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(503, 159);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblChinese
            // 
            this.lblChinese.AutoSize = true;
            this.lblChinese.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblChinese.Location = new System.Drawing.Point(5, 5);
            this.lblChinese.Margin = new System.Windows.Forms.Padding(5);
            this.lblChinese.Name = "lblChinese";
            this.lblChinese.Size = new System.Drawing.Size(299, 25);
            this.lblChinese.TabIndex = 1;
            this.lblChinese.Text = "片轮少女汉化专用翻译工具 v1.5.0";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEnglish.Location = new System.Drawing.Point(5, 40);
            this.lblEnglish.Margin = new System.Windows.Forms.Padding(5);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(448, 25);
            this.lblEnglish.TabIndex = 2;
            this.lblEnglish.Text = "Katawa Shoujo Chinese Localization Tool v1.5.0";
            // 
            // flpContent
            // 
            this.flpContent.BackColor = System.Drawing.Color.Transparent;
            this.flpContent.Controls.Add(this.lblChinese);
            this.flpContent.Controls.Add(this.lblEnglish);
            this.flpContent.Controls.Add(this.lblJapanese);
            this.flpContent.Location = new System.Drawing.Point(0, 151);
            this.flpContent.Margin = new System.Windows.Forms.Padding(5);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(503, 110);
            this.flpContent.TabIndex = 3;
            // 
            // lblJapanese
            // 
            this.lblJapanese.AutoSize = true;
            this.lblJapanese.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblJapanese.Location = new System.Drawing.Point(5, 75);
            this.lblJapanese.Margin = new System.Windows.Forms.Padding(5);
            this.lblJapanese.Name = "lblJapanese";
            this.lblJapanese.Size = new System.Drawing.Size(318, 25);
            this.lblJapanese.TabIndex = 3;
            this.lblJapanese.Text = "かたわ少女中国語翻訳ツール v1.5.0";
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::KatawaTranslater.Properties.Resources.Art2;
            this.pbIcon.Location = new System.Drawing.Point(10, 274);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(270, 270);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 4;
            this.pbIcon.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(416, 532);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "关闭";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblContent
            // 
            this.lblContent.BackColor = System.Drawing.SystemColors.Control;
            this.lblContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblContent.Location = new System.Drawing.Point(289, 272);
            this.lblContent.Multiline = true;
            this.lblContent.Name = "lblContent";
            this.lblContent.ReadOnly = true;
            this.lblContent.Size = new System.Drawing.Size(205, 270);
            this.lblContent.TabIndex = 6;
            this.lblContent.Text = resources.GetString("lblContent.Text");
            // 
            // About
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 559);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "About";
            this.Text = "关于";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.flpContent.ResumeLayout(false);
            this.flpContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblChinese;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
        private System.Windows.Forms.Label lblJapanese;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox lblContent;
    }
}