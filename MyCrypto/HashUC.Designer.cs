namespace MyCrypto
{
    partial class HashUC
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
            sha256txt = new Label();
            datatxt = new Label();
            hashtxt = new Label();
            DataInput = new TextBox();
            HashOutput = new TextBox();
            SuspendLayout();
            // 
            // sha256txt
            // 
            sha256txt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sha256txt.AutoSize = true;
            sha256txt.Font = new Font("#9Slide03 Montserrat", 16F);
            sha256txt.Location = new Point(20, 20);
            sha256txt.Name = "sha256txt";
            sha256txt.Size = new Size(198, 46);
            sha256txt.TabIndex = 0;
            sha256txt.Text = "Băm SHA256";
            // 
            // datatxt
            // 
            datatxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datatxt.AutoSize = true;
            datatxt.Font = new Font("#9Slide03 Montserrat", 10.2F);
            datatxt.Location = new Point(20, 78);
            datatxt.Name = "datatxt";
            datatxt.Size = new Size(72, 30);
            datatxt.TabIndex = 1;
            datatxt.Text = "Dữ liệu";
            // 
            // hashtxt
            // 
            hashtxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hashtxt.AutoSize = true;
            hashtxt.Font = new Font("#9Slide03 Montserrat", 10.2F);
            hashtxt.Location = new Point(20, 195);
            hashtxt.Name = "hashtxt";
            hashtxt.Size = new Size(83, 30);
            hashtxt.TabIndex = 1;
            hashtxt.Text = "Mã băm";
            // 
            // DataInput
            // 
            DataInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataInput.Location = new Point(123, 80);
            DataInput.Multiline = true;
            DataInput.Name = "DataInput";
            DataInput.Size = new Size(1090, 97);
            DataInput.TabIndex = 2;
            DataInput.TextChanged += DataInput_TextChanged;
            // 
            // HashOutput
            // 
            HashOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HashOutput.Location = new Point(123, 198);
            HashOutput.Name = "HashOutput";
            HashOutput.ReadOnly = true;
            HashOutput.Size = new Size(1090, 27);
            HashOutput.TabIndex = 3;
            // 
            // Hash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(HashOutput);
            Controls.Add(DataInput);
            Controls.Add(hashtxt);
            Controls.Add(datatxt);
            Controls.Add(sha256txt);
            Name = "Hash";
            Size = new Size(1262, 688);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sha256txt;
        private Label datatxt;
        private Label hashtxt;
        private TextBox DataInput;
        private TextBox HashOutput;
    }
}
