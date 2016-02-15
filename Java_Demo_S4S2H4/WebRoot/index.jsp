<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@taglib prefix="s" uri="/struts-tags"%>
<%String path=request.getContextPath();%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>

<title>My JSP 'index.jsp' starting page</title>
<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<script type="text/javascript" src="jquery.1.4.2-min.js"></script>
<script type="text/javascript" src="index.js" charset="gbk"></script>
</head>

<body>
	<a href="add">Add</a>
	<s:iterator value="downs">
		<li>
			<s:property value="aname" />
			<a href="javascript:delinfo('<s:property value="aguid" />')">Del</a>
		</li>
	</s:iterator>
</body>
</html>
