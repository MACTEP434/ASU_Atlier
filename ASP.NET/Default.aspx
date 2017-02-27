<%@ Page AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ICSSoft.STORMNET.Web.Default" Language="C#" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Localize Text="<%$ Resources: Resource, Home_Page %>" runat="server"></asp:Localize><br />
    </div>
    <div>Средняя продолжительность работы одного мастера над заказом клиента</div>
    <asp:GridView ID="AVG" runat="server"></asp:GridView>
    
    <div>Топ 10 клиентов за последний месяц</div>
    <asp:GridView ID="Top10m" runat="server"></asp:GridView>

    <div>Топ 10 клиентов за последний год</div>
    <asp:GridView ID="Top10y" runat="server"></asp:GridView>

    <div>Цех, который принёс больше прибыли за последний месяц. </div>
    <asp:GridView ID="TopCex" runat="server"></asp:GridView>
</asp:Content>