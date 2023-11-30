using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoRopaDeportiva
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = TextBox1.Text;
            string pass = TextBox2.Text;

            Response.Redirect("...");
        }
    }
}