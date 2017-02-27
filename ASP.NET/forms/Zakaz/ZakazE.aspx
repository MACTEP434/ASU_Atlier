﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="ZakazE.aspx.cs" Inherits="IIS.АСУ_Ателье.ЗаказE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass %> <%= Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.EditFormHeaderCssClass %>">Заказ</h2>
        <div class="<%= Constants.FormToolbarCssClass %> <%= Constants.EditFormToolbarCssClass %> <%= Constants.StickyCssClass %>">
            <asp:ImageButton ID="SaveBtn" runat="server" SkinID="SaveBtn" OnClick="SaveBtn_Click" AlternateText="<%$ Resources: Resource, Save %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="SaveAndCloseBtn" runat="server" SkinID="SaveAndCloseBtn" OnClick="SaveAndCloseBtn_Click" AlternateText="<%$ Resources: Resource, Save_Close %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="CancelBtn" runat="server" SkinID="CancelBtn" OnClick="CancelBtn_Click" AlternateText="<%$ Resources: Resource, Cancel %>" />
        </div>
        <div class="<%= Constants.FormControlsCssClass %> <%= Constants.EditFormControlsCssClass %>">
            <%-- Autogenerated section start [Controls] --%>
<!-- autogenerated start -->
<div>
	<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlКодЗаказаLabel" runat="server" Text="Код заказа" EnableViewState="False">
</asp:Label>
<ac:AlphaNumericTextBox CssClass="descTxt" ID="ctrlКодЗаказа" Type="Numeric" runat="server">
</ac:AlphaNumericTextBox>

<asp:RequiredFieldValidator ID="ctrlКодЗаказаValidator" runat="server" ControlToValidate="ctrlКодЗаказа"
ErrorMessage="Не указано: КодЗаказа" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlСтатусЗаказаLabel" runat="server" Text="Статус заказа" EnableViewState="False">
</asp:Label>
<asp:DropDownList ID="ctrlСтатусЗаказа" CssClass="descTxt" runat="server">
	<asp:ListItem>ВРаботе</asp:ListItem>
<asp:ListItem>ОжидаетКлиента</asp:ListItem>
<asp:ListItem>Завершён</asp:ListItem>

</asp:DropDownList>
<asp:RequiredFieldValidator ID="ctrlСтатусЗаказаValidator" runat="server" ControlToValidate="ctrlСтатусЗаказа"
ErrorMessage="Не указано: СтатусЗаказа" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlДатаПоступленияLabel" runat="server" Text="Дата поступления" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlДатаПоступления" runat="server"/>
</div>
<asp:RequiredFieldValidator ID="ctrlДатаПоступленияValidator" runat="server" ControlToValidate="ctrlДатаПоступления"
ErrorMessage="Не указано: ДатаПоступления" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlДатаЗакрытияLabel" runat="server" Text="Дата закрытия" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlДатаЗакрытия" runat="server"/>
</div>
</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlКлиентLabel" runat="server" Text="Клиент" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlКлиент" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlМодельLabel" runat="server" Text="Модель" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlМодель" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlМастерLabel" runat="server" Text="Мастер" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlМастер" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlСуммаLabel" runat="server" Text="Сумма" EnableViewState="False">
</asp:Label>
<ac:DecimalTextBox CssClass="descTxt" ID="ctrlСумма" runat="server">
</ac:DecimalTextBox>

</div>
<br/>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>