<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebApplication1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .form-column{
            width:70%  ;
        }
        .col-md-3{
            width:20%;
        }
    </style>
    <%--<form id="form1" runat="server">--%>
  <div class="form-column">
    <div class="col-md-4 mb-3">
      <label for="validationCustom01">First name</label>
        <asp:TextBox ID="FirstName"  class="form-control"  runat="server"></asp:TextBox>
     <%-- <input type="text" class="form-control" id="validationCustom01" value="" required>--%>
      <div class="valid-feedback">
        Looks good!
      </div>
    </div>
    <div class="col-md-4 mb-3">
      <label for="validationCustom02">Last name</label>
        <asp:TextBox ID="LastName"  class="form-control"  runat="server"></asp:TextBox>
      <%--<input type="text" class="form-control" id="validationCustom02" value="" required>--%>
      <div class="valid-feedback">
        Looks good!
      </div>
    </div>
    <div class="col-md-4 mb-3">
      <label for="validationCustomUsername">Username</label>
      <div class="input-group">
        <div class="input-group-prepend">
          <span class="input-group-text" id="inputGroupPrepend">@</span>
        </div>
          <asp:TextBox ID="UserName" class="form-control"  runat="server"></asp:TextBox>
        <%--<input type="text" class="form-control" id="validationCustomUsername" aria-describedby="inputGroupPrepend" required>--%>
        <div class="invalid-feedback">
          Please choose a username.
        </div>
      </div>
        </div>
      
      <div class="col-md-4 mb-3">
      <label for="validationCustomPassword">Password</label>
          <asp:TextBox ID="password" class="form-control"    runat="server"></asp:TextBox>
      <%--<input type="text" class="form-control" id="validationCustomPassword" value="" required>--%>
      <div class="valid-feedback">
        Looks good!
      </div>
    </div>
    <div class="col-md-3 mb-3">
      <label for="validationCustom04">State</label>
      <select class="custom-select" id="validationCustom04" required>
        <option selected disabled value="">Choose...</option>
        <option>Israel</option>
        <option>Italia</option>
        <option>USA</option>
        <option>Australia</option>
      </select>
      <div class="invalid-feedback">
        Please select a valid state.
      </div>
  </div>
  <div class="form-group">
    <div class="form-check">
      <input class="form-check-input" type="checkbox" value="" id="invalidCheck" required>

      <label class="form-check-label" for="invalidCheck">
        Agree to terms and conditions
      </label>
      <div class="invalid-feedback">
        You must agree before submitting.
      </div>
    </div>
  </div>
      <asp:Button ID="Button1" class="btn btn-danger" runat="server" Text="Submit" OnClick="Button1_Click" />
  <%--<button type="button" class="btn btn-danger">Submit </button>--%>
        
       
      
        
        
<%--    </form>--%>

<script>
// Example starter JavaScript for disabling form submissions if there are invalid fields
(function() {
  'use strict';
  window.addEventListener('load', function() {
    // Fetch all the forms we want to apply custom Bootstrap validation styles to
    var forms = document.getElementsByClassName('needs-validation');
    // Loop over them and prevent submission
    var validation = Array.prototype.filter.call(forms, function(form) {
      form.addEventListener('submit', function(event) {
        if (form.checkValidity() === false) {
          event.preventDefault();
          event.stopPropagation();
        }
        form.classList.add('was-validated');
      }, false);
    });
  }, false);
})();
</script>
</asp:Content>
