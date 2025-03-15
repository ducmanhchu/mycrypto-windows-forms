using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCrypto.Models;
using System.Transactions;

namespace MyCrypto
{
    public partial class BlockchainUC : UserControl
    {
        public static Blockchain MainBlockchain { get; private set; } = new Blockchain();
        private string publicKey = Properties.Settings.Default.MainPublicKey;
        public BlockchainUC()
        {
            InitializeComponent();
            UpdateBlockchainView();
            pendingLb.Text = "Số lượng giao dịch đang chờ: " + MainBlockchain.pendingTransactions.Count;
            BalanceTxt.Text = "Số dư: " + MainBlockchain.GetBalance(publicKey);
        }
        private void UpdateBlockchainView()
        {
            BlockchainGrid.Rows.Clear();

            foreach (var block in MainBlockchain.Chain)
            {
                BlockchainGrid.Rows.Add(block.Index, block.TimeStamp, block.PreviousHash, block.Hash, block.Nonce);
            }
        }

        private void BlockchainGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (BlockchainGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = BlockchainGrid.SelectedRows[0].Index;
                if (selectedIndex < MainBlockchain.Chain.Count)
                {
                    DisplayTransactions(MainBlockchain.Chain[selectedIndex]);
                }
            }
        }

        private void DisplayTransactions(Block block)
        {
            TransactionList.Items.Clear();

            if (block.Transactions.Count == 0)
            {
                TransactionList.Items.Add("Không có giao dịch nào trong khối này.");
                return;
            }

            foreach (var transaction in block.Transactions)
            {
                string sender = transaction.Sender == publicKey ? "Tôi" : transaction.Sender;
                string receiver = transaction.Receiver == publicKey ? "Tôi" : transaction.Receiver;
                string valid = transaction.IsValidTransaction(publicKey) || transaction.Sender == "System" ? "Hợp lệ" : "Không hợp lệ";
                string transactionInfo = $"{sender} -> {receiver}: {transaction.Amount} - {valid}";
                TransactionList.Items.Add(transactionInfo);
            }
        }

        private void MineBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MainBlockchain.MinePendingTransactions(publicKey);
                MessageBox.Show("Đào khối mới thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateBlockchainView();
                BalanceTxt.Text = "Số dư: " + MainBlockchain.GetBalance(publicKey);
                pendingLb.Text = "Số lượng giao dịch đang chờ: " + MainBlockchain.pendingTransactions.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đào khối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidChainBtn_Click(object sender, EventArgs e)
        {
            string valid = MainBlockchain.IsValidChain() ? "Chuỗi khóa hợp lệ" : "Chuỗi khóa không hợp lệ";
            MessageBox.Show($"{valid}!", "Xác minh chuỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
