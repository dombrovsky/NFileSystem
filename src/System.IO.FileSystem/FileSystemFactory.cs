using System.IO.FileSystem.Internal;

namespace System.IO.FileSystem
{
    /// <summary>
    /// Factory of real file system access objects.
    /// </summary>
    public sealed class FileSystemFactory : IFileSystemFactory
    {
        public IFileSystem Create()
        {
            return new RealFileSystem();
        }
    }
}
