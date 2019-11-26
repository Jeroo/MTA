<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" EnableViewState="false" Inherits="TextWebServiceClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 
                <h2>Formulario de prueba para TextWebService</h2>
            <p>
            <asp:TextBox ID="TextBox1"
                runat="server"
                Text="Introduzca texto" />
            <br />
            <asp:Button ID="Button1"
                runat="server"
                Text="Invocar Métodos de Servicio"
                onclick="Button1_Click" />
            </p>
            <p>
            <strong>Results : </strong><br />
                ToLower method:
                <asp:Label ID="toLowerLabe1"
                runat="server"
                Text="Label" ForeColor="Green" />
            <br />
             ToUpper method:
               <asp:Label ID="toUpperLabel"
                runat="server"
                Text="Label" ForeColor="Green" />
            </p>
   

</asp:Content>
