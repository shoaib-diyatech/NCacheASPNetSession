<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SampleForm.aspx.cs" Inherits="WebApplication.SampleForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 182px;
        }
    </style>
</head>
<body>
     <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSessionValue" runat="server" Text="Session Value: "></asp:Label>
            <br />
            <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSetSession" runat="server" Text="Set Session Value" OnClick="btnSetSession_Click" />

            <br />
            <br />
            <br />
            <br />

            <asp:Label ID="lblSubscriber" runat="server" Text=""></asp:Label>
        </div>
         <table class="auto-style1">
             <tr>
                 <td class="auto-style2">

            <asp:Button ID="btnGenSubscriber" runat="server" Text="Generate Subscriber" OnClick="btnGenSubscriber_Click" />

                 </td>
                 <td>

            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />

                 </td>
             </tr>
             <tr>
                 <td class="auto-style2">Name</td>
                 <td>
            <asp:TextBox ID="txtInputSubName" runat="server" Width="350px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style2">Email</td>
                 <td>
            <asp:TextBox ID="txtInputSubEmail" runat="server" Width="350px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style2">Msisdn</td>
                 <td>
            <asp:TextBox ID="txtInputSubMsisdn" runat="server" Width="350px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style2">Id</td>
                 <td>
            <asp:TextBox ID="txtInputSubId" runat="server" Width="350px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style2">

            <asp:Button ID="btnSaveSubscriber" runat="server" Text="Save Subscriber" OnClick="btnSaveSubscriber_Click" />

                 </td>
                 <td>

            <asp:Button ID="btnLoadSubscriber" runat="server" Text="Load Subscriber" OnClick="btnLoadSubscriber_Click" />

                 </td>
             </tr>
             <tr>
                 <td class="auto-style2">

            <asp:Button ID="btnClearSession" runat="server" Text="Clear Session" OnClick="btnClearSession_Click" />

                 </td>
                 <td>

                     &nbsp;</td>
             </tr>
         </table>
         <p>
             &nbsp;</p>
    </form>
</body>
</html>
