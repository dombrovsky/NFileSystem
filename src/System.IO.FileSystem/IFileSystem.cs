namespace System.IO.FileSystem
{
    public interface IFileSystem
    {
        /// <summary>
        /// Creates the relative or absolute path.
        /// </summary>
        /// <param name="path">The path string.</param>
        /// <returns>Path representation.</returns>
        IPath Path(string path);

        /// <summary>
        /// Returns the directory representation.
        /// </summary>
        /// <remarks>This method does not create a directory with a specified path or checks if directory exists.</remarks>
        /// <param name="path">The directory path.</param>
        /// <returns>Directory representation.</returns>
        IDirectory Directory(IPath path);

        /// <summary>
        /// Gets an array containing the characters that are not allowed in file names.
        /// </summary>
        /// <returns>
        /// An array containing the characters that are not allowed in file names.
        /// </returns>
        char[] GetInvalidFileNameChars();

        /// <summary>
        /// Gets an array containing the characters that are not allowed in path names.
        /// </summary>
        /// <returns>
        /// An array containing the characters that are not allowed in path names.
        /// </returns>
        char[] GetInvalidPathChars();

        /// <summary>
        /// Returns a random folder name or file name.
        /// </summary>
        /// <returns>
        /// A random folder name or file name.
        /// </returns>
        string GetRandomFileName();

        /// <summary>
        /// Creates a uniquely named, zero-byte temporary file on disk and returns the full path of that file.
        /// </summary>
        /// <returns>
        /// The full path of the temporary file.
        /// </returns>
        IPath GetTempFileName();

        /// <summary>
        /// Returns the path of the current user's temporary folder.
        /// </summary>
        /// <returns>
        /// The path to the temporary folder, ending with a backslash.
        /// </returns>
        IPath GetTempPath();
    }
}
