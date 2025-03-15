using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace MyCrypto
{
    public partial class HashUC : UserControl
    {
        public HashUC()
        {
            InitializeComponent();
            DataInput.TextChanged += DataInput_TextChanged;
        }

        private void DataInput_TextChanged(object? sender, EventArgs? e)
        {
            if (string.IsNullOrWhiteSpace(DataInput.Text))
            {
                HashOutput.Text = "";
                return;
            }
            HashOutput.Text = ComputeSHA256Hash(DataInput.Text);
        }

        private string ComputeSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // Chuyển thành chuỗi hex
                }
                return sb.ToString();
            }
        }
    }
}
