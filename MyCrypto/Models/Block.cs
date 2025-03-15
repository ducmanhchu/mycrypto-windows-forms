using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Transactions;

namespace MyCrypto.Models
{
    public class Block
    {
        public int Index { get; }
        public DateTime TimeStamp { get; }
        public string PreviousHash { get; }
        public string Hash { get; private set; }
        public List<Transaction> Transactions { get; }
        public int Nonce { get; private set; }

        public Block(int index, DateTime timeStamp, string previousHash, List<Transaction> transactions)
        {
            Index = index;
            TimeStamp = timeStamp;
            PreviousHash = previousHash;
            Transactions = transactions ?? new List<Transaction>();
            Hash = CalculateHash();
        }

        public string CalculateHash()
        {
            using var sha256 = SHA256.Create();
            string transactionsData = string.Join(";", Transactions.Select(t => t.CalculateHash()));
            string rawData = $"{Index}{TimeStamp:O}{PreviousHash}{transactionsData}{Nonce}";
            return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData)));
        }

        public void MineBlock(int difficulty)
        {
            string target = new string('0', difficulty);
            while (!Hash.StartsWith(target))
            {
                Nonce++;
                Hash = CalculateHash();
            }
        }

    }
}
