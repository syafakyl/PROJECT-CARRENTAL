<%@ Page Title="" Language="C#" MasterPageFile="~/MasterUser.Master" AutoEventWireup="true" CodeBehind="HRV.aspx.cs" Inherits="PROJECT_ASP.NET.HRV" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
    <br>
    <br>
    <br>
    <div class="col-lg-16">
    <h2>Rental HRV</h2>
        <hr/>

        <ul class="nav nav-tabs" id="myTab" role="tablist">
          <li class="nav-item" role="presentation">
            <button class="nav-link active" id="display-tab" data-bs-toggle="tab" data-bs-target="#display" type="button" role="tab" aria-controls="profile" aria-selected="true">Display</button>
          </li>
        </ul>

        
            <br/>        
        <div class="tab-content" id="myTabContent">
        
            <div class="tab-pane fade show active" id="display" role="tabpanel" aria-labelledby="display-tab">
                <asp:Literal ID="lt_table" runat="server"></asp:Literal>
            </div>
            <asp:HyperLink ID="HyperLink1" runat="server" Class="btn btn-primary" NavigateUrl="User.aspx#card-sec">Kembali</asp:HyperLink>
        </div>
    </div>
    <br>
    <br>
    <br>
</asp:Content>
