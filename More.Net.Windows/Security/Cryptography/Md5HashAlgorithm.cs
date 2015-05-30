using System;
using System.Security.Cryptography;

namespace More.Net.Security.Cryptography
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Md5HashAlgorithm : IMd5HashAlgorithm
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="md5"></param>
        public Md5HashAlgorithm()
        {
            this.md5 = new MD5CryptoServiceProvider();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public Byte[] ComputeHash(Byte[] buffer)
        {
            return md5.ComputeHash(buffer);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            md5.Dispose();
        }

        private readonly MD5 md5;
    }
}
