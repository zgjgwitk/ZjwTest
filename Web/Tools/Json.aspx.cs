using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.App_Code.Core;
using Web.App_Code.Entity;

namespace Web.Tools
{
    public partial class Json : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var model = new GenerateOrderRequest();
            model.GoodsList = new List<GenerateOrderRequest.Goods>();
            model.GoodsList.Add(new GenerateOrderRequest.Goods());
            model.InvoiceInfo = new GenerateOrderRequest.Invoice();
            model.LogisticsInfo = new GenerateOrderRequest.Logistics();
            lit1.Text = JsonHelper.SerializeObject(model);
        }
    }
}