namespace Smartstore.IO
{
    public interface IDirectory : IFileEntry
    {
        /// <summary>
        /// Determines whether the directory is the root directory of the file storage.
        /// </summary>
        bool IsRoot { get; }

        /// <summary>
        /// The parent directory.
        /// </summary>
        /// <exception cref="FileSystemException">Thrown if the directory does not exist.</exception>
        IDirectory Parent { get; }
    }
}