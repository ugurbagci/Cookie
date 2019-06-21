using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["bilgi"] != null)
            {
                HttpCookie cerez = Request.Cookies["bilgi"];
                Label1.Text = cerez["tarih"];
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cerez = new HttpCookie("bilgi");
            // bir cookie birden fazla detayı içerisinde saklayabilir.
            cerez["tarih"] = DateTime.Now.ToString();

            //Göndermeden önce bu cookie ne kadar yaşayacak şeklinde belirtmelisiniz. Eğer bunu yapmazsanız birçok browser cookienizi reddecektir.

            cerez.Expires = DateTime.Now.AddDays(7);
            // Bu noktadan sonra istemciye cookie nizi gönderebilirsiniz.
            Response.Cookies.Add(cerez);
        }
    }
}