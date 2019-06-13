using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransformService;
using Transformer;

namespace TransformSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //if parameters is wrong, then display usage's message 
                if (args.Length != 2)
                {
                    ShowApplicationUsage();
                    return;
                }

                string sourceFolder = args[0].Trim();
                string destFolder = args[1].Trim();
                Console.WriteLine($"Transforming files from folder: '{sourceFolder}', and saved to folder '{destFolder}'");

                //add known transformer
                List <ITransformService> transformers = new List<ITransformService>();
                transformers.Add(new Transformer1());
                transformers.Add(new Transformer2());

                AccountFile.AccountFile accountFile = new AccountFile.AccountFile(transformers);
                //transform file from source folder and save to dest folder
                accountFile.TransformFiles(sourceFolder, destFolder);

                Console.WriteLine($"Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void ShowApplicationUsage()
        {
            Console.WriteLine("Error: missing/wrong parameter");
            Console.WriteLine("Usage: TransformSystem \"source folder\" \"dest folder\"");
        }
    }
}
