namespace System.IO.FileSystem
{
    public interface IFile
    {
        /// <summary>
        /// Gets the path of a directory.
        /// </summary>
        IPath Path { get; }

        /// <summary>
        /// Gets the parent directory.
        /// </summary>
        IDirectory Parent { get; }

        /// <summary>
        /// Gets a value indicating whether file exists on disk.
        /// </summary>
        bool Exists();

        /// <summary>
        /// Deletes the file.
        /// </summary>
        void Delete();
    }
}
