package com.s4s2h4.dao.impl;

import java.util.List;

import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.s4s2h4.dao.BaseDao;

@Repository("BaseDao")
public class BaseDaoImpl<T> implements BaseDao<T> {

	// Spring 3.x �� Hibernate 4.x ���ṩ
	// HibernateDaoSupport��������dao��ʵ�ֲ�ע��SessionFactory
	private SessionFactory sessionFactory;

	@Autowired
	public void setSessionFactory(SessionFactory sessionFactory) {
		this.sessionFactory = sessionFactory;
	}

	public Session getCurrentSession() {
		return sessionFactory.getCurrentSession();// ��ɾ��ʹ�õ�session
	}

	public Session qryCurrentSesion() {
		return sessionFactory.openSession();// ��ѯʹ�õ�session
	}

	@SuppressWarnings("unchecked")
	public List<T> qryInfo(String hql) {
		return this.qryCurrentSesion().createQuery(hql).list();
	}

	@SuppressWarnings("unchecked")
	public List<T> qryInfo(String hql, Object[] param) {
		Query qry = this.qryCurrentSesion().createQuery(hql);
		setQueryParams(qry, param);
		return qry.list();
	}

	public void Delete(T cls) {
		// ���ѹ�ʵ����״̬���Ƶ���ʵ����������ʱ�쳣��illegally attempted to associate a proxy with
		// two open Sessions
		Object obj = this.getCurrentSession().merge(cls);
		this.getCurrentSession().delete(obj);
	}

	public void upd(T cls) {
		this.getCurrentSession().update(cls);
	}

	public void add(T cls) {
		this.getCurrentSession().saveOrUpdate(cls);
	}

	public void setQueryParams(Query qry, Object[] params) {
		if (params != null) {
			for (int i = 0; i < params.length; i++) {
				qry.setParameter(i, params[i]);
			}
		}
	}

}
