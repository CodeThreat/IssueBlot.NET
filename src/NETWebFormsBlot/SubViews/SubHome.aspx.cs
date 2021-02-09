using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NETWebFormsBlot.SubViews
{
    public partial class SubHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CTSECISSUE:ReflectedCrossSiteScripting
            Label1.Text = Request["com"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //CTSECISSUE:ReflectedCrossSiteScripting
            Label1.Text = TextBox1.Text;
        }
    }
}