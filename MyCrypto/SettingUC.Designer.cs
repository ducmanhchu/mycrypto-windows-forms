namespace MyCrypto
{
    partial class SettingUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            settingtxt = new Label();
            mainpublickeytxt = new Label();
            MainPublicKeyInput = new TextBox();
            mainprivatekeytxt = new Label();
            MainPrivateKeyInput = new TextBox();
            SaveBtn = new Button();
            difficultytxt = new Label();
            DifficultyInput = new TextBox();
            label1 = new Label();
            RewardInput = new TextBox();
            ShowBtn = new Button();
            SuspendLayout();
            // 
            // settingtxt
            // 
            settingtxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            settingtxt.AutoSize = true;
            settingtxt.Font = new Font("#9Slide03 Montserrat", 16F);
            settingtxt.Location = new Point(20, 16);
            settingtxt.Name = "settingtxt";
            settingtxt.Size = new Size(114, 46);
            settingtxt.TabIndex = 2;
            settingtxt.Text = "Cài đặt";
            // 
            // mainpublickeytxt
            // 
            mainpublickeytxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainpublickeytxt.AutoSize = true;
            mainpublickeytxt.Font = new Font("#9Slide03 Montserrat", 10.2F);
            mainpublickeytxt.Location = new Point(20, 72);
            mainpublickeytxt.Name = "mainpublickeytxt";
            mainpublickeytxt.Size = new Size(478, 30);
            mainpublickeytxt.TabIndex = 4;
            mainpublickeytxt.Text = "Khóa công khai (Được sử dụng làm địa chỉ chính của ví)";
            // 
            // MainPublicKeyInput
            // 
            MainPublicKeyInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MainPublicKeyInput.Location = new Point(20, 107);
            MainPublicKeyInput.Multiline = true;
            MainPublicKeyInput.Name = "MainPublicKeyInput";
            MainPublicKeyInput.Size = new Size(1200, 62);
            MainPublicKeyInput.TabIndex = 5;
            // 
            // mainprivatekeytxt
            // 
            mainprivatekeytxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainprivatekeytxt.AutoSize = true;
            mainprivatekeytxt.Font = new Font("#9Slide03 Montserrat", 10.2F);
            mainprivatekeytxt.Location = new Point(20, 191);
            mainprivatekeytxt.Name = "mainprivatekeytxt";
            mainprivatekeytxt.Size = new Size(433, 30);
            mainprivatekeytxt.TabIndex = 4;
            mainprivatekeytxt.Text = "Khóa bí mật (Được sử dụng để xác thực giao dịch)";
            // 
            // MainPrivateKeyInput
            // 
            MainPrivateKeyInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MainPrivateKeyInput.Location = new Point(20, 224);
            MainPrivateKeyInput.Multiline = true;
            MainPrivateKeyInput.Name = "MainPrivateKeyInput";
            MainPrivateKeyInput.PasswordChar = '*';
            MainPrivateKeyInput.ScrollBars = ScrollBars.Vertical;
            MainPrivateKeyInput.Size = new Size(1200, 121);
            MainPrivateKeyInput.TabIndex = 5;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Black;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("#9Slide03 Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(20, 634);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(94, 37);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Lưu";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // difficultytxt
            // 
            difficultytxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            difficultytxt.AutoSize = true;
            difficultytxt.Font = new Font("#9Slide03 Montserrat", 10.2F);
            difficultytxt.Location = new Point(20, 394);
            difficultytxt.Name = "difficultytxt";
            difficultytxt.Size = new Size(77, 30);
            difficultytxt.TabIndex = 4;
            difficultytxt.Text = "Độ khó ";
            // 
            // DifficultyInput
            // 
            DifficultyInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DifficultyInput.Location = new Point(20, 433);
            DifficultyInput.Name = "DifficultyInput";
            DifficultyInput.Size = new Size(1200, 27);
            DifficultyInput.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("#9Slide03 Montserrat", 10.2F);
            label1.Location = new Point(20, 477);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 4;
            label1.Text = "Phần thưởng khối";
            // 
            // RewardInput
            // 
            RewardInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RewardInput.Location = new Point(20, 516);
            RewardInput.Name = "RewardInput";
            RewardInput.Size = new Size(1200, 27);
            RewardInput.TabIndex = 5;
            // 
            // ShowBtn
            // 
            ShowBtn.BackColor = Color.White;
            ShowBtn.FlatStyle = FlatStyle.Flat;
            ShowBtn.Font = new Font("#9Slide03 Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowBtn.Location = new Point(1139, 360);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Size = new Size(81, 30);
            ShowBtn.TabIndex = 8;
            ShowBtn.Text = "Hiển thị";
            ShowBtn.UseVisualStyleBackColor = false;
            ShowBtn.Click += ShowBtn_Click;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(ShowBtn);
            Controls.Add(SaveBtn);
            Controls.Add(RewardInput);
            Controls.Add(DifficultyInput);
            Controls.Add(MainPrivateKeyInput);
            Controls.Add(label1);
            Controls.Add(MainPublicKeyInput);
            Controls.Add(difficultytxt);
            Controls.Add(mainprivatekeytxt);
            Controls.Add(mainpublickeytxt);
            Controls.Add(settingtxt);
            Name = "Setting";
            Size = new Size(1262, 688);
            Load += Setting_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label settingtxt;
        private Label mainpublickeytxt;
        private TextBox MainPublicKeyInput;
        private Label mainprivatekeytxt;
        private TextBox MainPrivateKeyInput;
        private Button SaveBtn;
        private Label difficultytxt;
        private TextBox DifficultyInput;
        private Label label1;
        private TextBox RewardInput;
        private Button ShowBtn;
    }
}
