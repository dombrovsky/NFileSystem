using System.Security;

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
            get
            {
                try
                {
                    return _fileSystemInfo.Attributes;
                }
                catch (SecurityException exception)
                {
                    throw exception.AsFileSystemSecurityException();
                }
                catch (IOException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }

            set
            {
                try
                {
                    _fileSystemInfo.Attributes = value;
                }
                catch (ArgumentException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (SecurityException exception)
                {
                    throw exception.AsFileSystemSecurityException();
                }
                catch (IOException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }
        }

        public DateTime CreationTime
        {
            get
            {
                try
                {
                    return _fileSystemInfo.CreationTime;
                }
                catch (PlatformNotSupportedException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (IOException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }

            set
            {
                try
                {
                    _fileSystemInfo.CreationTime = value;
                }
                catch (PlatformNotSupportedException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (IOException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }
        }

        public DateTime CreationTimeUtc
        {
            get
            {
                try
                {
                    return _fileSystemInfo.CreationTimeUtc;
                }
                catch (PlatformNotSupportedException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (IOException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }

            set
            {
                try
                {
                    _fileSystemInfo.CreationTimeUtc = value;
                }
                catch (PlatformNotSupportedException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (IOException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }
        }

        public DateTime LastAccessTime
        {
            get
            {
                try
                {
                    return _fileSystemInfo.LastAccessTime;
                }
                catch (PlatformNotSupportedException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (IOException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }

            set
            {
                try
                {
                    _fileSystemInfo.LastAccessTime = value;
                }
                catch (PlatformNotSupportedException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (IOException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }
        }

        public DateTime LastAccessTimeUtc
        {
            get
            {
                try
                {
                    return _fileSystemInfo.LastAccessTimeUtc;
                }
                catch (PlatformNotSupportedException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (IOException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }

            set
            {
                try
                {
                    _fileSystemInfo.LastAccessTimeUtc = value;
                }
                catch (PlatformNotSupportedException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (IOException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }
        }

        public DateTime LastWriteTime
        {
            get
            {
                try
                {
                    return _fileSystemInfo.LastWriteTime;
                }
                catch (PlatformNotSupportedException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (IOException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }

            set
            {
                try
                {
                    _fileSystemInfo.LastWriteTime = value;
                }
                catch (PlatformNotSupportedException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (IOException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }
        }

        public DateTime LastWriteTimeUtc
        {
            get
            {
                try
                {
                    return _fileSystemInfo.LastWriteTimeUtc;
                }
                catch (PlatformNotSupportedException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (IOException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }

            set
            {
                try
                {
                    _fileSystemInfo.LastWriteTimeUtc = value;
                }
                catch (PlatformNotSupportedException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (IOException exception)
                {
                    throw exception.AsFileSystemException();
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }
        }

        public void Refresh()
        {
            try
            {
                _fileSystemInfo.Refresh();
            }
            catch (IOException exception)
            {
                throw exception.AsFileSystemException();
            }
        }
    }
}
