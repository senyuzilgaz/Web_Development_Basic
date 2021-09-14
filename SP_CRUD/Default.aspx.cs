using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SP_CRUD
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GetProducts();
        }
        SqlConnection con = new SqlConnection(@"Data Source=FıSTıK\SQLEXPRESS;Initial Catalog=CRUD_SP;Integrated Security=SSPI;");
  
        void GetProducts()
        {
            SqlCommand co = new SqlCommand("exec Show_Products", con);
            SqlDataAdapter sd = new SqlDataAdapter(co);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string name = TextBox7.Text, spec = TextBox8.Text, status = RadioButtonList1.SelectedValue;
            DateTime date = DateTime.Parse(TextBox11.Text);
            con.Open();
            SqlCommand com = new SqlCommand("exec Products_Setup '" + name + "', '" + spec + "', '" + status + "', '" + date + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Succesfully Inserted!');", true);
            GetProducts();
        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            string name = TextBox7.Text, spec = TextBox8.Text, status = RadioButtonList1.SelectedValue;
            DateTime date = DateTime.Parse(TextBox11.Text);
            con.Open();
            SqlCommand com = new SqlCommand("exec Update_Product '" + name + "', '" + spec + "', '" + status + "', '" + date + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Succesfully Updated!');", true);
            GetProducts();
        }

        protected void Button1_Click3(object sender, EventArgs e)
        {
            string name = TextBox7.Text;
            con.Open();
            SqlCommand com = new SqlCommand("exec Delete_Product '" + name + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Succesfully Deleted!');", true);
            GetProducts();
        }
    }
}