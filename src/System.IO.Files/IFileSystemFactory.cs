namespace System.IO.Files
{
    /// <summary>
    /// File system factory.
    /// </summary>
    public interface IFileSystemFactory
    {
        /// <summary>
        /// Creates file system access entity.
        /// </summary>
        /// <returns>Root object for accesiing file system.</returns>
        IFileSystem Create();
    }
}
