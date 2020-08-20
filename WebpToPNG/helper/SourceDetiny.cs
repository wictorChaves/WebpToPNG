using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebpToPNG.models;

namespace WebpToPNG.helper
{
    public class SourceDetiny
    {
        private readonly SelectFilePath selectFilePath;

        public SourceDetiny()
        {
            selectFilePath = new SelectFilePath();
        }

        public Paths Get()
        {
            return new Paths(selectFilePath.GetPath(),
                selectFilePath.GetPath());
        }
    }
}
