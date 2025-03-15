using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MyCrypto.Models
{
    // Người gửi tạo giao dịch -> Người gửi ký giao dịch (Băm giao dịch và mã hóa bằng khóa riêng tư) bằng khóa riêng tư ->
    // -> Gửi giao dịch -> Xác minh giao dịch bằng khóa công khai của người gửi (Giải mã chữ ký và so sánh với băm giao dịch)
    // -> Thêm vào hàng chờ block nếu hợp lệ

    public class Transaction
    {
        public string Sender { get; }
        public string Receiver { get; }
        public double Amount { get; }
        public string Signature { get; private set; } = string.Empty;
        public DateTime TimeStamp { get; } = DateTime.UtcNow;

        public Transaction(string sender, string receiver, double amount)
        {
            if (string.IsNullOrWhiteSpace(sender) || string.IsNullOrWhiteSpace(receiver))
                throw new ArgumentException("Sender and Receiver cannot be empty.");
            if (amount <= 0)
                throw new ArgumentException("Amount must be greater than zero.");

            Sender = sender;
            Receiver = receiver;
            Amount = amount;
        }

        public string CalculateHash()
        {
            using var sha256 = SHA256.Create();
            string rawData = $"{Sender}|{Receiver}|{Amount}|{TimeStamp:O}";
            return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData))).Replace("-", "").ToLower();
        }

        public void SignTransaction(string base64PrivateKey)
        {
            if (string.IsNullOrEmpty(base64PrivateKey))
                throw new ArgumentNullException(nameof(base64PrivateKey), "Private key used to sign the transaction cannot be empty!");

            try
            {
                using var rsa = RSA.Create();
                rsa.ImportRSAPrivateKey(Convert.FromBase64String(base64PrivateKey), out _);

                byte[] dataBytes = Encoding.UTF8.GetBytes(CalculateHash());
                Signature = Convert.ToBase64String(rsa.SignData(dataBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1));

                Console.WriteLine("Transaction signed successfully!");
            }
            catch (Exception ex)
            {
                throw new Exception("Error signing transaction: " + ex.Message);
            }
        }

        public bool IsValidTransaction(string publicKeyBase64)
        {
            if (string.IsNullOrWhiteSpace(Signature))
                return false;

            try
            {
                using var rsa = RSA.Create();
                rsa.ImportRSAPublicKey(Convert.FromBase64String(publicKeyBase64), out _);

                byte[] dataBytes = Encoding.UTF8.GetBytes(CalculateHash());
                byte[] signatureBytes = Convert.FromBase64String(Signature);

                return rsa.VerifyData(dataBytes, signatureBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            }
            catch
            {
                return false;
            }
        }

    }
}
