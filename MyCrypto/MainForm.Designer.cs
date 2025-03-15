namespace MyCrypto
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            header = new Panel();
            settingBtn = new PictureBox();
            TransBtn = new Button();
            KeyBtn = new Button();
            HashBtn = new Button();
            mainLabel = new Label();
            panelContainer = new Panel();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settingBtn).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(24, 25, 26);
            header.Controls.Add(settingBtn);
            header.Controls.Add(TransBtn);
            header.Controls.Add(KeyBtn);
            header.Controls.Add(HashBtn);
            header.Controls.Add(mainLabel);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1262, 65);
            header.TabIndex = 0;
            // 
            // settingBtn
            // 
            settingBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            settingBtn.BackgroundImageLayout = ImageLayout.None;
            settingBtn.Image = (Image)resources.GetObject("settingBtn.Image");
            settingBtn.Location = new Point(1208, 17);
            settingBtn.Name = "settingBtn";
            settingBtn.Size = new Size(35, 35);
            settingBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            settingBtn.TabIndex = 2;
            settingBtn.TabStop = false;
            settingBtn.Click += settingBtn_Click;
            // 
            // TransBtn
            // 
            TransBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TransBtn.FlatStyle = FlatStyle.Flat;
            TransBtn.Font = new Font("#9Slide03 Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TransBtn.ForeColor = Color.White;
            TransBtn.Location = new Point(1085, 15);
            TransBtn.Name = "TransBtn";
            TransBtn.Size = new Size(110, 38);
            TransBtn.TabIndex = 3;
            TransBtn.Text = "Giao dịch";
            TransBtn.UseVisualStyleBackColor = true;
            TransBtn.Click += TransBtn_Click;
            // 
            // KeyBtn
            // 
            KeyBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            KeyBtn.FlatStyle = FlatStyle.Flat;
            KeyBtn.Font = new Font("#9Slide03 Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyBtn.ForeColor = Color.White;
            KeyBtn.Location = new Point(963, 15);
            KeyBtn.Name = "KeyBtn";
            KeyBtn.Size = new Size(109, 38);
            KeyBtn.TabIndex = 2;
            KeyBtn.Text = "Tạo khóa";
            KeyBtn.UseVisualStyleBackColor = true;
            KeyBtn.Click += KeyBtn_Click;
            // 
            // HashBtn
            // 
            HashBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            HashBtn.FlatStyle = FlatStyle.Flat;
            HashBtn.Font = new Font("#9Slide03 Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HashBtn.ForeColor = Color.White;
            HashBtn.Location = new Point(850, 15);
            HashBtn.Name = "HashBtn";
            HashBtn.Size = new Size(97, 38);
            HashBtn.TabIndex = 1;
            HashBtn.Text = "Mã Băm";
            HashBtn.UseVisualStyleBackColor = true;
            HashBtn.Click += HashBtn_Click;
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Playfair Display", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainLabel.ForeColor = Color.White;
            mainLabel.Location = new Point(12, 9);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(147, 38);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "MyBitcoin";
            mainLabel.Click += BlockchainLabel_Click;
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 65);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1262, 688);
            panelContainer.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1262, 753);
            Controls.Add(panelContainer);
            Controls.Add(header);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyBlockchain";
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)settingBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Label mainLabel;
        private Button HashBtn;
        private Button TransBtn;
        private PictureBox settingBtn;
        private Panel panelContainer;
        private Button KeyBtn;
    }
}
