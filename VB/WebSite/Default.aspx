<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>ASPxGridView - How to sort values that contain text and numbers by their number
	</title>
</head>
<body>
	<form id="form1" runat="server">
	<dx:ASPxCheckBox ID="cb_CustomSort" runat="server" Text="Use custom sorting" Checked="true">
	</dx:ASPxCheckBox>
	<dx:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" OnCustomColumnSort="grid_CustomColumnSort"
		DataSourceID="ads" KeyFieldName="id" Width="200px">
		<SettingsPager Mode="ShowAllRecords">
		</SettingsPager>
		<Columns>
			<dx:GridViewDataTextColumn FieldName="id" VisibleIndex="0" ReadOnly="True">
				<EditFormSettings Visible="False" />
			</dx:GridViewDataTextColumn>
			<dx:GridViewDataTextColumn FieldName="value" VisibleIndex="1">
				<Settings AllowSort="True" SortMode="Custom" />
			</dx:GridViewDataTextColumn>
		</Columns>
	</dx:ASPxGridView>
	<asp:AccessDataSource ID="ads" runat="server" DataFile="~/App_Data/test.mdb" SelectCommand="SELECT * FROM [table]">
	</asp:AccessDataSource>
	</form>
</body>
</html>