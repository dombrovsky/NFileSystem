using System.Security;

namespace System.IO.Files.Internal
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
            try
            {
                _fileInfo.Delete();
            }
            catch (UnauthorizedAccessException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (IOException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (SecurityException exception)
            {
                throw exception.AsFileSystemSecurityException();
            }
        }

        public void Decrypt()
        {
            try
            {
                _fileInfo.Decrypt();
            }
            catch (UnauthorizedAccessException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (IOException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (PlatformNotSupportedException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (NotSupportedException exception)
            {
                throw exception.AsFileSystemException();
            }
        }

        public void Encrypt()
        {
            try
            {
                _fileInfo.Encrypt();
            }
            catch (UnauthorizedAccessException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (IOException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (PlatformNotSupportedException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (NotSupportedException exception)
            {
                throw exception.AsFileSystemException();
            }
        }

        public long GetLength()
        {
            try
            {
                return _fileInfo.Length;
            }
            catch (IOException exception)
            {
                throw exception.AsFileSystemException();
            }
        }

        public Stream AsStream(IFileStreamFactory fileStreamFactory)
        {
            return fileStreamFactory.CreateStream(this);
        }
    }
}
