using System;

namespace DataCompression
{
    // Strategy
    public class Compressor : ICompressor
    {
        private ICompressorAlgo _algo;

        public Compressor(ICompressorAlgo algo)
        {
            _algo = algo;
        }

        public string Compress(string data)
        {
            return _algo.Compress(data);
        }
    }
}
