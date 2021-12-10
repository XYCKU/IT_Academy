using System;
using System.IO;
using System.IO.Compression;

namespace Models
{
    public static class Archivator
    {
        public static void Archive(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            string zipFileName = @$"{Path.GetDirectoryName(path)}/{Path.GetFileNameWithoutExtension(path)}.rar";
            FileStream zipFileStream = File.Create(zipFileName);
            var gZip = new GZipStream(zipFileStream, CompressionMode.Compress);
            fileStream.CopyTo(gZip);
            fileStream.Close();
            gZip.Close();
            zipFileStream.Close();
        }
    }
}
