<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v16.2, Version=16.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRichEdit" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function onSelectedIndexChanged(s, e) {
            cp.PerformCallback();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         Choose the required Mail Merge data source:
            <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" ClientInstanceName="cb" ValueType="System.Int32" Width="210">
                <Items>
                    <dx:ListEditItem Value="1" Text="Data source for Mail Merge #1" />
                    <dx:ListEditItem Value="2" Text="Data source for Mail Merge #2" />
                </Items>
                <ClientSideEvents SelectedIndexChanged="onSelectedIndexChanged" />
            </dx:ASPxComboBox>
         <br />
         To check that the data source is applied, try to insert mail merge fields and view merged data
            <dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" runat="server" ClientInstanceName="cp" OnCallback="ASPxCallbackPanel1_Callback">
                <PanelCollection>
                    <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                        <dx:ASPxRichEdit ID="ASPxRichEdit1" runat="server" WorkDirectory="~\App_Data\WorkDirectory">
                         <Settings>
                          <Behavior CreateNew="Hidden" Save="Hidden" Open="Hidden" SaveAs="Hidden" />
                         </Settings>
                        </dx:ASPxRichEdit>
                    </dx:PanelContent>
                </PanelCollection>
            </dx:ASPxCallbackPanel>
        </div>
    </form>
</body>
</html>
