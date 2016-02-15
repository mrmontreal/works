<%@Page Language="Javascript"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <link rel="stylesheet" type="text/css"href="css/style.css">
</head>
<!--#include file="include/Database.aspx"--> 
<%
var sqlmsg="SELECT M.RefMessage, (select membername from members where refmember=M.Sender ) as Sender, (select membername from members where refmember=M.Receiver) as Receiver, M.Title, M.Content, M.SendDate, M.NewStatus FROM Messages M WHERE M.RefMessage="+Request.QueryString("RefMessage");
rs.Open(sqlmsg,con,3,3);
%>
<body>
    <form>
    <div>
    <table border="1">
      <tr><td>Title:</td><td><%=rs.Fields["Title"].Value%></td></tr>
      <tr><td>From:</td><td><%=rs.Fields["Sender"].Value%></td></tr>
      <tr><td>To:</td><td><%=rs.Fields["Receiver"].Value%></td></tr>
      <tr><td>Title:</td><td><%=rs.Fields["Title"].Value%></td></tr>
      <tr><td>SendDate:</td><td><%=rs.Fields["SendDate"].Value%></td></tr>
      <tr><td>Content:</td><td><%=rs.Fields["Content"].Value%></td></tr>
    </table>
<%rs.Close()%>  
 <p><a href="javascript:history.back()">Go Back</a></p> 
    </div>
    </form>
</body>
</html>
