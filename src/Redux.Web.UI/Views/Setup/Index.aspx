<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

        <% using (Html.BeginForm()) {%>
            <fieldset>
                <p>
                    <label for="">Create Schema</label>
                    <input type="submit" value="Create" name="create" />
                </p>
                <p>
                    <label for="">Drop Schema</label>
                    <input type="submit" value="Drop" name="drop" />
                </p>     
            </fieldset>
        <% } %>
</asp:Content>
