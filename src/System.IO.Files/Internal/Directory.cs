using System.Collections.Generic;
using System.Linq;

namespace System.IO.Files.Internal
{
    internal sealed class Directory : IDirectory
    {
        private readonly IPath _directoryPath;
        private readonly DirectoryInfo _directoryInfo;

        public Directory(IPath directoryPath)
        {
            _directoryPath = directoryPath;
            _directoryInfo = new DirectoryInfo(_directoryPath.OriginalPath);
        }

        public IPath Path
        {
            get { return _directoryPath; }
        }

        public IDirectory Parent
        {
            get
            {
                if (_directoryInfo.Parent != null)
                {
                    return new Directory(new FileSystemPath(_directoryInfo.Parent.FullName));    
                }

                return null;
            }
        }

        public IProperties Properties
        {
            get { return new Properties(_directoryInfo); }
        }

        public bool Exists()
        {
            return _directoryInfo.Exists;
        }

        public void Create()
        {
            IO.Directory.CreateDirectory(_directoryPath.OriginalPath);
        }

        public void Delete()
        {
            _directoryInfo.Delete(true);
        }

        public IEnumerable<IDirectory> EnumerateDirectories(string searchPattern)
        {
            return _directoryInfo.EnumerateDirectories(searchPattern).Select(info => new Directory(new FileSystemPath(info.FullName)));
        }

        public IEnumerable<IFile> EnumerateFiles(string searchPattern)
        {
            return _directoryInfo.EnumerateFiles(searchPattern).Select(info => new File(new FileSystemPath(info.FullName)));
        }
    }
}
