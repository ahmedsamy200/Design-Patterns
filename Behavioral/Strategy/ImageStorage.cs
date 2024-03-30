using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class ImageStorage
    {
        
        public void Store(string fileName , ICompressor compressor, IFilter filter)
        {
            compressor.Compress(fileName);

            filter.Apply(fileName);
        }
    }
}
