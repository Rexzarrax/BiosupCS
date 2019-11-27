INSERT INTO motherboard_data (model_id, chipset, model_name, vendor_id, model_page)
VALUES (1,'Z390','PHANTOM-GAMING-4',1,'https://www.asrock.com/mb/Intel/Z390 Phantom Gaming 4/index.asp#BIOS');

INSERT INTO motherboard_url (url_id, model_id, url_str, url_bridge, url_date_collected)
VALUES (NEXT VALUE FOR seq_url_id,1,'http://asrock.pc.cdn.bitgravity.com/BIOS/1151/Z390%20Phantom%20Gaming%204(4.30)ROM.zip','N',(SELECT GETDATE()));


INSERT INTO motherboard_data (model_id, chipset, model_name, vendor_id, model_page)
VALUES (2,'Z390','GA-Z390-AORUS-MASTER',3,'https://www.gigabyte.com/Motherboard/Z390-AORUS-MASTER-rev-10#support-dl-bios');

INSERT INTO motherboard_url (url_id, model_id, url_str, url_bridge, url_date_collected)
VALUES (NEXT VALUE FOR seq_url_id,2,'https://download.gigabyte.com/FileList/BIOS/mb_bios_z390-aorus-master_f10.zip','N',(SELECT GETDATE()));

INSERT INTO motherboard_url (url_id, model_id, url_str, url_bridge, url_date_collected)
VALUES (NEXT VALUE FOR seq_url_id,2,'https://download.gigabyte.com/FileList/BIOS/mb_bios_z390-aorus-master_f9_n.zip','N',(SELECT GETDATE()));


INSERT INTO motherboard_data (model_id, chipset, model_name, vendor_id, model_page)
VALUES (3,'X399','PRIME-X399-A',2,'https://www.asus.com/us/Motherboards/PRIME-X399-A/HelpDesk_BIOS/');

INSERT INTO motherboard_url (url_id, model_id, url_str, url_bridge, url_date_collected)
VALUES (NEXT VALUE FOR seq_url_id,3,'https://dlcdnets.asus.com/pub/ASUS/mb/socketTR4/PRIME_X399-A/PRIME-X399-A-ASUS-1203.zip','N',(SELECT GETDATE()));


INSERT INTO motherboard_data (model_id, chipset, model_name, vendor_id, model_page)
VALUES (4,'CROSSHAIR','ROG-CROSSHAIR-VII-HERO-WIFI',2,'https://www.asus.com/us/Motherboards/ROG-CROSSHAIR-VII-HERO-WI-FI/HelpDesk_BIOS/');

INSERT INTO motherboard_url (url_id, model_id, url_str, url_bridge, url_date_collected)
VALUES (NEXT VALUE FOR seq_url_id,4,'https://dlcdnets.asus.com/pub/ASUS/mb/SocketAM4/ROG_CROSSHAIR-VII-HERO_WI-FI/ROG-CROSSHAIR-VII-HERO-WIFI-ASUS-2901.zip','N',(SELECT GETDATE()));


INSERT INTO motherboard_data (model_id, chipset, model_name, vendor_id, model_page)
VALUES (5,'B360','PRO4',1,'https://www.asrock.com/mb/Intel/B360%20Pro4/index.asp#BIOS');

INSERT INTO motherboard_url (url_id, model_id, url_str, url_bridge, url_date_collected)
VALUES (NEXT VALUE FOR seq_url_id,5,'http://asrock.pc.cdn.bitgravity.com/BIOS/1151/B360%20Pro4(4.20)ROM.zip','N',(SELECT GETDATE()));


INSERT INTO motherboard_data (model_id, chipset, model_name, vendor_id, model_page)
VALUES (6,'B365','M-AORUS-ELITE',3,'https://www.gigabyte.com/Motherboard/B365-M-AORUS-ELITE-rev-10/support#support-dl-bios');

INSERT INTO motherboard_url (url_id, model_id, url_str, url_bridge, url_date_collected)
VALUES (NEXT VALUE FOR seq_url_id,6,'https://download.gigabyte.com/FileList/BIOS/mb_bios_b365-m-aorus-elite_f2_n.zip','N',(SELECT GETDATE()));


INSERT INTO motherboard_data (model_id, chipset, model_name, vendor_id, model_page)
VALUES (7,'X470','GAMING-PLUS',4,'https://us.msi.com/Motherboard/support/X470-GAMING-PLUS/#down-bios');

INSERT INTO motherboard_url (url_id, model_id, url_str, url_bridge, url_date_collected)
VALUES (NEXT VALUE FOR seq_url_id,7,'http://download.msi.com/bos_exe/mb/7B79vAG2.zip','N',(SELECT GETDATE()));

insert into url_bridge (url_bridge_name)
values ('Y');

insert into url_bridge (url_bridge_name)
values ('N');

insert into url_bridge (url_bridge_name)
values ('U');

insert into chipset_vendor (chipset_vendor_name)
values ('AMD');

insert into chipset_vendor (chipset_vendor_name)
values ('INTEL');


