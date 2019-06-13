using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformService
{
    public interface ITransformService
    {
        /// <summary>
        /// check file format to see if the file can be transformed or not
        /// </summary>
        /// <param name="fileFullName">file full name</param>
        /// <returns>return true if file can be transformed</returns>
        bool IsRightFileFormat(string fileFullName);

        /// <summary>
        /// transform source file and save as dest file
        /// </summary>
        /// <param name="sourceFile">source file full name</param>
        /// <param name="destFile">dest file full name</param>
        void TransformFile(string sourceFile, string destFile);
    }
}
