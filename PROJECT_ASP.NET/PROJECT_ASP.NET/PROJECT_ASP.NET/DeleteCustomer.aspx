<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="DeleteCustomer.aspx.cs" Inherits="PROJECT_ASP.NET.DeleteCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="col-lg-12">
    <h2>Delete Car</h2>
    <hr/>

    <ul class="nav nav-tabs" id="myTab" role="tablist">
      <li class="nav-item" role="presentation">
        <button class="nav-link active" id="input-tab" data-bs-toggle="tab" data-bs-target="#input" type="button" role="tab" aria-controls="profile" aria-selected="false">Delete Confirmation</button>
      </li>
    </ul>

    
        <br/>        
            <div class="tab-content" id="myTabContent">
                <div class="tab-pane fade show active" id="input" role="tabpanel" aria-labelledby="input-tab">
                  <asp:Literal ID="response" runat="server"></asp:Literal>
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
                <br/>
                <asp:Button ID="Button1" runat="server" Text="Yes" Class="btn btn-danger" OnClick="Button1_Click"/>
                <asp:Button ID="Button2" runat="server" Text="No" Class="btn btn-primary" OnClick="Button2_Click"/>
              </div>   
            </div>
        </div>  
</asp:Content>
