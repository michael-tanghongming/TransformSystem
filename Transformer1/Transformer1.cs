using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransformModel;
using TransformService;

namespace Transformer
{
    public class Transformer1 : ITransformService
    {
        public string Identifier;
        public string Name;
        public string Type;
        public string Opened;
        public string Currency;

        //return true if file can be transformed
        public bool IsRightFileFormat(string fileContent)
        {
            //read file content and compare with known format, return true if matched
            return true;
        }

        //transform source file and save as dest file
        public void TransformFile(string sourceFile, string destFile)
        {
            List<string> destDatas = new List<string>();

            string[] sourceDatas = File.ReadAllLines(sourceFile);
            for (int n = 0; n < sourceDatas.Count(); n++)
            {
                Account account = GetAccountData(sourceDatas[n]);
                destDatas.Add(account.GetString());
            }

            File.WriteAllText(destFile, String.Join(Environment.NewLine, destDatas.ToArray()));
        }

        private Account GetAccountData(string data)
        {
            Account account = new Account();
            //fill account data here
            return account;
        }
    }
}
