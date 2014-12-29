using System.Collections.Generic;

namespace System.IO.FileSystem
{
    public interface IDirectory
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
        /// Gets a value indicating whether directory exists on disk.
        /// </summary>
        bool Exists();

        /// <summary>
        /// Creates all directories and subdirectories.
        /// </summary>
        void Create();

        /// <summary>
        /// Deletes the directory and, if indicated, any subdirectories and files in the directory.
        /// </summary>
        void Delete();

        /// <summary>
        /// Returns an enumerable of sub directories.
        /// </summary>
        /// <param name="searchPattern">The search string to match against the names of directories.</param>
        /// <returns>
        /// Enumerable of sub directories.
        /// </returns>
        IEnumerable<IDirectory> EnumerateDirectories(string searchPattern);

        /// <summary>
        /// Returns an enumerable of files in directory.
        /// </summary>
        /// <param name="searchPattern">The search string to match against the names of files.</param>
        /// <returns>Enumerable of files in directory.</returns>
        IEnumerable<IFile> EnumerateFiles(string searchPattern);
    }
}
