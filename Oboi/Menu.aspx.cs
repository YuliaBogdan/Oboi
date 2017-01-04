using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Oboi
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void Find_Click(object sender, EventArgs e)
        {
            string x = Article_DB.Text;
            Wallpaper.ImageUrl = "Resources/"+ x +".jpg";

           
        }
     }

}
    