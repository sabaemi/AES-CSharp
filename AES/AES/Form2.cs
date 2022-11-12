using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace AES
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //Init skin
            //MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            ////skinManager.AddFormToManage(this);
            //skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900,
            //    MaterialSkin.Primary.BlueGrey900,
            //    MaterialSkin.Primary.Blue500,
            //    MaterialSkin.Accent.Orange700,
            //    MaterialSkin.TextShade.WHITE);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            if (plainText == null || plainText.Length <= 0) throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0) throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0) throw new ArgumentNullException("IV");
            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.KeySize = 128;
                aesAlg.Mode = CipherMode.ECB;
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string original = textBox1.Text;
            using (Aes myAes = Aes.Create())
            {
                myAes.KeySize = 128;
                myAes.Mode = CipherMode.ECB;
                byte[] encrypted = EncryptStringToBytes_Aes(original, Encoding.Default.GetBytes(textBox2.Text), myAes.IV);
                MessageBox.Show("encrypted:   " + Encoding.Default.GetString(encrypted));
                StreamWriter sw = new StreamWriter("D:\\Test.txt");
                sw.WriteLine("encrypted:   " + Encoding.Default.GetString(encrypted));
                sw.WriteLine("key:   " + textBox2.Text);
                sw.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            using (Aes myAes = Aes.Create())
            {
                myAes.KeySize = 128;
                myAes.Mode = CipherMode.ECB;
                textBox2.Text = Encoding.Default.GetString(myAes.Key);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider2_Click(object sender, EventArgs e)
        {

        }
    }
}
