using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Application_state
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["MySession"] = "WELCOME";

            //Response.Write("The num of users online=" + Application["user"].ToString());
            
            Application["user"] = (int)Application["user"] + 1;
            //int a = 0;
            //var s = 5 / a;
        }
    }
}