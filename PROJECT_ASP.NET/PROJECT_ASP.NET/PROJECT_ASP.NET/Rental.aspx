<%@ Page Title="" Language="C#" MasterPageFile="~/MasterUser.Master" AutoEventWireup="true" CodeBehind="Rental.aspx.cs" Inherits="PROJECT_ASP.NET.RentAvanza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
    <br>
    <br>
    <br>
    <div class="col-lg-16">
            <h2>Rent</h2>
            <hr/>

            <ul class="nav nav-tabs" id="myTab" role="tablist">
                <li class="nav-item" role="presentation">
                    <button class="nav-link active" id="display-tab" data-bs-toggle="tab" data-bs-target="#display" type="button" role="tab" aria-controls="profile" aria-selected="true">Display</button>
                </li>
            </ul>

            <br/>

        <form2>
            <div class="tab-content" id="myTabContent">
                <div class="tab-pane fade show active" id="display" role="tabpanel" aria-labelledby="display-tab">
                    <div class="mb-3">
                        <label for="TextBox1" class="form-label">Car ID</label>
                        <asp:TextBox ID="TextBox1" runat="server" Class="form-control" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="TextBox5" class="form-label">Customer ID</label>
                        <asp:TextBox ID="TextBox5" runat="server" Class="form-control" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="txtBorrow" class="form-label">Borrow Date</label>
                        <input type="date" runat="server" id="txtBorrow" name="txtBorrow" placeholder="YYYY-MM-DD" Class="form-control"/> 
                    </div>
                    <div class="mb-3">
                        <label for="txtReturn" class="form-label">Return Date</label>
                        <input type="date" runat="server" id="txtReturn" name="txtReturn" placeholder="YYYY-MM-DD" Class="form-control"/>
                    </div>
                    <div class="mb-3">
                        <label for="TextBox2" class="form-label">Cost</label>
                        <asp:TextBox ID="TextBox2" runat="server" Class="form-control" ReadOnly="True"></asp:TextBox>
                    </div>
                    <asp:Button ID="Button1" runat="server" Class="btn btn-primary" Text="Button" OnClick="Button1_Click" />
                    <asp:HyperLink ID="HyperLink1" runat="server" Class="btn btn-warning" NavigateUrl="User.aspx">Kembali</asp:HyperLink>
                </div>
            </div>
            </form2>
        </div>
    
    <br>
    <br>
    <br>
</asp:Content>
