package com.s4s2h4.services.impl;

import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;
import java.util.UUID;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import com.s4s2h4.dao.BaseDao;
import com.s4s2h4.services.TestServices;
import com.s4s2h4.services.entity.Down;

@Service("TestServices")
public class TestServicesImpl implements TestServices {

	@SuppressWarnings("rawtypes")
	@Autowired
	private BaseDao baseDao;

	@SuppressWarnings("unchecked")
	public List<Down> qryKcsp() {
		return baseDao.qryInfo("from Down");
	}

	@SuppressWarnings("unchecked")
	public String del(String result) {
		try {
			Down down = (Down) baseDao.qryInfo("from Down where aguid=?",
					new Object[] { result }).get(0);
			baseDao.Delete(down);
			return "success";
		} catch (Exception e) {
			e.printStackTrace();
			return e.getMessage();
		}
	}

	@SuppressWarnings("unchecked")
	public void add(Down down) {
		Down d = new Down();
		d.setAguid(UUID.randomUUID().toString());
		d.setAname(new SimpleDateFormat("yyyy-MM-dd HH:mm:ss")
				.format(new Date()));
		baseDao.add(d);
	}

	@SuppressWarnings("unchecked")
	public void upd(Down down) {
		Down down2 = (Down) baseDao.qryInfo("from Down where aguid=?",
				new Object[] { down.getAguid() });
		down2.setAname(down.getAname());
		baseDao.upd(down2);
	}
}
