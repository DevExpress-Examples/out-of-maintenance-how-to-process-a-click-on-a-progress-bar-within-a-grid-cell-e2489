using System;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {
    protected void ASPxProgressBar1_DataBound(object sender, EventArgs e) {
        ASPxProgressBar progressBar = (ASPxProgressBar)sender;

        GridViewDataItemTemplateContainer templateContainer = (GridViewDataItemTemplateContainer)progressBar.NamingContainer;
        object rowKeyValue = templateContainer.KeyValue;

        if (progressBar.Value == null || rowKeyValue == null)
            progressBar.Visible = false;
        else {
            progressBar.Attributes.Add("onclick", string.Format("OnProgressBarClickEventHandler('{0}', '{1}');", progressBar.Value, rowKeyValue));
            progressBar.Style.Add("cursor", "pointer");
        }
    }
}