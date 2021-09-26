using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgricultureProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Description_TBTableAdapter dt = new DataSet1TableAdapters.Description_TBTableAdapter();
            Repeater1.DataSource = dt.GetData();
            Repeater1.DataBind();

            DataSet1TableAdapters.Products_TBTableAdapter products = new DataSet1TableAdapters.Products_TBTableAdapter();
            Repeater2.DataSource = products.GetProducts();
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Message_TBTableAdapter dt = new DataSet1TableAdapters.Message_TBTableAdapter();
            dt.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text);
        }
    }
}
