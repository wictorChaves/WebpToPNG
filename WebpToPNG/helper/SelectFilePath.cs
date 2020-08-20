using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebpToPNG.helper
{
    public class SelectFilePath
    {
        private readonly FolderBrowserDialog fbd;

        public SelectFilePath()
        {
            fbd = new FolderBrowserDialog();
        }

        public string GetPath()
        {
            return (fbd.ShowDialog() == DialogResult.OK) ? fbd.SelectedPath : null;
        }
    }
}
