using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program4
{
    public partial class Form1 : Form
    {

        private const string PathFileText = "SimpleText.txt";
        private const string PathFileSignature = "Signature.dsa";
        private DSACryptoServiceProvider dsa;
        private byte[] signaturebytes;
        private DSAParameters dsaparams;
        string OID = CryptoConfig.MapNameToOID("SHA1");

        public Form1()
        {
            InitializeComponent();
        }
        private void btn_SaveText_Click(object sender, EventArgs e) // сохранение теста
        {
            using (StreamWriter writer = new StreamWriter(PathFileText))
            {
                writer.Write(TextBox.Text);
            }
        }

        private void btn_LoadText_Click(object sender, EventArgs e) // загрузка текста
        {
            using(StreamReader reader = new StreamReader(PathFileText))
            {
                TextBox.Text = reader.ReadToEnd();
            }
        }
        private void btn_CreateSignature_Click(object sender, EventArgs e) // Создание новой сигнатуры
        {
            //get original message as byte array
            byte[] messagebytes = Encoding.UTF8.GetBytes(TextBox.Text);

            //create digest of original message using SHA1
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] hashbytes = sha1.ComputeHash(messagebytes);


            //create DSA object using default key
            dsa = new DSACryptoServiceProvider();

            //sign hash using OID for SHA-1
            signaturebytes = dsa.SignHash(hashbytes, "1.3.14.3.2.26");
            DebugHash(signaturebytes);

            //provide DSA parameters to verification
            dsaparams = dsa.ExportParameters(false);

            Debug.WriteLine(dsa.ExportParameters(false).P);

            //display digital signature in hex format
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < signaturebytes.Length; i++)
                sb.Append(String.Format("{0,2:X2} ", signaturebytes[i]));
            text_Sigrature.Text = sb.ToString();
        }
        /// <summary>
        /// Выводит сигнатуру в техт бокс после загрузки из файла
        /// </summary>
        private void TextBoxSingHash()
        {
            byte[] messagebytes = Encoding.UTF8.GetBytes(TextBox.Text);

            //create digest of original message using SHA1
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] hashbytes = sha1.ComputeHash(messagebytes);

            signaturebytes = dsa.CreateSignature(hashbytes);

            DebugHash(signaturebytes);
            //if(dsa.VerifyHash(hashbytes,""))

           // display digital signature in hex format
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < signaturebytes.Length; i++)
                sb.Append(String.Format("{0,2:X2} ", signaturebytes[i]));
            text_Sigrature.Text = sb.ToString();
        }
        private void btn_SaveSignature_Click(object sender, EventArgs e) // сохранение открытого и закрытого ключа
        {
            using (StreamWriter writer = new StreamWriter(PathFileSignature))
                writer.Write(dsa.ToXmlString(true));

        }
        private void btn_LoadSignature_Click(object sender, EventArgs e) // загрузка открытого и закрытого ключа
        {
            string key = null;
            using (StreamReader reader = new StreamReader(PathFileSignature))
                key = reader.ReadToEnd();

            dsa = new DSACryptoServiceProvider();

            dsa.FromXmlString(key);

            TextBoxSingHash();
           
        }

        private void btn_Verify_Click(object sender, EventArgs e) // проверка целостности файла
        {
            byte[] messagebytes = Encoding.UTF8.GetBytes(TextBox.Text);

            //create digest of original message using SHA1
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] hashbytes = sha1.ComputeHash(messagebytes);

            //do verification on hash using OID for SHA - 1
            DebugHash(signaturebytes);
            bool match = dsa.VerifyHash(hashbytes, "1.3.14.3.2.26", signaturebytes);

            //show message box with result of verification
            String strResult;
            if (match)
                strResult = "VerifySignature returned TRUE";
            else
                strResult = "VerifySignature returned FALSE";
            MessageBox.Show(
                strResult,
                "Result From Calling VerifySignature",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
        /// <summary>
        /// Debug Write Line array Hash
        /// </summary>
        /// <param name="hash">Hash</param>
        private void DebugHash(byte[] hash)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(String.Format("{0,2:X2} ", hash[i]));
            Debug.WriteLine(sb.ToString());
        }
    }
}
