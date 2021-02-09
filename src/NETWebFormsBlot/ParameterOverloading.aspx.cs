using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NETWebFormsBlot
{
    public partial class ParameterOverloading : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // CTSECISSUE:HTTPParameterOverloading
            string userName = Request["username"];

            // CTSECISSUE:HTTPParameterOverloading
            string description = Request.Params["description"];
        }
    }
}