using System.Security.Cryptography;
using System.Text;

namespace Smartflix.Enrollment.Database.Extentions
{
    /// <summary>
    /// Implement string extension methods.
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Get string hash.
        /// </summary>
        /// <param name="input">String input.</param>
        /// <param name="hashAlgorithm">Hash algorithm.</param>
        /// <returns>String hash.</returns>
        public static string GetHash(this string input, HashAlgorithm hashAlgorithm)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            var stringBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
                stringBuilder.Append(data[i].ToString("x2"));

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Verify if string hash belongs to input.
        /// </summary>
        /// <param name="input">String input.</param>
        /// <param name="hashAlgorithm">Hash algorithm.</param>
        /// <param name="hash">String hash.</param>
        /// <returns>True if hash own</returns>
        public static bool VerifyHash(this string input, HashAlgorithm hashAlgorithm, string hash)
        {
            var hashOfInput = input.GetHash(hashAlgorithm);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }
    }
}
