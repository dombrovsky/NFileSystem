namespace System.IO.Files
{
    /// <summary>
    /// File system path.
    /// </summary>
    public interface IPath
    {
        /// <summary>
        /// Gets the absolute path.
        /// </summary>
        string AbsolutePath { get; }

        /// <summary>
        /// Gets the original path.
        /// </summary>
        string OriginalPath { get; }

        /// <summary>
        /// Gets a value indicating whether a path includes a file name extension.
        /// </summary>
        bool HasExtension { get; }

        /// <summary>
        /// Gets the extension.
        /// </summary>
        /// <returns>
        /// The extension of the path (including the period ".") or <see cref="F:System.String.Empty"/>.
        /// </returns>
        string Extension { get; }

        /// <summary>
        /// Gets the file name and extension.
        /// </summary>
        /// <returns>
        /// The characters after the last directory character. If the last character is a directory or volume separator character, this method returns <see cref="F:System.String.Empty"/>.
        /// </returns>
        string Name { get; }

        /// <summary>
        /// Gets the file name string without the extension.
        /// </summary>
        /// <returns>
        /// The string returned by <see cref="Name"/>, minus the last period (.) and all characters following it.
        /// </returns>
        string NameWithoutExtension { get; }

        /// <summary>
        /// Gets the root directory path.
        /// </summary>
        /// <returns>
        /// The root directory of this path, such as "C:\", or an empty string if path does not contain root directory information.
        /// </returns>
        IPath Root { get; }

        /// <summary>
        /// Gets a value indicating whether the path contains a root.
        /// </summary>
        bool IsAbsolute { get; }

        /// <summary>
        /// Changes the extension of a path.
        /// </summary>
        /// <param name="extension">The new extension (with or without a leading period). Specify null to remove an existing extension.</param>
        /// <returns>
        /// The modified path information.
        /// </returns>
        IPath ChangeExtension(string extension);

        /// <summary>
        /// Combines current path with the specified relative path.
        /// </summary>
        /// <param name="relativePath">The relative path.</param>
        /// <returns>Combined path.</returns>
        IPath Combine(string relativePath);

        /// <summary>
        /// Combines current path with the specified relative path.
        /// </summary>
        /// <param name="relativePath">The relative path.</param>
        /// <returns>Combined path.</returns>
        IPath Combine(IPath relativePath);
    }
}
