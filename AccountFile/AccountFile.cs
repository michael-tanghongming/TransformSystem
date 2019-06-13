using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransformService;

namespace AccountFile
{
    public class AccountFile
    {
        private List<ITransformService> transformers;

        public AccountFile(List<ITransformService> transformers)
        {
            this.transformers = transformers;
        }

        public void TransformFiles(string sourceFolder, string destFolder)
        {
            string[] sourceFiles = Directory.GetFiles(sourceFolder);
            foreach (string sourceFile in sourceFiles)
            {
                string fileName = Path.GetFileName(sourceFile);
                string destFile = Path.Combine(destFolder, fileName);
                try
                {
                    Console.WriteLine($"Transforming file ({fileName}) ...");

                    bool fileTransformed = false;
                    foreach (ITransformService transformer in transformers)
                    {
                        if (transformer.IsRightFileFormat(sourceFile))
                        {
                            transformer.TransformFile(sourceFile, destFile);
                            fileTransformed = true;
                            break;
                        }
                    }

                    if (!fileTransformed)
                    {
                        Console.WriteLine($"Transform system does not support this file format: {fileName}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error while transforming file ({fileName}): {ex.Message}");
                }
            }
        }
    }
}
