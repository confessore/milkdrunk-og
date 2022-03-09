using System;
using System.IO;

namespace milkdrunk.statics
{
    /// <summary>
    /// a static class for device directory and file paths
    /// </summary>
    public static class Paths
    {
        /// <summary>
        /// the path to the local application data directory on android
        /// </summary>
        public static string LocalApplicationDataDirectory =>
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        /// <summary>
        /// the path to the mydocuments directory on ios
        /// </summary>
        static string MyDocumentsDirectory =>
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        /// <summary>
        /// the path to the tmp directory on ios
        /// </summary>
        static string TemporaryDirectory =>
            Path.Combine(MyDocumentsDirectory, "..", "tmp");

        /// <summary>
        /// the path to the library directory on ios
        /// </summary>
        static string LibraryDirectory =>
            Path.Combine(MyDocumentsDirectory, "..", "Library");

        /// <summary>
        /// the path the caches directory on ios
        /// </summary>
        public static string CachesDirectory =>
            Path.Combine(LibraryDirectory, "Caches");

        /// <summary>
        /// the path to a specified local application data file on android
        /// </summary>
        /// <param name="filename">the name of the file (extension optional)</param>
        /// <returns>a <see cref="string"/> path to a specified local application data file</returns>
        public static string LocalApplicationDataFile(string filename) =>
            Path.Combine(LocalApplicationDataDirectory, "milkdrunk", filename);

        public static string TemporaryFile(string filename) =>
            Path.Combine(TemporaryDirectory, filename);

        /// <summary>
        /// the path to a specified mydocuments file on ios
        /// </summary>
        /// <param name="filename">the name of the file (extension optional)</param>
        /// <returns>a <see cref="string"/> path to a specified mydocuments file</returns>
        static string MyDocumentsFile(string filename) =>
            Path.Combine(MyDocumentsDirectory, filename);

        /// <summary>
        /// the path to a specified library file on ios
        /// </summary>
        /// <param name="filename">the name of the file (extension optional)</param>
        /// <returns>a <see cref="string"/> path to a specified library file</returns>
        static string LibraryFile(string filename) =>
            Path.Combine(LibraryDirectory, filename);

        /// <summary>
        /// the path to a specified caches file on ios
        /// </summary>
        /// <param name="filename">the name of the file (extension optional)</param>
        /// <returns>a <see cref="string"/> path to a specified caches file</returns>
        public static string CachesFile(string filename) =>
            Path.Combine(CachesDirectory, filename);
    }
}
