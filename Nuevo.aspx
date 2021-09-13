<%@ Page Title="" Language="C#" MasterPageFile="~/Capas.Master" AutoEventWireup="true" CodeBehind="Nuevo.aspx.cs" Inherits="Capas.Nuevo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<link href="estilos/libros.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container contact">
	<div class="alert alert-danger" role="alert">
        <asp:Label runat="server" ID="mensaje_error" />
    </div>
	<div class="row">
		<div class="col-md-3">
			<div class="contact-info">
				<img src="https://image.ibb.co/kUASdV/contact-image.png" alt="image"/>
				<h2>Librería Digitallers</h2>
				<h4>We would love to hear from you !</h4>
			</div>
		</div>
		<div class="col-md-9">
			<div class="contact-form">
				<div class="form-group">
				  <label class="control-label col-sm-2" for="fname">Título:</label>
				  <div class="col-sm-10">          
					<asp:TextBox type="text" cssClass="form-control" ID="txt_titulo" placeholder="Enter First Name" name="fname" runat="server" />
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="lname">Autor</label>
				  <div class="col-sm-10">          
					<asp:DropDownList CssClass="form-control" ID="cmb_autores" runat="server" />
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="email">Editorial:</label>
				  <div class="col-sm-10">
					<asp:DropDownList CssClass="form-control" ID="cmb_editoriales" runat="server" />
				  </div>
				</div>
				<%--</div>--%>
				<div class="form-group">        
				  <div class="col-sm-offset-2 col-sm-10 mt-5">
					<button type="submit" class="btn btn-default">Submit</button>
				  </div>
				</div>
			</div>
		</div>
	</div>
</div>

</asp:Content>
