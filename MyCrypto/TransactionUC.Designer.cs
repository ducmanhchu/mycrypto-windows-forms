namespace MyCrypto
{
    partial class TransactionUC
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
            transtxt = new Label();
            fromLb = new Label();
            toLb = new Label();
            FromAdrTxt = new TextBox();
            ToAdrTxt = new TextBox();
            amountLb = new Label();
            AmountTxt = new TextBox();
            CreateAndSignBtn = new Button();
            pendingTransactionsLb = new Label();
            PendingTransactionGrid = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            Sender = new DataGridViewTextBoxColumn();
            Receiver = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Valid = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)PendingTransactionGrid).BeginInit();
            SuspendLayout();
            // 
            // transtxt
            // 
            transtxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            transtxt.AutoSize = true;
            transtxt.Font = new Font("#9Slide03 Montserrat", 16F);
            transtxt.Location = new Point(20, 20);
            transtxt.Name = "transtxt";
            transtxt.Size = new Size(197, 46);
            transtxt.TabIndex = 1;
            transtxt.Text = "Tạo giao dịch";
            // 
            // fromLb
            // 
            fromLb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fromLb.AutoSize = true;
            fromLb.Font = new Font("#9Slide03 Montserrat", 10.2F);
            fromLb.Location = new Point(20, 75);
            fromLb.Name = "fromLb";
            fromLb.Size = new Size(155, 30);
            fromLb.TabIndex = 2;
            fromLb.Text = "Địa chỉ người gửi";
            // 
            // toLb
            // 
            toLb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            toLb.AutoSize = true;
            toLb.Font = new Font("#9Slide03 Montserrat", 10.2F);
            toLb.Location = new Point(20, 150);
            toLb.Name = "toLb";
            toLb.Size = new Size(171, 30);
            toLb.TabIndex = 2;
            toLb.Text = "Địa chỉ người nhận";
            // 
            // FromAdrTxt
            // 
            FromAdrTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FromAdrTxt.ForeColor = SystemColors.Highlight;
            FromAdrTxt.Location = new Point(211, 78);
            FromAdrTxt.Multiline = true;
            FromAdrTxt.Name = "FromAdrTxt";
            FromAdrTxt.ReadOnly = true;
            FromAdrTxt.Size = new Size(991, 54);
            FromAdrTxt.TabIndex = 4;
            // 
            // ToAdrTxt
            // 
            ToAdrTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ToAdrTxt.Location = new Point(211, 153);
            ToAdrTxt.Multiline = true;
            ToAdrTxt.Name = "ToAdrTxt";
            ToAdrTxt.Size = new Size(991, 27);
            ToAdrTxt.TabIndex = 0;
            // 
            // amountLb
            // 
            amountLb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            amountLb.AutoSize = true;
            amountLb.Font = new Font("#9Slide03 Montserrat", 10.2F);
            amountLb.Location = new Point(20, 196);
            amountLb.Name = "amountLb";
            amountLb.Size = new Size(87, 30);
            amountLb.TabIndex = 2;
            amountLb.Text = "Số lượng";
            // 
            // AmountTxt
            // 
            AmountTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AmountTxt.Location = new Point(211, 199);
            AmountTxt.Name = "AmountTxt";
            AmountTxt.Size = new Size(991, 27);
            AmountTxt.TabIndex = 1;
            // 
            // CreateAndSignBtn
            // 
            CreateAndSignBtn.BackColor = Color.Black;
            CreateAndSignBtn.FlatStyle = FlatStyle.Flat;
            CreateAndSignBtn.Font = new Font("#9Slide03 Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateAndSignBtn.ForeColor = Color.White;
            CreateAndSignBtn.Location = new Point(211, 243);
            CreateAndSignBtn.Name = "CreateAndSignBtn";
            CreateAndSignBtn.Size = new Size(170, 37);
            CreateAndSignBtn.TabIndex = 2;
            CreateAndSignBtn.Text = "Tạo và ký giao dịch";
            CreateAndSignBtn.UseVisualStyleBackColor = false;
            CreateAndSignBtn.Click += CreateAndSignBtn_Click;
            // 
            // pendingTransactionsLb
            // 
            pendingTransactionsLb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pendingTransactionsLb.AutoSize = true;
            pendingTransactionsLb.Font = new Font("#9Slide03 Montserrat", 16F);
            pendingTransactionsLb.Location = new Point(20, 323);
            pendingTransactionsLb.Name = "pendingTransactionsLb";
            pendingTransactionsLb.Size = new Size(279, 46);
            pendingTransactionsLb.TabIndex = 1;
            pendingTransactionsLb.Text = "Giao dịch đang chờ";
            // 
            // PendingTransactionGrid
            // 
            PendingTransactionGrid.AllowUserToDeleteRows = false;
            PendingTransactionGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PendingTransactionGrid.Columns.AddRange(new DataGridViewColumn[] { STT, Sender, Receiver, Amount, Valid });
            PendingTransactionGrid.Location = new Point(20, 384);
            PendingTransactionGrid.Name = "PendingTransactionGrid";
            PendingTransactionGrid.ReadOnly = true;
            PendingTransactionGrid.RowHeadersWidth = 51;
            PendingTransactionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PendingTransactionGrid.Size = new Size(1182, 278);
            PendingTransactionGrid.TabIndex = 3;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 75;
            // 
            // Sender
            // 
            Sender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sender.HeaderText = "Người gửi";
            Sender.MinimumWidth = 6;
            Sender.Name = "Sender";
            Sender.ReadOnly = true;
            // 
            // Receiver
            // 
            Receiver.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Receiver.HeaderText = "Người nhận";
            Receiver.MinimumWidth = 6;
            Receiver.Name = "Receiver";
            Receiver.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.HeaderText = "Số lượng";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Valid
            // 
            Valid.HeaderText = "Hợp lệ";
            Valid.MinimumWidth = 6;
            Valid.Name = "Valid";
            Valid.ReadOnly = true;
            Valid.Width = 125;
            // 
            // TransactionUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(PendingTransactionGrid);
            Controls.Add(CreateAndSignBtn);
            Controls.Add(AmountTxt);
            Controls.Add(ToAdrTxt);
            Controls.Add(FromAdrTxt);
            Controls.Add(amountLb);
            Controls.Add(toLb);
            Controls.Add(fromLb);
            Controls.Add(pendingTransactionsLb);
            Controls.Add(transtxt);
            Name = "TransactionUC";
            Size = new Size(1262, 688);
            ((System.ComponentModel.ISupportInitialize)PendingTransactionGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label transtxt;
        private Label fromLb;
        private Label toLb;
        private TextBox FromAdrTxt;
        private TextBox ToAdrTxt;
        private Label amountLb;
        private TextBox AmountTxt;
        private Button CreateAndSignBtn;
        private Label pendingTransactionsLb;
        private DataGridView PendingTransactionGrid;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Sender;
        private DataGridViewTextBoxColumn Receiver;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Valid;
    }
}
