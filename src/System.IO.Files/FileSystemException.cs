namespace System.IO.Files
{
    /// <summary>
    /// Abstracts any error that could happen during file system operations.
    /// </summary>
    [Serializable]
    public class FileSystemException : IOException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSystemException"/> class.
        /// </summary>
        public FileSystemException()
        {            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSystemException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error. </param>
        public FileSystemException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSystemException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param><param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public FileSystemException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
