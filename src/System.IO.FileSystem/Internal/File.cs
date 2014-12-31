namespace System.IO.FileSystem.Internal
{
    internal sealed class File : IFile
    {
        private readonly IPath _filePath;
        private readonly FileInfo _fileInfo;

        public File(IPath filePath)
        {
            _filePath = filePath;
            _fileInfo = new FileInfo(_filePath.OriginalPath);
        }

        public IPath Path
        {
            get { return _filePath; }
        }

        public IDirectory Parent
        {
            get
            {
                if (_fileInfo.Directory != null)
                {
                    return new Directory(new FileSystemPath(_fileInfo.Directory.FullName));
                }

                return null;
            }
        }

        public IProperties Properties
        {
            get { return new Properties(_fileInfo); }
        }

        public bool Exists()
        {
            return _fileInfo.Exists;
        }

        public void Delete()
        {
            _fileInfo.Delete();
        }

        public void Decrypt()
        {
            _fileInfo.Decrypt();
        }

        public void Encrypt()
        {
            _fileInfo.Encrypt();
        }

        public Stream AsStream(IFileStreamFactory fileStreamFactory)
        {
            return fileStreamFactory.CreateStream(this);
        }
    }
}
