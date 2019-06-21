using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie
{
    public partial class Ornek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["KullaniciBilgileri"] != null)
            {
                HttpCookie cerez = Request.Cookies["KullaniciBilgileri"];
                lblAd.Text = cerez["KullaniciAdi"];
                lblSifre.Text = cerez["Sifre"];   
                    
            }
        }

        protected void btnOlustur_Click(object sender, EventArgs e)
        {
            HttpCookie cerez = new HttpCookie("KullaiciBilgileri");


            cerez["KullaniciAdi"] = txtKullaniciAdi.Text;
            cerez["Sifre"] = txtSifre.Text;
            cerez.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(cerez);
         }
    }
}