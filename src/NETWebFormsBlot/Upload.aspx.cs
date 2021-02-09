using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NETWebFormsBlot
{
    public partial class Upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // CTSECISSUE:DirectoryTraversal
            FileInfo fi = new FileInfo(uploadFile.PostedFile.FileName);
            if (uploadFile.PostedFile.FileName != fi.Name)
            {
                // throw exception
            }

            Stream stream = uploadFile.FileContent;
            if (stream != null)
            {
                // nearly all File.Write* and related methods are sinks

                // CTSECISSUE:PossibleInsecureFileUpload
                File.WriteAllBytes(@"C:\uploaded_files\" + uploadFile.PostedFile.FileName, uploadFile.FileBytes);

                // CTSECISSUE:PossibleInsecureFileUpload
                File.WriteAllText(@"C:\uploaded_files\" + uploadFile.PostedFile.FileName, "");

                string mappedAbsolutePath = Server.MapPath(uploadFile.PostedFile.FileName);
                // The above method returns a mapped absolute path, yes, but that's not sanitization
                // Still an attacker can upload or maybe even overwrite a valid file in the directory A Web application that resides.
                // CTSECISSUE:PossibleInsecureFileUpload
                File.WriteAllText(mappedAbsolutePath, "");

                // CTSECISSUE:PossibleInsecureFileUpload
                byte [] buffer = ReadFully(stream);
                string converted = Encoding.UTF8.GetString(buffer, 0, buffer.Length);

                File.WriteAllText(uploadFile.PostedFile.FileName, converted);
            }
        }

        private static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[input.Length];
            //byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}