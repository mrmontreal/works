<%@Page Language="Javascript"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<link rel="stylesheet" type="text/css"href="css/style.css">
<body>
<link rel="stylesheet" type="text/css"href="css/style.css">
    <form action="RegisterCheck.aspx" method="post">
    <div>
    <h1>MEMBER-REGISTER</h1>
    <table>
    <tr><td>Student Number:</td><td><input type="text" name="num"/></td></tr>
    <tr><td>Name:</td><td><input type="text" name="name"/></td></tr>
    <tr><td>Tel:</td><td><input type="text" name="tel"/></td></tr>
    <tr><td>Email:</td><td><input type="text" name="email"/></td></tr>
    <tr><td>Password:</td><td><input type="password" name="pwd"/></td></tr>
    <tr><td>Re-Password:</td><td><input type="password" name="repwd"/></td></tr>
    <tr><td><button type="submit" >Register</button></td><td><button type="reset" >Clear</button></td></tr>
      <tr><td colspan="2"><%=Session("regmsg")%></td></tr>
    </table>
    
    </div>
    </form>
</body>
</html>
