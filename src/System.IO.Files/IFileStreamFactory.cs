namespace System.IO.Files
{
    /// <summary>
    /// Factory that creates file streams.
    /// </summary>
    public interface IFileStreamFactory
    {
        /// <summary>
        /// Creates the stream for specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns>Opened stream.</returns>
        Stream CreateStream(IFile file);
    }
}
