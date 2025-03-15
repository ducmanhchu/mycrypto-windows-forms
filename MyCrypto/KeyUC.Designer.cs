namespace MyCrypto
{
    partial class KeyUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyUC));
            keytxt = new Label();
            pubkeytxt = new Label();
            privkeytxt = new Label();
            PubKeyOutput = new TextBox();
            PrivKeyOutput = new TextBox();
            GenKeyBtn = new Button();
            CopyBtn = new Button();
            CopyBtn2 = new Button();
            Show2Btn = new Button();
            encrypttxt = new Label();
            pubkey2txt = new Label();
            PubKey2Output = new TextBox();
            privkey2txt = new Label();
            PrivKey2Output = new TextBox();
            ShowBtn = new Button();
            inputtxt = new Label();
            EncryptInput = new TextBox();
            DecryptOutput = new TextBox();
            pictureBox1 = new PictureBox();
            EncryptOutput = new TextBox();
            DecryptInput = new TextBox();
            EncryptBtn = new Button();
            DecryptBtn = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // keytxt
            // 
            keytxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            keytxt.AutoSize = true;
            keytxt.Font = new Font("#9Slide03 Montserrat", 16F);
            keytxt.Location = new Point(20, 20);
            keytxt.Name = "keytxt";
            keytxt.Size = new Size(391, 46);
            keytxt.TabIndex = 2;
            keytxt.Text = "Tạo khóa công khai - bí mật";
            // 
            // pubkeytxt
            // 
            pubkeytxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pubkeytxt.AutoSize = true;
            pubkeytxt.Font = new Font("#9Slide03 Montserrat", 10.2F);
            pubkeytxt.Location = new Point(20, 84);
            pubkeytxt.Name = "pubkeytxt";
            pubkeytxt.Size = new Size(144, 30);
            pubkeytxt.TabIndex = 3;
            pubkeytxt.Text = "Khóa công khai";
            // 
            // privkeytxt
            // 
            privkeytxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            privkeytxt.AutoSize = true;
            privkeytxt.Font = new Font("#9Slide03 Montserrat", 10.2F);
            privkeytxt.Location = new Point(20, 196);
            privkeytxt.Name = "privkeytxt";
            privkeytxt.Size = new Size(117, 30);
            privkeytxt.TabIndex = 3;
            privkeytxt.Text = "Khóa bí mật";
            // 
            // PubKeyOutput
            // 
            PubKeyOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PubKeyOutput.Location = new Point(179, 86);
            PubKeyOutput.Multiline = true;
            PubKeyOutput.Name = "PubKeyOutput";
            PubKeyOutput.ReadOnly = true;
            PubKeyOutput.Size = new Size(931, 85);
            PubKeyOutput.TabIndex = 4;
            // 
            // PrivKeyOutput
            // 
            PrivKeyOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PrivKeyOutput.Location = new Point(179, 196);
            PrivKeyOutput.Multiline = true;
            PrivKeyOutput.Name = "PrivKeyOutput";
            PrivKeyOutput.ReadOnly = true;
            PrivKeyOutput.ScrollBars = ScrollBars.Vertical;
            PrivKeyOutput.Size = new Size(931, 105);
            PrivKeyOutput.TabIndex = 5;
            PrivKeyOutput.TextChanged += PrivKeyOutput_TextChanged;
            // 
            // GenKeyBtn
            // 
            GenKeyBtn.BackColor = Color.Black;
            GenKeyBtn.FlatStyle = FlatStyle.Flat;
            GenKeyBtn.Font = new Font("#9Slide03 Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenKeyBtn.ForeColor = Color.White;
            GenKeyBtn.Location = new Point(179, 319);
            GenKeyBtn.Name = "GenKeyBtn";
            GenKeyBtn.Size = new Size(94, 37);
            GenKeyBtn.TabIndex = 0;
            GenKeyBtn.Text = "Tạo khóa";
            GenKeyBtn.UseVisualStyleBackColor = false;
            GenKeyBtn.Click += GenKeyBtn_Click;
            // 
            // CopyBtn
            // 
            CopyBtn.BackColor = Color.White;
            CopyBtn.FlatStyle = FlatStyle.Flat;
            CopyBtn.Font = new Font("#9Slide03 Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CopyBtn.Location = new Point(1138, 86);
            CopyBtn.Name = "CopyBtn";
            CopyBtn.Size = new Size(94, 34);
            CopyBtn.TabIndex = 1;
            CopyBtn.Text = "Sao chép";
            CopyBtn.UseVisualStyleBackColor = false;
            CopyBtn.Click += CopyBtn_Click;
            // 
            // CopyBtn2
            // 
            CopyBtn2.BackColor = Color.White;
            CopyBtn2.FlatStyle = FlatStyle.Flat;
            CopyBtn2.Font = new Font("#9Slide03 Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CopyBtn2.Location = new Point(1138, 196);
            CopyBtn2.Name = "CopyBtn2";
            CopyBtn2.Size = new Size(94, 34);
            CopyBtn2.TabIndex = 2;
            CopyBtn2.Text = "Sao chép";
            CopyBtn2.UseVisualStyleBackColor = false;
            CopyBtn2.Click += CopyBtn2_Click;
            // 
            // Show2Btn
            // 
            Show2Btn.BackColor = Color.White;
            Show2Btn.FlatStyle = FlatStyle.Flat;
            Show2Btn.Font = new Font("#9Slide03 Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Show2Btn.Location = new Point(1138, 515);
            Show2Btn.Name = "Show2Btn";
            Show2Btn.Size = new Size(94, 30);
            Show2Btn.TabIndex = 6;
            Show2Btn.Text = "Hiển thị";
            Show2Btn.UseVisualStyleBackColor = false;
            Show2Btn.Click += Show2Btn_Click;
            // 
            // encrypttxt
            // 
            encrypttxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            encrypttxt.AutoSize = true;
            encrypttxt.Font = new Font("#9Slide03 Montserrat", 16F);
            encrypttxt.Location = new Point(20, 398);
            encrypttxt.Name = "encrypttxt";
            encrypttxt.Size = new Size(295, 46);
            encrypttxt.TabIndex = 2;
            encrypttxt.Text = "Mã hóa bất đối xứng";
            // 
            // pubkey2txt
            // 
            pubkey2txt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pubkey2txt.AutoSize = true;
            pubkey2txt.Font = new Font("#9Slide03 Montserrat", 10.2F);
            pubkey2txt.Location = new Point(20, 466);
            pubkey2txt.Name = "pubkey2txt";
            pubkey2txt.Size = new Size(144, 30);
            pubkey2txt.TabIndex = 3;
            pubkey2txt.Text = "Khóa công khai";
            // 
            // PubKey2Output
            // 
            PubKey2Output.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PubKey2Output.Location = new Point(179, 469);
            PubKey2Output.Name = "PubKey2Output";
            PubKey2Output.Size = new Size(931, 27);
            PubKey2Output.TabIndex = 4;
            // 
            // privkey2txt
            // 
            privkey2txt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            privkey2txt.AutoSize = true;
            privkey2txt.Font = new Font("#9Slide03 Montserrat", 10.2F);
            privkey2txt.Location = new Point(20, 515);
            privkey2txt.Name = "privkey2txt";
            privkey2txt.Size = new Size(117, 30);
            privkey2txt.TabIndex = 3;
            privkey2txt.Text = "Khóa bí mật";
            // 
            // PrivKey2Output
            // 
            PrivKey2Output.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PrivKey2Output.Location = new Point(179, 518);
            PrivKey2Output.Name = "PrivKey2Output";
            PrivKey2Output.Size = new Size(931, 27);
            PrivKey2Output.TabIndex = 5;
            // 
            // ShowBtn
            // 
            ShowBtn.BackColor = Color.White;
            ShowBtn.FlatStyle = FlatStyle.Flat;
            ShowBtn.Font = new Font("#9Slide03 Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowBtn.Location = new Point(1138, 247);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Size = new Size(94, 34);
            ShowBtn.TabIndex = 3;
            ShowBtn.Text = "Hiển thị";
            ShowBtn.UseVisualStyleBackColor = false;
            ShowBtn.Click += ShowBtn_Click;
            // 
            // inputtxt
            // 
            inputtxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputtxt.AutoSize = true;
            inputtxt.Font = new Font("#9Slide03 Montserrat", 10.2F);
            inputtxt.Location = new Point(20, 575);
            inputtxt.Name = "inputtxt";
            inputtxt.Size = new Size(72, 30);
            inputtxt.TabIndex = 3;
            inputtxt.Text = "Dữ liệu";
            // 
            // EncryptInput
            // 
            EncryptInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EncryptInput.Location = new Point(179, 575);
            EncryptInput.Multiline = true;
            EncryptInput.Name = "EncryptInput";
            EncryptInput.Size = new Size(411, 168);
            EncryptInput.TabIndex = 7;
            // 
            // DecryptOutput
            // 
            DecryptOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DecryptOutput.Location = new Point(179, 785);
            DecryptOutput.Multiline = true;
            DecryptOutput.Name = "DecryptOutput";
            DecryptOutput.ReadOnly = true;
            DecryptOutput.Size = new Size(411, 168);
            DecryptOutput.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(616, 636);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // EncryptOutput
            // 
            EncryptOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EncryptOutput.Location = new Point(699, 575);
            EncryptOutput.Multiline = true;
            EncryptOutput.Name = "EncryptOutput";
            EncryptOutput.ReadOnly = true;
            EncryptOutput.Size = new Size(411, 168);
            EncryptOutput.TabIndex = 8;
            // 
            // DecryptInput
            // 
            DecryptInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DecryptInput.Location = new Point(699, 785);
            DecryptInput.Multiline = true;
            DecryptInput.Name = "DecryptInput";
            DecryptInput.Size = new Size(411, 168);
            DecryptInput.TabIndex = 11;
            // 
            // EncryptBtn
            // 
            EncryptBtn.BackColor = Color.Black;
            EncryptBtn.FlatStyle = FlatStyle.Flat;
            EncryptBtn.Font = new Font("#9Slide03 Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EncryptBtn.ForeColor = Color.White;
            EncryptBtn.Location = new Point(1138, 575);
            EncryptBtn.Name = "EncryptBtn";
            EncryptBtn.Size = new Size(94, 37);
            EncryptBtn.TabIndex = 9;
            EncryptBtn.Text = "Mã hóa";
            EncryptBtn.UseVisualStyleBackColor = false;
            EncryptBtn.Click += EncryptBtn_Click;
            // 
            // DecryptBtn
            // 
            DecryptBtn.BackColor = Color.Black;
            DecryptBtn.FlatStyle = FlatStyle.Flat;
            DecryptBtn.Font = new Font("#9Slide03 Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DecryptBtn.ForeColor = Color.White;
            DecryptBtn.Location = new Point(1138, 785);
            DecryptBtn.Name = "DecryptBtn";
            DecryptBtn.Size = new Size(94, 37);
            DecryptBtn.TabIndex = 10;
            DecryptBtn.Text = "Giải mã";
            DecryptBtn.UseVisualStyleBackColor = false;
            DecryptBtn.Click += DecryptBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(616, 845);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // KeyUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Gainsboro;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Show2Btn);
            Controls.Add(ShowBtn);
            Controls.Add(CopyBtn2);
            Controls.Add(CopyBtn);
            Controls.Add(DecryptBtn);
            Controls.Add(EncryptBtn);
            Controls.Add(GenKeyBtn);
            Controls.Add(PrivKeyOutput);
            Controls.Add(PrivKey2Output);
            Controls.Add(PubKey2Output);
            Controls.Add(DecryptOutput);
            Controls.Add(DecryptInput);
            Controls.Add(EncryptOutput);
            Controls.Add(EncryptInput);
            Controls.Add(PubKeyOutput);
            Controls.Add(inputtxt);
            Controls.Add(privkey2txt);
            Controls.Add(privkeytxt);
            Controls.Add(pubkey2txt);
            Controls.Add(pubkeytxt);
            Controls.Add(encrypttxt);
            Controls.Add(keytxt);
            Name = "KeyUC";
            Size = new Size(1262, 1001);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label keytxt;
        private Label pubkeytxt;
        private Label privkeytxt;
        private TextBox PubKeyOutput;
        private TextBox PrivKeyOutput;
        private Button GenKeyBtn;
        private Button CopyBtn;
        private Button CopyBtn2;
        private Button Show2Btn;
        private Label encrypttxt;
        private Label pubkey2txt;
        private TextBox PubKey2Output;
        private Label privkey2txt;
        private TextBox PrivKey2Output;
        private Button ShowBtn;
        private Label inputtxt;
        private TextBox EncryptInput;
        private TextBox DecryptOutput;
        private PictureBox pictureBox1;
        private TextBox EncryptOutput;
        private TextBox DecryptInput;
        private Button EncryptBtn;
        private Button DecryptBtn;
        private PictureBox pictureBox2;
    }
}
