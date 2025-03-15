using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrypto.Models
{
    public class Blockchain
    {
        public List<Block> Chain { get; } = new();
        public List<Transaction> pendingTransactions { get; private set; } = new List<Transaction>();
        public int Difficulty { get; set; } = Properties.Settings.Default.Difficulty;  // Độ khó khai thác
        public double MiningReward { get; set; } = Properties.Settings.Default.MiningRewards;  // Phần thưởng cho người đào

        public Blockchain() => CreateGenesisBlock();

        // Tạo block đầu tiên (Genesis Block)
        private void CreateGenesisBlock()
        {
            var genesisBlock = new Block(0, DateTime.UtcNow, "0", new List<Transaction>());
            genesisBlock.MineBlock(Difficulty);
            Chain.Add(genesisBlock);
        }

        // Lấy block cuối cùng trong chuỗi
        public Block GetLatestBlock() => Chain.Last();

        // Thêm giao dịch mới vào hàng chờ
        public void AddTransaction(Transaction transaction)
        {
            if (string.IsNullOrWhiteSpace(transaction.Sender) || string.IsNullOrWhiteSpace(transaction.Receiver))
                throw new Exception("Giao dịch không hợp lệ: Thiếu thông tin người nhận hoặc người gửi");
            if (transaction.Amount <= 0)
                throw new Exception("Giao dịch không hợp lệ: Số tiền gửi phải lớn hơn 0");
            if (GetBalance(transaction.Sender) < transaction.Amount)
                throw new Exception("Số dư không đủ!");

            pendingTransactions.Add(transaction);
        }

        // Đào khối mới
        public void MinePendingTransactions(string minerAddress)
        {
            // Nếu không có giao dịch nào, vẫn tạo một giao dịch thưởng mặc định
            if (!pendingTransactions.Any())
            {
                Console.WriteLine("Khoi chi chua phan thuong (Chua co giao dich)");
            }

            // Thêm giao dịch thưởng cho người đào vào hàng chờ
            pendingTransactions.Add(new Transaction("System", minerAddress, MiningReward));

            // Thêm giao dịch trong hàng chờ (nếu có) vào khối 
            var block = new Block(Chain.Count, DateTime.UtcNow, GetLatestBlock().Hash, new List<Transaction>(pendingTransactions));
            block.MineBlock(Difficulty);
            Chain.Add(block);
            pendingTransactions.Clear();
        }

        // Kiểm tra tính hợp lệ của toàn bộ chuỗi
        public bool IsValidChain()
        {
            for (int i = 1; i < Chain.Count; i++)
            {
                var currentBlock = Chain[i];
                var previousBlock = Chain[i - 1];

                if (currentBlock.Hash != currentBlock.CalculateHash())
                    return false;
                if (currentBlock.PreviousHash != previousBlock.Hash)
                    return false;
            }
            return true;
        }

        // Lấy số dư của một địa chỉ
        public double GetBalance(string address)
        {
            double balance = 0;

            foreach (var block in Chain)
            {
                foreach (var transaction in block.Transactions)
                {
                    if (transaction.Sender == address)
                    {
                        balance -= transaction.Amount; // Trừ khi gửi đi
                    }
                    if (transaction.Receiver == address)
                    {
                        balance += transaction.Amount; // Cộng khi nhận được
                    }
                }
            }

            return balance;
        }

        public List<Transaction> GetPendingTransactions()
        {
            return new List<Transaction>(pendingTransactions);
        }
    }
}

