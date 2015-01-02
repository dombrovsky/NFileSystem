namespace System.IO.Files.Internal
{
    internal sealed class Properties : IProperties
    {
        private readonly FileSystemInfo _fileSystemInfo;

        public Properties(FileSystemInfo fileSystemInfo)
        {
            _fileSystemInfo = fileSystemInfo;
        }

        public FileAttributes Attributes
        {
            get { return _fileSystemInfo.Attributes; }
            set { _fileSystemInfo.Attributes = value; }
        }

        public DateTime CreationTime
        {
            get { return _fileSystemInfo.CreationTime; }
            set { _fileSystemInfo.CreationTime = value; }
        }

        public DateTime CreationTimeUtc
        {
            get { return _fileSystemInfo.CreationTimeUtc; }
            set { _fileSystemInfo.CreationTimeUtc = value; }
        }

        public DateTime LastAccessTime
        {
            get { return _fileSystemInfo.LastAccessTime; }
            set { _fileSystemInfo.LastAccessTime = value; }
        }

        public DateTime LastAccessTimeUtc
        {
            get { return _fileSystemInfo.LastAccessTimeUtc; }
            set { _fileSystemInfo.LastAccessTimeUtc = value; }
        }

        public DateTime LastWriteTime
        {
            get { return _fileSystemInfo.LastWriteTime; }
            set { _fileSystemInfo.LastWriteTime = value; }
        }

        public DateTime LastWriteTimeUtc
        {
            get { return _fileSystemInfo.LastWriteTimeUtc; }
            set { _fileSystemInfo.LastWriteTimeUtc = value; }
        }
    }
}
