﻿using System.IO.Files.Internal;

namespace System.IO.Files
{
    /// <summary>
    /// Factory of real file system access objects.
    /// </summary>
    public sealed class FileSystemFactory : IFileSystemFactory
    {
        public IFileSystem Create()
        {
            return new RealFileSystem();
        }
    }
}
