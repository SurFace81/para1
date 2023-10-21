using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para1
{
    internal class FileManager
    {
        StreamWriter? _writer;
        StreamReader? _reader;

        public void writeLineInFile(string path, string data, bool shouldAdd = false)
        {
            _writer = new StreamWriter(path, shouldAdd);
            _writer.WriteLine(data);
            _writer.Close();
            _writer.Dispose();
        }

        public string readLineInFile(string path)
        {
            if ( _reader == null)
                _reader = new StreamReader(path);

            string? line;

            line = _reader.ReadLine();

            if (line == null)
            {
                _reader.Close();
                _reader.Dispose();
                _reader = null;
                return "";
            } else 
                return line;
        }

        public bool isExists(string path)
        {
            return (new FileInfo(path)).Exists;
        }

        public void deleteFile(string path)
        {
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                file.Delete();
            }
        }

        public void deleteAllFiles(string path, params string[] extensions)
        {
            List<FileInfo> list = new List<FileInfo>();
            foreach (string ext in extensions)
            {
                list.AddRange(new DirectoryInfo(path).GetFiles("*" + ext)
                    .Where(p => p.Extension.Equals(ext, StringComparison.CurrentCultureIgnoreCase)).ToArray());
            }

            foreach (FileInfo file in list)
            {
                deleteFile(file.FullName);
            }
        }

        public void copyFile(string oldPath, string newPath)
        {
            FileInfo fileInfo = new FileInfo(oldPath);
            fileInfo.CopyTo(newPath);
        }
    }
}
