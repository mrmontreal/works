function delinfo(aguid){
	$.ajax({
		type:"post",
		url:"s4s2h4/del",
		data:"result="+aguid,
		success:function(msg){
			if(msg=="success"){
				window.location.href=window.location.href;
			}else{
				alert("ɾ��ʧ�ܣ�"+msg);
			}
		}
		,error:function(){
			alert("error");
		}
	});
}