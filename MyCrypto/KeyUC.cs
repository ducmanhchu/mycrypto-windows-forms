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
    public partial class KeyUC : UserControl
    {
        public KeyUC()
        {
            InitializeComponent();
        }

        private void GenKeyBtn_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng RSA để tạo cặp khóa
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1048))
            {
                // Lấy khóa công khai và khóa riêng tư dưới dạng XML
                string publicKey = Convert.ToBase64String(rsa.ExportRSAPublicKey());
                string privateKey = Convert.ToBase64String(rsa.ExportRSAPrivateKey());

                // Hiển thị khóa công khai và bí mật
                PubKeyOutput.Text = publicKey;
                PrivKeyOutput.Text = privateKey;
                PrivKeyOutput.PasswordChar = '*';

                PubKey2Output.Text = publicKey;
                PrivKey2Output.Text = privateKey;
                PrivKey2Output.PasswordChar = '*';
            }
        }

        private void CopytoClipboard(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                Clipboard.SetText(textBox.Text);
                ToolTip tooltip = new ToolTip();
                tooltip.Show("Đã sao chép!", textBox, 1000);
            }
            else
            {
                ToolTip tooltip = new ToolTip();
                tooltip.Show("Không có gì để sao chép!", textBox, 1000);
            }
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            CopytoClipboard(PubKeyOutput);
        }

        private void CopyBtn2_Click(object sender, EventArgs e)
        {
            CopytoClipboard(PrivKeyOutput);
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            if (PrivKeyOutput.PasswordChar == '*')
            {
                PrivKeyOutput.PasswordChar = '\0';
                ShowBtn.Text = "Ẩn";
            }
            else
            {
                PrivKeyOutput.PasswordChar = '*';
                ShowBtn.Text = "Hiển thị";
            }
        }

        private void Show2Btn_Click(object sender, EventArgs e)
        {
            if (PrivKey2Output.PasswordChar == '*')
            {
                PrivKey2Output.PasswordChar = '\0';
                Show2Btn.Text = "Ẩn";
            }
            else
            {
                PrivKey2Output.PasswordChar = '*';
                Show2Btn.Text = "Hiển thị";
            }
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu cần mã hóa từ TextBox
                string plaintext = EncryptInput.Text; // Dữ liệu cần mã hóa
                string publicKeyBase64 = PubKey2Output.Text; // Khóa công khai từ TextBox

                // Mã hóa dữ liệu
                string encryptedData = EncryptData(plaintext, publicKeyBase64);

                // Hiển thị dữ liệu đã mã hóa
                EncryptOutput.Text = encryptedData;
                DecryptInput.Text = encryptedData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mã hóa: " + ex.Message);
            }
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu cần giải mã từ TextBox
                string encryptedText = DecryptInput.Text; // Dữ liệu đã mã hóa
                string privateKeyBase64 = PrivKey2Output.Text; // Khóa riêng tư từ TextBox

                // Giải mã dữ liệu
                string decryptedData = DecryptData(encryptedText, privateKeyBase64);

                // Hiển thị dữ liệu sau khi giải mã
                DecryptOutput.Text = decryptedData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi giải mã: " + ex.Message);
            }
        }

        // Hàm mã hóa dữ liệu từ khóa công khai
        private string EncryptData(string plaintext, string base64PublicKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportRSAPublicKey(Convert.FromBase64String(base64PublicKey), out _);
                byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(plaintext), false);
                return Convert.ToBase64String(encryptedData);
            }
        }

        // Hàm giải mã dữ liệu từ khóa riêng tư
        private string DecryptData(string encryptedText, string base64PrivateKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportRSAPrivateKey(Convert.FromBase64String(base64PrivateKey), out _);
                byte[] decryptedData = rsa.Decrypt(Convert.FromBase64String(encryptedText), false);
                return Encoding.UTF8.GetString(decryptedData);
            }
        }

        private void PrivKeyOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
