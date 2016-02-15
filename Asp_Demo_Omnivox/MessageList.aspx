<%@Page Language="Javascript"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <link rel="stylesheet" type="text/css"href="css/style.css">
</head>
<!--#include file="include/Database.aspx"--> 
<%
if(Session("login"))
{
var sql="SELECT Members.RefMember, Members.MemberName,Members.Email FROM Members WHERE Members.RefMember="+Session("refmember");
}
else
{
var sql="SELECT Members.RefMember, Members.MemberName,Members.Email FROM Members WHERE Members.Email='"+Request.Form("email")+"' AND Members.[Password]='"+Request.Form("pwd")+"'";
}
rs.Open(sql,con,3,3);

if	(rs.RecordCount==0)
{
    Response.Write("<script language='javascript'>alert('Email or Password is wrong!');</script>");
    Session("errmsg")="Email or Password is wrong!";
    Response.Redirect("Default.aspx");
    
}
else
{
    Session("email")=rs.Fields["email"].Value;
    Session("refmember")=rs.Fields["refmember"].Value;
	Session("membername")=rs.Fields["membername"].Value;
	Session("login")="true";
    rs.Close();
    var sqlmsg="SELECT M.RefMessage, (select membername from members where refmember=M.Sender ) as Sender, M.Title, M.Content, M.SendDate, M.NewStatus FROM Messages M WHERE M.Receiver="+Session("refmember") ;
    rs.Open(sqlmsg,con,3,3);
}    
%>
<body>
    <form >
    <div>
    <h1>Welcome <%=Session("membername")%></h1>
    <table border="1">
    <tr><td>Title</td><td>From</td><td>To</td><td>Actions</td></tr>
    <%while(!rs.EOF){%>
    <tr><td><%=rs.Fields["Title"].Value%></td><td><%=rs.Fields["Sender"].Value%></td><td><%=Session("membername")%></td><td><a href='MessageDetail.aspx?RefMessage=<%=rs.Fields["RefMessage"].Value%>'>Read</a>&nbsp;&nbsp; <a href='MessageDelete.aspx?RefMessage=<%=rs.Fields["RefMessage"].Value%>' onClick="return confirm('Are you sure you want to delete?')">Delete</a></td></tr>
    <%
      rs.MoveNext();
      }
      rs.Close();
      con.Close();
    %>
    </table>
    <p><a href="javascript:history.back()">Go Back</a></p>
    </div>
    </form>
</body>
</html>
