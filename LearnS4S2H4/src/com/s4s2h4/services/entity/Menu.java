package com.s4s2h4.services.entity;

import java.util.HashSet;
import java.util.Set;

/**
 * Menu entity.
 */
public class Menu implements java.io.Serializable {

	// Fields

	private String aguid;
	private String pguid;
	private Integer lvl;
	private String aname;
	private Integer pxxh;
	private String createDate;
	private Boolean visible;
	private String modelsType;
	private Boolean isIndex;
	private Integer indexwz;
	private Set downs = new HashSet(0);

	// Constructors

	/** default constructor */
	public Menu() {
	}

	/** minimal constructor */
	public Menu(String aguid) {
		this.aguid = aguid;
	}

	/** full constructor */
	public Menu(String aguid, String pguid, Integer lvl, String aname,
			Integer pxxh, String createDate, Boolean visible,
			String modelsType, Boolean isIndex, Integer indexwz, Set downs) {
		this.aguid = aguid;
		this.pguid = pguid;
		this.lvl = lvl;
		this.aname = aname;
		this.pxxh = pxxh;
		this.createDate = createDate;
		this.visible = visible;
		this.modelsType = modelsType;
		this.isIndex = isIndex;
		this.indexwz = indexwz;
		this.downs = downs;
	}

	// Property accessors

	public String getAguid() {
		return this.aguid;
	}

	public void setAguid(String aguid) {
		this.aguid = aguid;
	}

	public String getPguid() {
		return this.pguid;
	}

	public void setPguid(String pguid) {
		this.pguid = pguid;
	}

	public Integer getLvl() {
		return this.lvl;
	}

	public void setLvl(Integer lvl) {
		this.lvl = lvl;
	}

	public String getAname() {
		return this.aname;
	}

	public void setAname(String aname) {
		this.aname = aname;
	}

	public Integer getPxxh() {
		return this.pxxh;
	}

	public void setPxxh(Integer pxxh) {
		this.pxxh = pxxh;
	}

	public String getCreateDate() {
		return this.createDate;
	}

	public void setCreateDate(String createDate) {
		this.createDate = createDate;
	}

	public Boolean getVisible() {
		return this.visible;
	}

	public void setVisible(Boolean visible) {
		this.visible = visible;
	}

	public String getModelsType() {
		return this.modelsType;
	}

	public void setModelsType(String modelsType) {
		this.modelsType = modelsType;
	}

	public Boolean getIsIndex() {
		return this.isIndex;
	}

	public void setIsIndex(Boolean isIndex) {
		this.isIndex = isIndex;
	}

	public Integer getIndexwz() {
		return this.indexwz;
	}

	public void setIndexwz(Integer indexwz) {
		this.indexwz = indexwz;
	}

	public Set getDowns() {
		return this.downs;
	}

	public void setDowns(Set downs) {
		this.downs = downs;
	}

}