using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebpToPNG.helper;
using WebpToPNG.models;

namespace WebpToPNG
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            toPNG(new SourceDetiny().Get());
            Console.Write("Fim do processo");
            Console.ReadKey();
        }

        public static void convert(Paths paths)
        {
            byte[] bytes = File.ReadAllBytes(paths.source);
            Bitmap image = new Imazen.WebP.SimpleDecoder().DecodeFromBytes(bytes, bytes.Length);
            image.Save(paths.destiny, ImageFormat.Png);
        }


        public static void toPNG(Paths paths)
        {
            Console.Write("Processando... ");

            List<string> webpFiles = Directory.GetFiles(paths.source, "*.*", SearchOption.AllDirectories)
                                      .Where(file => new string[] { ".webp" }
                                      .Contains(Path.GetExtension(file)))
                                      .ToList();

            foreach (var filePath in webpFiles)
            {
                string filename = GetFilename(filePath);
                string pathFilenameDestiny = paths.destiny + "\\" + filename;
                convert(new Paths(filePath, pathFilenameDestiny));
            }
        }

        private static string GetFilename(string filePath)
        {
            string originalFilename = filePath.Split('\\').Last();
            string filenameWitoutExt = originalFilename.Split('.').First();
            return filenameWitoutExt + ".png";
        }
    }
}
