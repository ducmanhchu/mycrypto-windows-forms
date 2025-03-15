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

namespace MyCrypto
{
    public partial class TransactionUC : UserControl
    {
        private string publicKey = Properties.Settings.Default.MainPublicKey;
        private string privateKey = Properties.Settings.Default.MainPrivateKey;
        public TransactionUC()
        {
            InitializeComponent();
            FromAdrTxt.Text = publicKey;
            UpdatePendingTransactionGrid();
        }

        private void CreateAndSignBtn_Click(object sender, EventArgs e)
        {
            string senderAddress = publicKey;
            string receiverAddress = ToAdrTxt.Text.Trim();

            if (string.IsNullOrWhiteSpace(receiverAddress))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ người nhận!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(AmountTxt.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Tạo giao dịch
                Transaction transaction = new Transaction(senderAddress, receiverAddress, amount);

                // Ký giao dịch bằng khóa riêng
                transaction.SignTransaction(privateKey);
                BlockchainUC.MainBlockchain.AddTransaction(transaction);
                UpdatePendingTransactionGrid();

                MessageBox.Show($"Giao dịch đã được ký thành công!\n\nChữ ký:\n{transaction.Signature}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ToAdrTxt.Text = "";
                AmountTxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ký giao dịch: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePendingTransactionGrid()
        {
            PendingTransactionGrid.Rows.Clear();

            var pendingTransactions = BlockchainUC.MainBlockchain.GetPendingTransactions();

            for (int i = 0; i < pendingTransactions.Count; i++)
            {
                var transaction = pendingTransactions[i];

                // Xác định người gửi (hiển thị "Tôi" nếu là địa chỉ của mình)
                string senderDisplay = transaction.Sender == publicKey ? "Tôi" : transaction.Sender;

                // Kiểm tra tính hợp lệ của giao dịch
                bool isValid = transaction.IsValidTransaction(publicKey);

                // Thêm dữ liệu vào bảng
                PendingTransactionGrid.Rows.Add(i + 1, senderDisplay, transaction.Receiver, transaction.Amount, isValid);
            }
        }


    }
}
