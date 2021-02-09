using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NETWebFormsBlot
{
    public partial class ClientSideCodeInj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string url = HttpContext.Current.Request.Params["includedURL"];
            
            // CTSECISSUE:RemoteClientSideCodeInjection
            Page.ClientScript.RegisterClientScriptInclude("RequestParameterScript", url);


            String csname = "ButtonClickScript";
            String csurl = Request.Params["url"];
            Type cstype = this.GetType();
            ClientScriptManager cs = Page.ClientScript;
            // CTSECISSUE:RemoteClientSideCodeInjection
            cs.RegisterClientScriptInclude(cstype, csname,csurl);
        }
    }
}