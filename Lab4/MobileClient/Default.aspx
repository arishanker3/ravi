<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insta Charity</title>
    
    <link rel="stylesheet" href="http://code.jquery.com/mobile/1.3.2/jquery.mobile-1.3.2.min.css" />
    <script src="http://code.jquery.com/jquery-1.9.1.min.js"></script>
    <script type="text/javascript">
        $(document).bind("mobileinit", function () {
            $.mobile.ajaxEnabled = false;
        });
   </script>
<script src="http://code.jquery.com/mobile/1.3.2/jquery.mobile-1.3.2.min.js"></script>
</head>
<body>
<div class ="page" data-role="page">
    <form id="form1" runat="server">
  <div data-role= "header">


             <h1> Calculator </h1>
</div>
     <div data-role ="content">
          
           
           <div data-role="fieldcontain">
                     <asp:Label ID="lblResult" runat="server" ForeColor="Red"></asp:Label>
                     
           </div>
 
             <div data-role="fieldcontain">
            <label for= "txtOperand1" > Operand1:</label>
            
            <asp:TextBox ID="txtOperand1" runat="server"></asp:TextBox>
            
                 
             </div>
            <div data-role ="fieldcontain">
                <label for="txtOperand2"> Operand2 :</label>
            

                <asp:TextBox ID="txtOperand2" runat="server"></asp:TextBox>   
                
                </div>   
                
            <div data-role ="fieldcontain">
                <label for="txtResult"> Result :</label>
            

                <asp:TextBox ID="txtResult" runat="server"></asp:TextBox>   
                
            </div> 
            <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click" />
            <asp:Button ID="btnSub" runat="server" Text="Sub" onclick="btnSub_Click" />
            <asp:Button ID="btnMultiply" runat="server" Text="Multiply" 
               onclick="btnMultiply_Click" style="height: 26px" />
            <asp:Button ID="btnDivide" runat="server" Text="Divide" 
               onclick="btnDivide_Click" />

                
          
       
                
    <div data-role ="footer">
            <h4> @ UMKC ASE </h4></div>
       </form>

    </div>
</body>
</html>

