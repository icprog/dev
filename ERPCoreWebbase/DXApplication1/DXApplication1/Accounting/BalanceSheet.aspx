﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="BalanceSheet.aspx.cs" Inherits="WebModule.Accounting.BalanceSheet" %>
<%@ Register src="UserControl/ucBalanceSheet.ascx" tagname="ucBalanceSheet" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainHolder" runat="server">
    <dx:ASPxLabel ID="ASPxLabel1" runat="server" Font-Bold="True" 
        Font-Size="Medium" Text="Bảng Cân Đối Kế Toán" Height="50px">
    </dx:ASPxLabel>
    
    <uc1:ucBalanceSheet ID="ucBalanceSheet1" runat="server" />
</asp:Content>
