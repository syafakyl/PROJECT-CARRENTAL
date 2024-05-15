<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="Return.aspx.cs" Inherits="PROJECT_ASP.NET.Return" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div class="col-lg-12">
     <h2>History</h2>
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
     </div>
 </div>  
</asp:Content>
