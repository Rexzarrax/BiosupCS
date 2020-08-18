DROP TABLE motherboard_url;
DROP TABLE motherboard_data;
DROP TABLE vendor_data;
DROP TABLE chipset_check;
DROP TABLE chipset_vendor;
DROP TABLE url_bridge;


CREATE TABLE firmware_data.vendor_data (
	vendor_id INT auto_increment NOT NULL,
	vendor_name varchar(30) NOT NULL,
	vendor_sort varchar(255) NULL,
	vendor_dl_url_base varchar(255) NULL,
	vendor_url_addon varchar(20) NULL,
	CONSTRAINT vendor_data_UN UNIQUE KEY (vendor_name),
	CONSTRAINT vendor_data_PK PRIMARY KEY (vendor_id)
)
ENGINE=InnoDB
DEFAULT CHARSET=utf8mb4
COLLATE=utf8mb4_general_ci;

CREATE TABLE firmware_data.motherboard_data (
	model_id INT auto_increment NOT NULL,
	chipset_id INT NOT NULL,
	model_name varchar(255) NOT NULL,
	vendor_id INT NOT NULL,
	model_page varchar(255) NULL,
	CONSTRAINT motherboard_data_PK PRIMARY KEY (model_id),
	CONSTRAINT motherboard_data_FK FOREIGN KEY (vendor_id) REFERENCES firmware_data.vendor_data(vendor_id) ON DELETE RESTRICT
)
ENGINE=InnoDB
DEFAULT CHARSET=utf8mb4
COLLATE=utf8mb4_general_ci;
ALTER TABLE firmware_data.motherboard_data DROP FOREIGN KEY motherboard_data_FK;


CREATE TABLE firmware_data.chipset_vendor (
	chipset_vendor_id INT auto_increment NOT NULL,
	chipset_vendor_name varchar(5) NOT NULL,
	CONSTRAINT chipset_vendor_PK PRIMARY KEY (chipset_vendor_id)
)
ENGINE=InnoDB
DEFAULT CHARSET=utf8mb4
COLLATE=utf8mb4_general_ci;

CREATE TABLE firmware_data.motherboard_url (
	url_id INT auto_increment NOT NULL,
	model_id INT NOT NULL,
	url_str BOOL NOT NULL,
	url_version varchar(10) NOT NULL,
	url_date_collected DATE NOT NULL,
	url_date_of_bios DATE NOT NULL,
	CONSTRAINT motherboard_url_PK PRIMARY KEY (url_id),
	CONSTRAINT motherboard_url_FK FOREIGN KEY (model_id) REFERENCES firmware_data.motherboard_data(model_id)
)
ENGINE=InnoDB
DEFAULT CHARSET=utf8mb4
COLLATE=utf8mb4_general_ci;

CREATE TABLE firmware_data.chipset_check (
	chipset_id INT auto_increment NOT NULL,
	chipset_name varchar(10) NOT NULL,
	chipset_vendor_id INT NULL,
	CONSTRAINT chipset_check_PK PRIMARY KEY (chipset_id)
)
ENGINE=InnoDB
DEFAULT CHARSET=utf8mb4
COLLATE=utf8mb4_general_ci;















































--DROP SEQUENCE seq_model_id;
--DROP SEQUENCE seq_vendor_id;
--DROP SEQUENCE seq_url_id;
--DROP SEQUENCE seq_chipset_id;
--DROP SEQUENCE seq_url_bridge_id;
--DROP SEQUENCE seq_chipset_vendor_id

/*CREATE TABLE vendor_data (
    vendor_id int NOT NULL IDENTITY(1,1),
    vendor_name varchar(30) UNIQUE,
    vendor_sort varchar(255),
    vendor_dl_url_base varchar(255),
    vendor_url_addon varchar(20)
    Primary Key (vendor_id)
);
go
CREATE TABLE motherboard_data (
    model_id INT NOT NULL IDENTITY(1,1),
    chipset varchar(20),
    model_name varchar(255) UNIQUE,
    vendor_id int,
    model_page varchar(255) DEFAULT NULL, --THis is for the bios downlaod page, not product page per say
    Primary Key (model_id),
	FOREIGN KEY (vendor_id) REFERENCES vendor_data(vendor_id)
);
go
CREATE TABLE chipset_vendor (
    chipset_vendor_id int not null IDENTITY(1,1),
    chipset_vendor_name varchar(5) UNIQUE,
    Primary Key (chipset_vendor_id)
);
go
CREATE TABLE url_bridge (
    url_bridge_id int not null IDENTITY(1,1),
    url_bridge_name varchar(1) UNIQUE,
    Primary Key (url_bridge_id)
);
go
--CREATE SEQUENCE seq_url_bridge_id NO MAXVALUE INCREMENT BY 1 START WITH 1;
--CREATE SEQUENCE seq_chipset_vendor_id NO MAXVALUE INCREMENT BY 1 START WITH 1;


go
CREATE TABLE motherboard_url (
    url_id int IDENTITY(1,1),
    model_id int,
    url_str varchar(255) UNIQUE,
	url_bridge varchar(1) CHECK (url_bridge in ('Y','N','U')),
    url_version varchar(10),
    url_date_collected DATE,
    url_date_of_bios DATE,
    PRIMARY KEY (url_id),
    FOREIGN KEY (model_id) REFERENCES motherboard_data(model_id)
);
go
CREATE TABLE chipset_check(
	chipset_id int IDENTITY(1,1),
	chipset_name varchar(10) NOT NULL UNIQUE,
	chipset_vendor varchar(10) CHECK(chipset_vendor in ('AMD','INTEL')),
	PRIMARY KEY (chipset_id)
);
go
/*CREATE SEQUENCE seq_model_id NO MAXVALUE INCREMENT BY 1 START WITH 1;
CREATE SEQUENCE seq_chipset_id NO MAXVALUE INCREMENT BY 1 START WITH 1;
CREATE SEQUENCE seq_url_id NO MAXVALUE INCREMENT BY 1 START WITH 1;
CREATE SEQUENCE seq_vendor_id no MAXVALUE INCREMENT BY 1 START WITH 1;
go
*/