using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NETWebFormsBlot
{
    public partial class HttpFileCase : System.Web.UI.Page
    {
        protected string MyString;

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpFileCollection MyFileCollection;
            HttpPostedFile MyFile;
            int FileLen;
            System.IO.Stream MyStream;

            MyFileCollection = Request.Files;
            MyFile = MyFileCollection[0];

            FileLen = MyFile.ContentLength;
            byte[] input = new byte[FileLen];

            // Initialize the stream.
            MyStream = MyFile.InputStream;

            // Read the file into the byte array.
            MyStream.Read(input, 0, FileLen);

            // Copy the byte array into a string.
            for (int Loop1 = 0; Loop1 < FileLen; Loop1++)
                MyString = MyString + input[Loop1].ToString();

            // CTSECISSUE:InsecureFileUpload
            File.WriteAllText(@"C:\inetpub\myapp\uploads\", MyString);
        }
    }
}