using System.IO;
using System.IO.Compression;
using System.Text;

namespace subfix
{
    class zirnevis
    {
        public void FixIt(string path)
        {
            try
            {
                StreamReader Reader = new StreamReader(path, Encoding.GetEncoding("Windows-1256"));
                string String = Reader.ReadToEnd();
                Reader.Close();

                StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8);
                writer.Write(String);
                writer.Close();
            }
            catch
            {

            }
        }
        public void FixItzip(string path)
        {
            try
            {
                StreamReader Reader = new StreamReader(path, Encoding.GetEncoding("Windows-1256"));
                string String = Reader.ReadToEnd();
                Reader.Close();

                StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8);
                writer.Write(String);
                writer.Close();
            }
            catch
            {

            }
          /*  using (ZipArchive archive = ZipFile.OpenRead(fof))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.EndsWith(".srt"))
                    {
                        StreamReader sr = new StreamReader(entry.FullName, Encoding.GetEncoding("Windows-1256"));
                        MessageBox.Show("h");
                        string String = sr.ReadToEnd();
                        sr.Close();
                        Encoding.Convert()
                                    GZipStream sw = new GZipStream();
                        sw.Write(String);
                        sw.Close();
                        //GZipStream 
                    }
                }
            }*/
        }
    }
}
