using System;
using System.Data.HashFunction;
using System.Data.HashFunction.xxHash;
using System.IO;

namespace hasher
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 3) throw new ArgumentNullException();

                string src = args[1];
                string trg = args[2];

                IxxHash _xxHash = xxHashFactory.Instance.Create(new xxHashConfig() { HashSizeInBits = 64 });
                IHashValue hash;

                switch (args[0])
                {
                    case "--f":
                        Stream stream = new FileStream(
                            src,
                            FileMode.Open,
                            FileAccess.Read,
                            FileShare.ReadWrite,
                            bufferSize: 131072,
                            options: FileOptions.None
                            );
                        hash = _xxHash.ComputeHash(stream);
                        break;

                    case "--s":
                        hash = _xxHash.ComputeHash(src);
                        break;

                    default: 
                        throw new ArgumentException();
                }

                File.WriteAllText(trg, hash.AsHexString());

            }
            catch (Exception ex)
            {
                string msg = DateTime.Now + ": " + ex.Message;
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "hasher.err", msg);
            }
        }
    }
}