using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie
{
    public partial class Anket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Anket"]!=null)
            {
                HttpCookie cerez = Request.Cookies["Anket"];
                RadioButtonList1.SelectedValue = cerez["secim"];
                btnOyVer.Enabled = false;
                RadioButtonList1.Enabled = false;
            }
        }

        protected void btnOyVer_Click(object sender, EventArgs e)
        {
            HttpCookie cerez = new HttpCookie("Anket");
            cerez["secim"] = RadioButtonList1.SelectedValue;
            cerez.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(cerez);
        }
    }
}