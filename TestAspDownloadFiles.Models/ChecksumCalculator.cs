using System.Security.Cryptography;

namespace TestAspDownloadFiles.Models
{
    public static class ChecksumCalculator
    {
        public static async Task<string> GetShs256(string filepath)
        {
            await using var stream = System.IO.File.OpenRead(filepath);
            using SHA256 sha = SHA256.Create();
            byte[] hash = await sha.ComputeHashAsync(stream);
            return Convert.ToHexString(hash);
        }
    }
}
