using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StitchEditor
{
    /// <summary>
    /// The StitchEngine is responsible for loading stitch files, providing an interface to 
    /// edit stitch objects, providing an interface to render stich object in OpenGL.
    /// </summary>
    class StitchEngine
    {
        public bool LoadStitchFile(string filepath)
        {
            try
            {

            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        /// <summary>
        /// Writes an exception to the error log ErrorLog.txt located in the base directory
        /// </summary>
        /// <param name="ex">the exception</param>
        public static void LogError(Exception ex)
        {
            StreamWriter sw = null;
            try
            {
                System.IO.Directory.CreateDirectory(baseLogDirectory);
                sw = new StreamWriter(baseLogDirectory + "\\ErrorLog.txt", true);
                sw.WriteLine(string.Format("{0}: {1}; {2}", DateTime.Now, ex.Source.Trim(), ex.Message.Trim()));
                sw.Flush();
                sw.Close();
            }
            catch
            {
                return;
            }
        }


    }




}
