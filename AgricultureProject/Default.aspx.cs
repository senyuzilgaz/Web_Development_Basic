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
        }
    }
}
