<%@Page Language="Javascript"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <link rel="stylesheet" type="text/css"href="css/style.css">
</head>
<!--#include file="include/Database.aspx"--> 
<%
var sqlmsg="DELETE  FROM Messages WHERE RefMessage="+Request.QueryString("RefMessage");
rs.Open(sqlmsg,con,3,3);

Response.Redirect("MessageList.aspx");
rs.Close();
%>
<body>
</body>
</html>
