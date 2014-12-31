namespace System.IO.FileSystem
{
    /// <summary>
    /// Provides a way to control file or directory attributes and other properties.
    /// </summary>
    public interface IProperties
    {
        /// <summary>
        /// Gets or sets the attributes for the current file or directory.
        /// </summary>
        FileAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the file or directory.
        /// </summary>
        DateTime CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the creation time, in coordinated universal time (UTC), of the file or directory.
        /// </summary>
        DateTime CreationTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the time the current file or directory was last accessed.
        /// </summary>
        DateTime LastAccessTime { get; set; }

        /// <summary>
        /// Gets or sets the time, in coordinated universal time (UTC), that the file or directory was last accessed.
        /// </summary>
        DateTime LastAccessTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the time when the current file or directory was last written to.
        /// </summary>
        DateTime LastWriteTime { get; set; }

        /// <summary>
        /// Gets or sets the time, in coordinated universal time (UTC), when the file or directory was last written to.
        /// </summary>
        DateTime LastWriteTimeUtc { get; set; }
    }
}
