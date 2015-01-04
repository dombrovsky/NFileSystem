using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace System.IO.Files.Internal
{
    internal sealed class Directory : IDirectory
    {
        private readonly IPath _directoryPath;
        private readonly DirectoryInfo _directoryInfo;

        public Directory(IPath directoryPath)
        {
            _directoryPath = directoryPath;

            try
            {
                _directoryInfo = new DirectoryInfo(_directoryPath.OriginalPath);   
            }
            catch (ArgumentException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (PathTooLongException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (SecurityException exception)
            {
                throw exception.AsFileSystemSecurityException();
            }
        }

        public IPath Path
        {
            get { return _directoryPath; }
        }

        public IDirectory Parent
        {
            get
            {
                try
                {
                    if (_directoryInfo.Parent != null)
                    {
                        return new Directory(new FileSystemPath(_directoryInfo.Parent.FullName));
                    }

                    return null;   
                }
                catch (SecurityException exception)
                {
                    throw exception.AsFileSystemSecurityException();
                }
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
            try
            {
                IO.Directory.CreateDirectory(_directoryPath.OriginalPath);   
            }
            catch (UnauthorizedAccessException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (IOException exception)
            {
                throw exception.AsFileSystemException();
            }
        }

        public void Delete()
        {
            try
            {
                _directoryInfo.Delete(true);    
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

        public IEnumerable<IDirectory> EnumerateDirectories(string searchPattern)
        {
            try
            {
                return _directoryInfo.EnumerateDirectories(searchPattern).Select(info => new Directory(new FileSystemPath(info.FullName)));
            }
            catch (ArgumentException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (DirectoryNotFoundException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (SecurityException exception)
            {
                throw exception.AsFileSystemSecurityException();
            }
        }

        public IEnumerable<IFile> EnumerateFiles(string searchPattern)
        {
            try
            {
                return _directoryInfo.EnumerateFiles(searchPattern).Select(info => new File(new FileSystemPath(info.FullName)));   
            }
            catch (ArgumentException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (DirectoryNotFoundException exception)
            {
                throw exception.AsFileSystemException();
            }
            catch (SecurityException exception)
            {
                throw exception.AsFileSystemSecurityException();
            }
        }
    }
}
