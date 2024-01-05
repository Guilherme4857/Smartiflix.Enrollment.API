using System.Security.Cryptography;
using System.Text;

namespace Smartflix.Enrollment.Database.Extentions
{
    public static class StringExtension
    {
        public static string GetHash(this string input, HashAlgorithm hashAlgorithm)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            var stringBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
                stringBuilder.Append(data[i].ToString("x2"));

            return stringBuilder.ToString();
        }

        public static bool VerifyHash(this string input, HashAlgorithm hashAlgorithm, string hash)
        {
            var hashOfInput = input.GetHash(hashAlgorithm);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }
    }
}
