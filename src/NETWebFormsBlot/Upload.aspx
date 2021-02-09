<!-- CTSECISSUE:UnsafeTraceDirective -->
<%@ Page Trace="true" Language="C#" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="NETWebFormsBlot.Upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <asp:FileUpload ID="uploadFile" runat="server" />
                <asp:Button ID="Button1" runat="server" Text="Gönder" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
