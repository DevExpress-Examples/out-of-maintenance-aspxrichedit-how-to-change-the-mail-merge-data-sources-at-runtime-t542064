using DevExpress.Web;
using DevExpress.Web.Office;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Init(object sender, EventArgs e) {
        if (Session["dataMerge"] != null) {
            ASPxRichEdit1.DataSource = Session["dataMerge"];
            ASPxRichEdit1.DataBind();
        }
    }
    protected void ASPxCallbackPanel1_Callback(object sender, CallbackEventArgsBase e) {
        ASPxRichEdit1.New();
        if (Convert.ToInt32(ASPxComboBox1.Value) == 1)
            Session["dataMerge"] = MergeDataModels.GetTestData1();
        else
            Session["dataMerge"] = MergeDataModels.GetTestData2();
        ASPxRichEdit1.DataSource = Session["dataMerge"];
        ASPxRichEdit1.DataBind();
    }
 
}