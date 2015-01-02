namespace System.IO.Files.Internal
{
    internal sealed class RealFileSystem : IFileSystem
    {
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
            return new FileSystemPath(IO.Path.GetTempFileName());
        }

        public IPath GetTempPath()
        {
            return new FileSystemPath(IO.Path.GetTempPath());
        }
    }
}
