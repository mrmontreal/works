<%@Page Language="Javascript"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<link rel="stylesheet" type="text/css"href="css/style.css">
<body>
<!--#include file="include/Database.aspx"--> 
<%
Response.Write(Request.Form("num"));
var sql="SELECT Number,StudentName,Phone FROM Students WHERE Number="+Request.Form("num")+"AND StudentName='"+Request.Form("name")+"'";
rs.Open(sql,con,3,3);
if	(rs.RecordCount==0)
{
    Response.Write("<script language='javascript'>alert('Student Number or Student Name is wrong!');</script>");
    Session("regmsg")="Student Number or Student Name is wrong!";
    Response.Redirect("Register.aspx");
    
}
else
{
    rs.Close();
    var sqlreg="INSERT INTO Members (Email,MemberName,[Password]) VALUES ('"+Request.Form("email")+"','"+Request.Form("name")+"','"+Request.Form("pwd")+"')";
    con.Execute(sqlreg);
    Session("errmsg")="Register successful!";
    Response.Redirect("Default.aspx");
}
  
%>
</body>
</html>
