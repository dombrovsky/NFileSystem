using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace System.IO.Files.Internal
{
    internal sealed class RealFileSystem : IFileSystem
    {
        public IDirectory CurrentDirectory
        {
            get
            {
                try
                {
                    return Directory(Path(IO.Directory.GetCurrentDirectory()));   
                }
                catch (UnauthorizedAccessException exception)
                {
                    throw exception.AsFileSystemSecurityException();
                }
                catch (NotSupportedException exception)
                {
                    throw exception.AsFileSystemException();
                }
            }
            set
            {
                try
                {
                    IO.Directory.SetCurrentDirectory(value.Path.OriginalPath);   
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

        public IPath Path(string path)
        {
            return new FileSystemPath(path);
        }

        public IDirectory Directory(IPath path)
        {
            return new Directory(path);
        }

        public IFile File(IPath path)
        {
            return new File(path);
        }

        public char[] GetInvalidFileNameChars()
        {
            return IO.Path.GetInvalidFileNameChars();
        }

        public char[] GetInvalidPathChars()
        {
            return IO.Path.GetInvalidPathChars();
        }

        public string GetRandomFileName()
        {
            return IO.Path.GetRandomFileName();
        }

        public IPath GetTempFileName()
        {
            try
            {
                return new FileSystemPath(IO.Path.GetTempFileName());
            }
            catch (IOException exception)
            {
                throw exception.AsFileSystemException();
            }
        }

        public IPath GetTempPath()
        {
            try
            {
                return new FileSystemPath(IO.Path.GetTempPath());
            }
            catch (SecurityException exception)
            {
                throw exception.AsFileSystemSecurityException();
            }
        }

        public IEnumerable<IPath> GetLogicalDrives()
        {
            try
            {
                return IO.Directory.GetLogicalDrives().Select(s => new FileSystemPath(s));
            }
            catch (IOException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (UnauthorizedAccessException exception)
            {
                throw exception.AsFileSystemException();
            }
        }
    }
}
