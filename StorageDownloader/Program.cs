using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            StorageDownloader loader = new StorageDownloader();
            loader.StartObserving();
        }
    }
}
