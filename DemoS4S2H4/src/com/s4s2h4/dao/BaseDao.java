package com.s4s2h4.dao;

import java.util.List;

public interface BaseDao<T> {
	List<T> qryInfo(String hql);

	List<T> qryInfo(String hql, Object[] param);

	void Delete(T cls);

	void upd(T cls);

	void add(T cls);
	
}
