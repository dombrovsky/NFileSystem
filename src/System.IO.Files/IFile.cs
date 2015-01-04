namespace System.IO.Files
{
    /// <summary>
    /// Represents a file.
    /// </summary>
    public interface IFile
    {
        /// <summary>
        /// Gets the path of a file.
        /// </summary>
        IPath Path { get; }

        /// <summary>
        /// Gets the parent directory.
        /// </summary>
        IDirectory Parent { get; }

        /// <summary>
        /// Gets the file properties.
        /// </summary>
        IProperties Properties { get; }

        /// <summary>
        /// Gets a value indicating whether file exists on disk.
        /// </summary>
        bool Exists();

        /// <summary>
        /// Deletes the file.
        /// </summary>
        void Delete();

        /// <summary>
        /// Decrypts a file that was encrypted by the current account using the <see cref="Encrypt()"/> method.
        /// </summary>
        void Decrypt();

        /// <summary>
        /// Encrypts a file so that only the account used to encrypt the file can decrypt it.
        /// </summary>
        void Encrypt();

        /// <summary>
        /// Gets the size, in bytes, of the current file.
        /// </summary>
        /// <returns>
        /// The size of the current file in bytes.
        /// </returns>
        long GetLength();

        /// <summary>
        /// Opens stream to the file using specified factory.
        /// </summary>
        /// <param name="fileStreamFactory">The file stream factory.</param>
        /// <returns>Opened file stream.</returns>
        Stream AsStream(IFileStreamFactory fileStreamFactory);
    }
}
