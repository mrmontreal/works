package com.s4s2h4.services.entity;

/**
 * Down entity.
 */

public class Down implements java.io.Serializable {
	// Fields

	private String aguid;
	private Menu menu;
	private Integer pxxh;
	private String aname;
	private String fileUrl;
	private String uploadDate;

	// Constructors

	/** default constructor */
	public Down() {
	}

	/** minimal constructor */
	public Down(String aguid) {
		this.aguid = aguid;
	}

	/** full constructor */
	public Down(String aguid, Menu menu, Integer pxxh, String aname,
			String fileUrl, String uploadDate) {
		this.aguid = aguid;
		this.menu = menu;
		this.pxxh = pxxh;
		this.aname = aname;
		this.fileUrl = fileUrl;
		this.uploadDate = uploadDate;
	}

	// Property accessors

	public String getAguid() {
		return this.aguid;
	}

	public void setAguid(String aguid) {
		this.aguid = aguid;
	}

	public Menu getMenu() {
		return this.menu;
	}

	public void setMenu(Menu menu) {
		this.menu = menu;
	}

	public Integer getPxxh() {
		return this.pxxh;
	}

	public void setPxxh(Integer pxxh) {
		this.pxxh = pxxh;
	}

	public String getAname() {
		return this.aname;
	}

	public void setAname(String aname) {
		this.aname = aname;
	}

	public String getFileUrl() {
		return this.fileUrl;
	}

	public void setFileUrl(String fileUrl) {
		this.fileUrl = fileUrl;
	}

	public String getUploadDate() {
		return this.uploadDate;
	}

	public void setUploadDate(String uploadDate) {
		this.uploadDate = uploadDate;
	}

}