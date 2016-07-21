using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text;


// USAGE
// Author   : Eldon B. Tenorio
// Date     : October 13, 2015
// 
// 1. Import the latest SccEndpointDecryptor.dll to the Reference.
// 2. Import or Using it in your code               : Using SccEndpointDecryptor;
// 3. Declare a variable of type EndPointDecryptor  : EndpointDecryptor objEndpointDecr = new EndpointDecryptor();
// 4. Set the path of the endpoint.bin              : objEndpointDecr.SourceFilname = @"C:\ProgramData\4sIT\SCC\.SCC\endpoints.bin";
// 5. Extract the decrypted file content            : string fileContent = objEndpointDecr.ExtractDecrytedContent();

namespace SccEndpointDecryptor
{
    public class EndpointDecryptor
    {
        const string SECRET_DECR_KEY = "EJKDODDD";
        const string SECRET_INIT_VEC = "AOEMEYDD";
        private string sourceFilename = "";

        public string SourceFilename
        {
            get { return sourceFilename; }
            set { this.sourceFilename = value; }
        }

        public EndpointDecryptor()
        {
        }

        public string ExtractDecrytedContent()
        {
            string tmpDecryptedContent = "";

            try
            {
                if (this.sourceFilename.Trim() != "")
                {
                    if (File.Exists(this.sourceFilename))
                    {
                        DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                        DES.Key = ASCIIEncoding.ASCII.GetBytes(SECRET_DECR_KEY);
                        DES.IV = ASCIIEncoding.ASCII.GetBytes(SECRET_INIT_VEC);
                        FileStream fsread = new FileStream(this.sourceFilename, FileMode.Open, FileAccess.Read);
                        ICryptoTransform desdecrypt = DES.CreateDecryptor();
                        CryptoStream cryptostreamDecr = new CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read);
                        tmpDecryptedContent = new StreamReader(cryptostreamDecr).ReadToEnd();
                    }
                    else
                    {
                        tmpDecryptedContent = "File path incorrect or does not exist.";
                    }
                }
                else
                {
                    tmpDecryptedContent = "Source filename not specified.";
                }
            }
            catch (Exception ex)
            {
                tmpDecryptedContent = ex.Message;
            }
            return tmpDecryptedContent;
        }
    }
}
