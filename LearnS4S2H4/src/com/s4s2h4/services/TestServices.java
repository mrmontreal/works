package com.s4s2h4.services;

import java.util.List;

import com.s4s2h4.services.entity.Down;

public interface TestServices {

	List<Down> qryKcsp();

	String del(String result);

	void add(Down down);

	void upd(Down down);
}
