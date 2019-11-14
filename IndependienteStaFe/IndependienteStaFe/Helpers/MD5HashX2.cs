using System.Security.Cryptography;
using System.Text;

namespace IndependienteStaFe.Helpers
{
    public class MD5HashX2
    {
        public string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider m5provider = new MD5CryptoServiceProvider();
            byte[] bytes = m5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("X2"));

            }
            return hash.ToString();
        }
    }
}
