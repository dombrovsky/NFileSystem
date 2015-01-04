namespace System.IO.Files.Internal
{
    internal static class ExceptionExtensions
    {
        public static FileSystemException AsFileSystemException(this Exception exception)
        {
            return new FileSystemException(exception.Message, exception);
        }

        public static FileSystemSecurityException AsFileSystemSecurityException(this Exception exception)
        {
            return new FileSystemSecurityException(exception.Message, exception);
        }
    }
}
