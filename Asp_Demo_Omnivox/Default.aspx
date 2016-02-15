<%@Page Language="Javascript"%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title></title>
    <link rel="stylesheet" type="text/css"href="css/style.css">
</head>

<body>

    <form action="MessageList.aspx" method="post">
    <div  class="center" align="center">
        <table>
            <tr><td colspan="2"><h1>Student Omnivoix</h1></td></tr>
            <tr><td>Email:</td><td><input type="text" name="email"/></td></tr>
            <tr><td>Password:</td><td><input type="password" name="pwd"/></td></tr>
            <tr><td><button type="submit">Enter</button></td><td><button type="reset">Clear</button></td></tr>
            <tr><td>Not a member?</td><td><button type="button" onClick="location.href='Register.aspx'" >Register</button></td></tr>
             <tr><td colspan="2"><%=Session("errmsg")%></td></tr>
        </table>
    
    </div>
    </form>
</body>
</html>
