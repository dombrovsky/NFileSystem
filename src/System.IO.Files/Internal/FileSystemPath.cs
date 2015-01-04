using System.Security;

namespace System.IO.Files.Internal
{
    internal sealed class FileSystemPath : IPath
    {
        private readonly string _originalPath;
        private readonly string _absolutePath;

        public FileSystemPath(string path)
        {
            _originalPath = path;

            try
            {
                _absolutePath = Path.GetFullPath(_originalPath);
            }
            catch (ArgumentException exception)
            {
                throw new FileSystemException(exception.Message, exception);
            }
            catch (SecurityException exception)
            {
                throw new FileSystemSecurityException(exception.Message, exception);
            }
            catch (NotSupportedException exception)
            {
                throw new FileSystemException(exception.Message, exception);
            }
            catch (PathTooLongException exception)
            {
                throw new FileSystemException(exception.Message, exception);
            }
        }

        public string AbsolutePath
        {
            get { return _absolutePath; }
        }

        public string OriginalPath
        {
            get { return _originalPath; }
        }

        public bool HasExtension
        {
            get { return Path.HasExtension(_originalPath); }
        }

        public string Extension
        {
            get { return Path.GetExtension(_originalPath); }
        }

        public string Name
        {
            get { return Path.GetFileName(_originalPath); }
        }

        public string NameWithoutExtension
        {
            get { return Path.GetFileNameWithoutExtension(_originalPath); }
        }

        public IPath Root
        {
            get { return new FileSystemPath(Path.GetPathRoot(_absolutePath)); }
        }

        public bool IsAbsolute
        {
            get { return Path.IsPathRooted(_originalPath); }
        }

        public IPath ChangeExtension(string extension)
        {
            return new FileSystemPath(Path.ChangeExtension(_originalPath, extension));
        }

        public IPath Combine(string relativePath)
        {
            try
            {
                return new FileSystemPath(Path.Combine(_originalPath, relativePath));
            }
            catch (ArgumentException exception)
            {
                throw new FileSystemException(exception.Message, exception);
            }
        }

        public IPath Combine(IPath relativePath)
        {
            return new FileSystemPath(Path.Combine(_originalPath, relativePath.OriginalPath));
        }
    }
}
