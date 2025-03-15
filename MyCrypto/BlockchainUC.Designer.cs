namespace MyCrypto
{
    partial class BlockchainUC
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
            blockchaintxt = new Label();
            BlockchainGrid = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            Timestamp = new DataGridViewTextBoxColumn();
            PreviousHash = new DataGridViewTextBoxColumn();
            Hash = new DataGridViewTextBoxColumn();
            Nonce = new DataGridViewTextBoxColumn();
            TransactionTxt = new Label();
            TransactionList = new ListBox();
            MineBtn = new Button();
            pendingLb = new Label();
            BalanceTxt = new Label();
            ValidChainBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)BlockchainGrid).BeginInit();
            SuspendLayout();
            // 
            // blockchaintxt
            // 
            blockchaintxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            blockchaintxt.AutoSize = true;
            blockchaintxt.Font = new Font("#9Slide03 Montserrat", 16F);
            blockchaintxt.Location = new Point(20, 20);
            blockchaintxt.Name = "blockchaintxt";
            blockchaintxt.Size = new Size(173, 46);
            blockchaintxt.TabIndex = 1;
            blockchaintxt.Text = "Chuỗi khóa";
            // 
            // BlockchainGrid
            // 
            BlockchainGrid.AllowUserToDeleteRows = false;
            BlockchainGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BlockchainGrid.Columns.AddRange(new DataGridViewColumn[] { STT, Timestamp, PreviousHash, Hash, Nonce });
            BlockchainGrid.Location = new Point(20, 137);
            BlockchainGrid.MultiSelect = false;
            BlockchainGrid.Name = "BlockchainGrid";
            BlockchainGrid.ReadOnly = true;
            BlockchainGrid.RowHeadersWidth = 51;
            BlockchainGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BlockchainGrid.Size = new Size(1207, 312);
            BlockchainGrid.TabIndex = 1;
            BlockchainGrid.SelectionChanged += BlockchainGrid_SelectionChanged;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 50;
            // 
            // Timestamp
            // 
            Timestamp.HeaderText = "Thời gian tạo";
            Timestamp.MinimumWidth = 6;
            Timestamp.Name = "Timestamp";
            Timestamp.ReadOnly = true;
            Timestamp.Width = 200;
            // 
            // PreviousHash
            // 
            PreviousHash.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PreviousHash.HeaderText = "Hash khối trước";
            PreviousHash.MinimumWidth = 6;
            PreviousHash.Name = "PreviousHash";
            PreviousHash.ReadOnly = true;
            // 
            // Hash
            // 
            Hash.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Hash.HeaderText = "Hash";
            Hash.MinimumWidth = 6;
            Hash.Name = "Hash";
            Hash.ReadOnly = true;
            // 
            // Nonce
            // 
            Nonce.HeaderText = "Nonce";
            Nonce.MinimumWidth = 6;
            Nonce.Name = "Nonce";
            Nonce.ReadOnly = true;
            Nonce.Width = 75;
            // 
            // TransactionTxt
            // 
            TransactionTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TransactionTxt.AutoSize = true;
            TransactionTxt.Font = new Font("#9Slide03 Montserrat", 16F);
            TransactionTxt.Location = new Point(20, 480);
            TransactionTxt.Name = "TransactionTxt";
            TransactionTxt.Size = new Size(290, 46);
            TransactionTxt.TabIndex = 1;
            TransactionTxt.Text = "Giao dịch trong khối";
            // 
            // TransactionList
            // 
            TransactionList.FormattingEnabled = true;
            TransactionList.HorizontalScrollbar = true;
            TransactionList.Location = new Point(20, 539);
            TransactionList.Name = "TransactionList";
            TransactionList.Size = new Size(1207, 204);
            TransactionList.TabIndex = 2;
            // 
            // MineBtn
            // 
            MineBtn.BackColor = Color.Black;
            MineBtn.FlatStyle = FlatStyle.Flat;
            MineBtn.Font = new Font("#9Slide03 Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MineBtn.ForeColor = Color.White;
            MineBtn.Location = new Point(1113, 78);
            MineBtn.Name = "MineBtn";
            MineBtn.Size = new Size(114, 37);
            MineBtn.TabIndex = 0;
            MineBtn.Text = "Đào khối";
            MineBtn.UseVisualStyleBackColor = false;
            MineBtn.Click += MineBtn_Click;
            // 
            // pendingLb
            // 
            pendingLb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pendingLb.AutoSize = true;
            pendingLb.Font = new Font("#9Slide03 Montserrat", 10.2F);
            pendingLb.Location = new Point(321, 80);
            pendingLb.Name = "pendingLb";
            pendingLb.Size = new Size(258, 30);
            pendingLb.TabIndex = 9;
            pendingLb.Text = "Số lượng giao dịch đang chờ:";
            // 
            // BalanceTxt
            // 
            BalanceTxt.AutoSize = true;
            BalanceTxt.BackColor = Color.Transparent;
            BalanceTxt.Font = new Font("#9Slide03 Montserrat", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BalanceTxt.ForeColor = Color.Firebrick;
            BalanceTxt.Location = new Point(20, 78);
            BalanceTxt.Name = "BalanceTxt";
            BalanceTxt.Size = new Size(69, 31);
            BalanceTxt.TabIndex = 10;
            BalanceTxt.Text = "Số dư:";
            // 
            // ValidChainBtn
            // 
            ValidChainBtn.BackColor = Color.Brown;
            ValidChainBtn.FlatStyle = FlatStyle.Flat;
            ValidChainBtn.Font = new Font("#9Slide03 Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ValidChainBtn.ForeColor = Color.White;
            ValidChainBtn.Location = new Point(955, 78);
            ValidChainBtn.Name = "ValidChainBtn";
            ValidChainBtn.Size = new Size(147, 37);
            ValidChainBtn.TabIndex = 3;
            ValidChainBtn.Text = "Xác minh chuỗi";
            ValidChainBtn.UseVisualStyleBackColor = false;
            ValidChainBtn.Click += ValidChainBtn_Click;
            // 
            // BlockchainUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(BalanceTxt);
            Controls.Add(pendingLb);
            Controls.Add(ValidChainBtn);
            Controls.Add(MineBtn);
            Controls.Add(TransactionList);
            Controls.Add(BlockchainGrid);
            Controls.Add(TransactionTxt);
            Controls.Add(blockchaintxt);
            Name = "BlockchainUC";
            Size = new Size(1262, 773);
            ((System.ComponentModel.ISupportInitialize)BlockchainGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label blockchaintxt;
        private DataGridView BlockchainGrid;
        private Label TransactionTxt;
        private ListBox TransactionList;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Timestamp;
        private DataGridViewTextBoxColumn PreviousHash;
        private DataGridViewTextBoxColumn Hash;
        private DataGridViewTextBoxColumn Nonce;
        private Button MineBtn;
        private Label pendingLb;
        private Label BalanceTxt;
        private Button ValidChainBtn;
    }
}
