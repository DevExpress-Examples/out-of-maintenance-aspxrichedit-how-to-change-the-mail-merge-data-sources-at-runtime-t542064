<!-- default file list -->
*Files to look at*:

* [MergeDataModels.cs](./CS/App_Code/MergeDataModels.cs) (VB: [MergeDataModels.vb](./VB/App_Code/MergeDataModels.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# ASPxRichEdit - How to change the Mail Merge data sources at runtime
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t542064/)**
<!-- run online end -->


<p>This example illustrates how to switch data sources used for Mail Merge in ASPxRichEdit at runtime.<br><br>To update ASPxRichEdit's data source dynamically, wrap it in the <a href="https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxCallbackPanel">ASPxCallbackPanel </a>control and use its callbacks to refresh data. <br>Note that ASPxRichEdit should be bound to actual data on every round-trip to the server, so it is insufficient to set the data source in the server-side Callback event handler only. It's necessary to restore the actual data source and bind ASPxRichEdit to it on each request in the Page_Init event handler.<br>In addition, it is necessary to clear the current document in ASPxRichEdit each time the data source is changed. For this purpose, you can use the server-side <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxRichEditASPxRichEdit_Newtopic">ASPxRichEdit.New</a> method.</p>

<br/>


