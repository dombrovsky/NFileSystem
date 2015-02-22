using System.IO.Files.Internal;
using System.Security;

namespace System.IO.Files
{
    public class FileStreamFactory : IFileStreamFactory
    {
        private readonly FileMode _mode;
        private readonly FileAccess _access;
        private readonly FileShare _share;
        private readonly int _bufferSize;
        private readonly FileOptions _options;

        public FileStreamFactory(FileMode mode)
            : this(mode, mode == FileMode.Append ? FileAccess.Write : FileAccess.ReadWrite, FileShare.Read, 4096, FileOptions.None)
        {
        }

        public FileStreamFactory(FileMode mode, FileAccess access)
            : this(mode, access, FileShare.Read, 4096, FileOptions.None)
        {
        }

        public FileStreamFactory(FileMode mode, FileAccess access, FileShare share)
            : this(mode, access, share, 4096, FileOptions.None)
        {
        }

        public FileStreamFactory(FileMode mode, FileAccess access, FileShare share, int bufferSize)
            : this(mode, access, share, bufferSize, FileOptions.None)
        {
        }

        public FileStreamFactory(FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
        {
            _mode = mode;
            _access = access;
            _share = share;
            _bufferSize = bufferSize;
            _options = options;
        }

        public Stream CreateStream(IFile file)
        {
            try
            {
                return new FileStream(file.Path.AbsolutePath, _mode, _access, _share, _bufferSize, _options);
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
            catch (NotSupportedException exception)
            {
                throw exception.AsFileSystemException();
            }
        }
    }
}
