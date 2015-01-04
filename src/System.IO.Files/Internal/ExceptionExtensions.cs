using System;
using System.Collections.Generic;
using System.Linq;
namespace System.IO.Files.Internal
{
    internal static class ExceptionExtensions
    {
        public static void ThrowAsFileSystemException(this Exception exception)
        {
            throw new FileSystemException(exception.Message, exception);
        }

        public static void ThrowAsFileSystemSecurityException(this Exception exception)
        {
            throw new FileSystemSecurityException(exception.Message, exception);
        }
    }
}
