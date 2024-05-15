<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="PROJECT_ASP.NET.Customer1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="col-lg-16">
    <h2>Input Customer</h2>
    <hr/>

    <ul class="nav nav-tabs" id="myTab" role="tablist">
      <li class="nav-item" role="presentation">
        <button class="nav-link active" id="display-tab" data-bs-toggle="tab" data-bs-target="#display" type="button" role="tab" aria-controls="profile" aria-selected="true">Display</button>
      </li>

      <li class="nav-item" role="presentation">
        <button class="nav-link" id="input-tab" data-bs-toggle="tab" data-bs-target="#input" type="button" role="tab" aria-controls="profile" aria-selected="false">Input</button>
      </li>
    </ul>

        
        <br/>        
    <div class="tab-content" id="myTabContent">
        
        <div class="tab-pane fade show active" id="display" role="tabpanel" aria-labelledby="display-tab">
            <asp:Literal ID="lt_table" runat="server"></asp:Literal>
        </div>
      
        
        <div class="tab-pane fade" id="input" role="tabpanel" aria-labelledby="input-tab">
          <asp:Literal ID="response" runat="server"></asp:Literal>
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
        <asp:Button ID="Button1" runat="server" Text="Save" Class="btn btn-primary" OnClick="Button1_Click1"/>
      </div>   
    </div>
</div>
</asp:Content>
