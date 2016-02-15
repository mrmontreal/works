package com.s4s2h4.action;

import java.util.ArrayList;
import java.util.List;

import javax.servlet.http.HttpServletRequest;

import org.apache.struts2.interceptor.ServletRequestAware;
import org.springframework.beans.factory.annotation.Autowired;

import com.opensymphony.xwork2.ActionSupport;
import com.s4s2h4.services.TestServices;
import com.s4s2h4.services.entity.Down;

public class TestAction extends ActionSupport implements ServletRequestAware {
	@Autowired
	TestServices testServices;
	List<Down> downs = new ArrayList<Down>();
	private HttpServletRequest request;

	String result = "";

	public String qry() {
		downs = testServices.qryKcsp();
		return SUCCESS;
	}

	public String add() {
		downs = testServices.qryKcsp();
		testServices.add(null);
		return SUCCESS;
	}

	public String del() {
		result = testServices.del(result);// "{'id':1}";
		return SUCCESS;
	}

	public List<Down> getDowns() {
		return downs;
	}

	public void setDowns(List<Down> downs) {
		this.downs = downs;
	}

	public String getResult() {
		return result;
	}

	public void setResult(String result) {
		this.result = result;
	}

	public void setServletRequest(HttpServletRequest request) {
		this.request = request;
	}

	public HttpServletRequest getRequest() {
		return request;
	}

	public void setRequest(HttpServletRequest request) {
		this.request = request;
	}
	

}
