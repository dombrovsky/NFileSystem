﻿namespace System.IO.Files
{
    /// <summary>
    /// Abstracts security error that could happen during file system operations.
    /// </summary>
    [Serializable]
    public class FileSystemSecurityException : FileSystemException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSystemSecurityException"/> class.
        /// </summary>
        public FileSystemSecurityException()
        {            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSystemSecurityException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error. </param>
        public FileSystemSecurityException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSystemSecurityException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param><param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public FileSystemSecurityException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}