<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="EditCustomer.aspx.cs" Inherits="PROJECT_ASP.NET.EditCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <div class="col-lg-16">
    <h2>Edit Customer</h2>
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
            <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="txtID" runat="server" Class="form-control" ReadOnly="True"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="NIK"></asp:Label>
            <asp:TextBox ID="txtNIK" runat="server" Class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label7" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" Class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label8" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" Class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label9" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" Class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label10" runat="server" Text="Phone"></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server" Class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" Class="form-control"></asp:TextBox>
        </div>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="Save" Class="btn btn-warning" OnClick="Button1_Click1"/>
            <asp:HyperLink ID="HyperLink1" runat="server" Class="btn btn-primary" NavigateUrl="~/Customer.aspx">Kembali</asp:HyperLink>
      </div>   
    </div>
</div>
</asp:Content>
