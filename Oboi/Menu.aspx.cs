using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlClient;
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
            Wallpaper.ImageUrl = "Resources/" + x + ".jpg";

            string connectionString = @"Data Source=BOGDAN\BOGDANMSSQLSERV;Initial Catalog=Wallpapers;Integrated Security=True";
            SqlConnection conn = new SqlConnection(
               connectionString);


            conn.Open();

            SqlCommand command = conn.CreateCommand();
            command.CommandText = @"SELECT * FROM dbo.Photoes WHERE Article='" + Article_DB.Text + "'";
                SqlDataReader thisReader = command.ExecuteReader();
                while (thisReader.Read())
                {
                    Cost_TB.Text = thisReader["Cost"].ToString();
                    Balance_SP_TB.Text = thisReader["BalanceSP"].ToString();
                    Balance_T_TB.Text = thisReader["BalanceTuran"].ToString();
                Country_L2.Text = thisReader["ID_country"].ToString();
                Size_L2.Text = thisReader["ID_size"].ToString();
                Material_L2.Text = thisReader["ID_material"].ToString();

            }
                thisReader.Close();

            SqlCommand command2 = conn.CreateCommand();
            command2.CommandText = @"SELECT * FROM dbo.Countries WHERE ID_Country='" + Country_L2.Text + "'";
            SqlDataReader thisReader2 = command2.ExecuteReader();
            while (thisReader2.Read())
            {
                
                Country_L2.Text = thisReader2["Country"].ToString();

            }
            thisReader2.Close();

            SqlCommand command3 = conn.CreateCommand();
            command3.CommandText = @"SELECT * FROM dbo.Sizes WHERE ID_size='" + Size_L2.Text + "'";
            SqlDataReader thisReader3 = command3.ExecuteReader();
            while (thisReader3.Read())
            {

                Size_L2.Text = thisReader3["Size"].ToString();

            }
            thisReader3.Close();

            SqlCommand command4 = conn.CreateCommand();
            command4.CommandText = @"SELECT * FROM dbo.Materials WHERE ID_material='" + Material_L2.Text + "'";
            SqlDataReader thisReader4 = command4.ExecuteReader();
            while (thisReader4.Read())
            {

                Material_L2.Text = thisReader4["Material"].ToString();

            }
            thisReader4.Close();
            conn.Close();
            
        }
    }
}
    