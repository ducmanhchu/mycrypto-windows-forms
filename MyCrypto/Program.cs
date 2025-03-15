using MyCrypto.Models;
using System.Security.Cryptography;

namespace MyCrypto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

            //Console.WriteLine("Bat dau kiem thu he thong Blockchain...");

            //// 1. Tạo cặp khóa RSA cho người gửi
            //string senderPrivateKey = Properties.Settings.Default.MainPrivateKey;
            //string senderPublicKey = Properties.Settings.Default.MainPublicKey;
            ////Console.WriteLine(senderPublicKey + "\n");
            ////Console.WriteLine(senderPrivateKey);

            //// 2. Tạo blockchain mới
            //Blockchain myBlockchain = new Blockchain();

            //// 3. Đào block mới
            //try
            //{
            //    Console.WriteLine($"So du cua nguoi gui truoc dao: {myBlockchain.GetBalance(senderPublicKey)}");
            //    myBlockchain.MinePendingTransactions(senderPublicKey);
            //    Console.WriteLine("Da dao block moi.");
            //    Console.WriteLine($"So du cua nguoi gui sau khi dao: {myBlockchain.GetBalance(senderPublicKey)}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Loi dao block: " + ex.Message);
            //}

            //// 4. Tạo giao dịch từ người gửi đến người nhận
            //// Sử dụng senderPublicKey làm địa chỉ của người gửi
            //Transaction tx1 = new Transaction(senderPublicKey, "Charles", 5);
            //tx1.SignTransaction(senderPrivateKey);

            //// Kiểm tra xem giao dịch đã được ký hợp lệ chưa
            //bool txValid = tx1.IsValidTransaction(senderPublicKey);
            //Console.WriteLine("Giao dich hop le? " + txValid);

            //// 5. Thêm giao dịch vào hàng chờ của blockchain
            //try
            //{
            //    myBlockchain.AddTransaction(tx1);
            //    Console.WriteLine("Giao dich da duoc them vao hang cho.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Loi them giao dich: " + ex.Message);
            //}

            //// 6. Thêm giao dịch trong hàng chờ vào khối
            //try
            //{
            //    myBlockchain.MinePendingTransactions("Miner Address");
            //    Console.WriteLine("Da dao block moi.");
            //    Console.WriteLine($"So du cua nguoi gui sau khi gui: {myBlockchain.GetBalance(senderPublicKey)}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Loi dao block: " + ex.Message);
            //}

            //// 6. Kiểm tra tính hợp lệ của toàn bộ blockchain
            //bool chainValid = myBlockchain.IsValidChain();
            //Console.WriteLine("Blockchain hop le? " + chainValid);

            //// 7. Hiển thị thông tin của các block trong chuỗi
            //Console.WriteLine("\nThong tin cac Block trong Blockchain:");
            //foreach (var block in myBlockchain.Chain)
            //{
            //    Console.WriteLine($"Block {block.Index}:");
            //    Console.WriteLine($"  TimeStamp: {block.TimeStamp}");
            //    Console.WriteLine($"  Hash: {block.Hash}");
            //    Console.WriteLine($"  Previous Hash: {block.PreviousHash}");
            //    Console.WriteLine("  Transactions:");
            //    foreach (var transaction in block.Transactions)
            //    {
            //        Console.WriteLine($"    {transaction.Sender.Substring(0, Math.Min(20, transaction.Sender.Length))}... -> {transaction.Receiver.Substring(0, Math.Min(20, transaction.Receiver.Length))}..., Amount: {transaction.Amount}");
            //    }
            //    Console.WriteLine("-------------------------------");
            //}

            //// 8. Tính số dư của người gửi và người nhận
            //double senderBalance = myBlockchain.GetBalance(senderPublicKey);
            //double receiverBalance = myBlockchain.GetBalance("Charles");
            //Console.WriteLine($"So du cua nguoi gui: {senderBalance}");
            //Console.WriteLine($"So du cua nguoi nhan: {receiverBalance}");

            //Console.WriteLine("Kiem thu hoan tat");
        }
    }
}