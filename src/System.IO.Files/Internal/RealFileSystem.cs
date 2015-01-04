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
                    exception.ThrowAsFileSystemSecurityException();
                }
                catch (NotSupportedException exception)
                {
                    exception.ThrowAsFileSystemException();
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
                    exception.ThrowAsFileSystemException();
                }
                catch (SecurityException exception)
                {
                    exception.ThrowAsFileSystemSecurityException();
                }
                catch (IOException exception)
                {
                    exception.ThrowAsFileSystemException();
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
                exception.ThrowAsFileSystemException();
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
                exception.ThrowAsFileSystemSecurityException();
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
                exception.ThrowAsFileSystemException();
            }
            catch (UnauthorizedAccessException exception)
            {
                exception.ThrowAsFileSystemSecurityException();
            }
        }
    }
}
