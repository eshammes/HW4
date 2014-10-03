<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Evan's Salary Calculator</title>
    <link rel="stylesheet" type="text/css" href="./css/StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Evan&#39;s Salary Calculator<br />
        <br />
    
    </div>
        <asp:Label ID="lbl_hw" runat="server" Text="Hourly Wage:   "></asp:Label>
        <asp:TextBox ID="tb_hw" runat="server" Height="16px" style="margin-left: 45px" Width="112px"></asp:TextBox>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Number of Hours:   "></asp:Label>
            <asp:TextBox ID="tb_nh" runat="server" style="margin-left: 19px" Width="112px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lbl_ptd" runat="server" Text="Pre-tax Deductions:   "></asp:Label>
            <asp:TextBox ID="tb_ptd" runat="server" style="margin-left: 8px" Width="112px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lbl_atd" runat="server" Text="After-tax Deductions:   "></asp:Label>
            <asp:TextBox ID="tb_atd" runat="server" Width="112px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btn_calculate" runat="server" Text="Calculate" Width="150px" />
        </p>
        <p>
            <asp:Label ID="lbl_tr" runat="server" Text="Tax Rate:    "></asp:Label>
            <asp:TextBox ID="tb_rate" runat="server" Enabled="False" style="margin-left: 72px" Width="112px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lbl_np" runat="server" Text="Net Pay:      "></asp:Label>
            <asp:TextBox ID="tb_np" runat="server" Enabled="False" style="margin-left: 78px" Width="112px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btn_clear" runat="server" style="margin-left: 0px" Text="Clear" Width="150px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
