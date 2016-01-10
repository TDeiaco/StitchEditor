using System;
using System.IO;
using TLib;

namespace StitchEditor
{
    /// <summary>
    /// The StitchEngine is responsible for loading stitch files, providing an interface to 
    /// edit stitch objects, providing an interface to render stich object in OpenGL.
    /// </summary>
    class StitchEngine
    {
        /// <summary>
        /// 
        /// </summary>
        private byte[] _rawFile;
        /// <summary>
        /// Raw byte[] data of the loaded stich file.
        /// </summary>
        public byte[] RawFile
        {
            get { return _rawFile; }
            set { _rawFile = value; }
        }

        /// <summary>
        /// Loads raw stitch fle.
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public bool LoadStitchFile(string filepath)
        {
            try
            {
                RawFile = ReadFile(filepath);
                return true;
            }
            catch (Exception ex)
            {
                TLogging.LogError(ex);
                return false;
            }
        }

        /// <summary>
        /// Safely read a file into a byte array.           
        /// </summary>
        /// <param name="filePath">Filepath of file to read into byte array.</param>
        /// <returns>Byte array containing the enitre file at "filePath".</returns>
        public static byte[] ReadFile(string filePath)
        {
            byte[] buffer;
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                int length = (int)fileStream.Length;  // get file length
                buffer = new byte[length];            // create buffer
                int count;                            // actual number of bytes read
                int sum = 0;                          // total number of bytes read

                // read until Read method returns 0 (end of the stream has been reached)
                while ((count = fileStream.Read(buffer, sum, length - sum)) > 0)
                    sum += count;  // sum is a buffer offset for next reading
            }
            finally
            {
                fileStream.Close();
            }
            return buffer;
        }
    }
}
