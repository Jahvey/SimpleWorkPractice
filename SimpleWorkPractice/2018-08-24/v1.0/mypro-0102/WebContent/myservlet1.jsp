<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>servlet1 page</title>
<script type="text/javascript" src="js/jquery-1.3.2.min.js"></script>

<script type="text/javascript">

function checkUser() {
	
	var username=$("#username").val();
	console.log(username);
	var password=$("#password").val();
	console.log(password);
	
	
	$.ajax({
		type:"post",
		url:"/mypro-0102/myservlet",
		data:{"user":username,"pwd":password},
		success:function(data){
			console.log(data);
			$("#msg_user").html(data);
		}
		
		
	});
}

</script>
</head>
<body>


姓名:<input type="text" id="username" name="username"/>
<span id="msg_user"></span>
<br/>
密码:<input type="password" id="password" />
<br/>
<input type="button" value="check" onclick="checkUser()"/>


</body>
</html>