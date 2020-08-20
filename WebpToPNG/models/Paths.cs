using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebpToPNG.models
{
    public class Paths
    {
        public Paths(string source, string destiny)
        {
            this.source = source;
            this.destiny = destiny;
        }

        public string source { get; set; }
        public string destiny { get; set; }
    }
}
