<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="EditCar.aspx.cs" Inherits="PROJECT_ASP.NET.EditCar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="col-lg-12">
    <h2>Edit Car</h2>
    <hr/>

    <ul class="nav nav-tabs" id="myTab" role="tablist">
      <li class="nav-item" role="presentation">
        <button class="nav-link active" id="input-tab" data-bs-toggle="tab" data-bs-target="#input" type="button" role="tab" aria-controls="profile" aria-selected="false">Input</button>
      </li>
    </ul>

        
        <br/>        
    <div class="tab-content" id="myTabContent">
        <div class="tab-pane fade show active" id="input" role="tabpanel" aria-labelledby="input-tab">
          <asp:Literal ID="response" runat="server"></asp:Literal>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Car ID"></asp:Label>
            <asp:TextBox ID="txtID" runat="server" Class="form-control" ReadOnly="True"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="Car Name"></asp:Label>
            <asp:TextBox ID="txtCar" runat="server" Class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label7" runat="server" Text="Brand ID"></asp:Label>
            <asp:TextBox ID="txtBrand" runat="server" Class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label8" runat="server" Text="Plate Number"></asp:Label>
            <asp:TextBox ID="txtPlat" runat="server" Class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label9" runat="server" Text="Year Production"></asp:Label>
            <asp:TextBox ID="txtYear" runat="server" Class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label10" runat="server" Text="Cost"></asp:Label>
            <asp:TextBox ID="txtCost" runat="server" Class="form-control"></asp:TextBox>
        </div>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="Save" Class="btn btn-warning" OnClick="Button1_Click"/>
        <asp:HyperLink ID="HyperLink1" runat="server" Class="btn btn-primary" NavigateUrl="~/Car.aspx">Kembali</asp:HyperLink>
      </div>   
    </div>
</div>  

</asp:Content>
