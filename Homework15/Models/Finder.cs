using System;
using System.IO;

namespace Models
{
    public static class Finder
    {
        public static string FindFile(string name, string path)
        {
            var result = FindFile(name, new DirectoryInfo(path));
            return (result == null) ? throw new FileNotFoundException($"{name} was not found in {path}") : result;
        }
        private static string FindFile(string name, DirectoryInfo directoryInfo)
        {
            if (directoryInfo == null || !directoryInfo.Exists)
            {
                return null;
            }
            foreach(var file in directoryInfo.EnumerateFiles())
            {
                if (file.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return file.FullName;
                }
            }
            foreach (var subDir in directoryInfo.GetDirectories())
            {
                var result = FindFile(name, subDir);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }
    }
}
