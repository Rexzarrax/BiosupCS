CREATE
OR ALTER PROCEDURE ADD_CHIPSET (
  @a_chipset_name varchar(10),
  @a_chipset_vendor varchar(10)
) AS BEGIN
SET NOCOUNT ON
IF @a_chipset_name NOT IN (SELECT chipset_name FROM chipset_check)
INSERT INTO chipset_check(chipset_name, chipset_vendor)
VALUES(
    @a_chipset_name,
    @a_chipset_vendor
  )
END
GO
CREATE OR ALTER PROCEDURE SELECT_MOTHERBOARDS (
    @a_chipset varchar(10),
    @a_vendor varchar(255)
  ) AS BEGIN
SET NOCOUNT ON
Select
  vendor_name,
  chipset,
  model_name,
  url_str,
  url_bridge
FROM motherboard_url mu
INNER JOIN motherboard_data md ON mu.model_id = md.model_id
INNER JOIN vendor_data vd ON md.vendor_id = vd.vendor_id
WHERE
  md.chipset = @a_chipset
  AND vendor_name = @a_vendor
END
GO

CREATE OR ALTER PROCEDURE INSERT_MOTHERBOARD_MODEL (
    @a_vendor_name varchar(20),
    @a_chipset varchar(10),
    @a_model varchar(255),
    @a_motherboard_uefi_page_url varchar(255),
    @a_url_date_of_bios DATE,
    @a_motherboard_dl varchar(255),
    @a_motherboard_bridge varchar(1)
  ) AS BEGIN
DECLARE @motherboard_id INT
DECLARE @a_vendor int
SET @a_vendor = (SELECT vendor_id FROM vendor_data WHERE vendor_name = @a_vendor_name)
IF @a_model NOT IN (SELECT model_name FROM motherboard_data WHERE (chipset = @a_chipset AND vendor_id = @a_vendor AND model_name = @a_model))
 BEGIN 
 SET @motherboard_id = NEXT VALUE FOR seq_model_id
 INSERT INTO motherboard_data (model_id, chipset, model_name, vendor_id, model_page)
  VALUES(@motherboard_id, @a_chipset, @a_model, @a_vendor, @a_motherboard_uefi_page_url)
END
ELSE 
BEGIN 
    SET @motherboard_id = (SELECT model_id FROM motherboard_data WHERE chipset = @a_chipset AND vendor_id = @a_vendor AND model_name = @a_model)
END
INSERT INTO motherboard_url (model_id, url_str, url_bridge, url_date_collected, url_date_of_bios)
    VALUES(@motherboard_id, @a_motherboard_dl, @a_motherboard_bridge,(SELECT CONVERT (date, SYSDATETIME())),@a_url_date_of_bios)
END
GO

CREATE OR ALTER PROCEDURE INSERT_VENDOR(
    @a_vendor_name varchar(30),
    @a_vendor_sort varchar(255),
    @a_vendor_dl_url_base varchar(255),
    @a_vendor_url_addon varchar(255)
)
AS
INSERT INTO vendor_data (vendor_name, vendor_sort, vendor_dl_url_base, vendor_url_addon)
VALUES (@a_vendor_name, @a_vendor_sort, @a_vendor_dl_url_base, @a_vendor_url_addon);
GO

INSERT_VENDOR N'ASROCK', N'^https:\\/\\/(www\\.)?asrock\\.com\\/mb\\/', N'^http://asrock.pc.cdn.bitgravity.com/BIOS/', N'#BIOS'
EXECUTE INSERT_VENDOR N'ASUS', N'^https:\\/\\/www\\.asus\\.com\\/(au\\/|us\\/)?Motherboards\\/', N'https://dlcdnets.asus.com/pub', N'/HelpDesk_BIOS/'
EXECUTE INSERT_VENDOR N'GIGABYTE', N'^https:\\/\\/www\\.gigabyte\\.com\\/(us\\/)?Motherboard\\/', N'^http://download.gigabyte.asia/FileList/BIOS', N'#support-dl-bios'
EXECUTE INSERT_VENDOR N'MSI', N'^https:\\/\\/(www|us)?\\.msi\\.com\\/Motherboard\\/support\\/', N'^http://download.msi.com/bos', N'#down-bios'
EXECUTE INSERT_VENDOR N'EVGA', N'^https:\\/\\/www\\.evga\\.com\\/support\\/\\/', N'^cdn.evga.com/BIOS/', N'#'

ADD_CHIPSET N'X299',
  N'INTEL'
EXECUTE ADD_CHIPSET N'Z390',
  N'INTEL'
EXECUTE ADD_CHIPSET N'H370',
  N'INTEL'
EXECUTE ADD_CHIPSET N'B365',
  N'INTEL'
EXECUTE ADD_CHIPSET N'B360',
  N'INTEL'
EXECUTE ADD_CHIPSET N'H310',
  N'INTEL'
EXECUTE ADD_CHIPSET N'Z370',
  N'INTEL'
EXECUTE ADD_CHIPSET N'Z270',
  N'INTEL'
EXECUTE ADD_CHIPSET N'RAMPAGE',
  N'INTEL'
EXECUTE ADD_CHIPSET N'MAXIMUS',
  N'INTEL'
EXECUTE ADD_CHIPSET N'X99',
  N'INTEL'
EXECUTE ADD_CHIPSET N'X399',
  N'AMD'
EXECUTE ADD_CHIPSET N'A320',
  N'AMD'
EXECUTE ADD_CHIPSET N'B350',
  N'AMD'
EXECUTE ADD_CHIPSET N'B450',
  N'AMD'
EXECUTE ADD_CHIPSET N'X370',
  N'AMD'
EXECUTE ADD_CHIPSET N'X470',
  N'AMD'
EXECUTE ADD_CHIPSET N'B550',
  N'AMD'
EXECUTE ADD_CHIPSET N'CROSSHAIR',
  N'AMD'
EXECUTE ADD_CHIPSET N'ZENITH',
  N'AMD'
EXECUTE ADD_CHIPSET N'TRX40',
  N'AMD'
GO

  --SELECT_MOTHERBOARDS N'Z390',N'GIGABYTE';
  --GO
SELECT MAX(mu.url_date_of_bios) AS "Latest",mu.model_id FROM motherboard_url mu Group By mu.model_id;


  Select * FROM motherboard_url mu INNER JOIN motherboard_data md ON mu.model_id = md.model_id INNER JOIN vendor_data vd ON md.vendor_id = vd.vendor_id WHERE mu.url_bridge = 'Y';

  Select * FROM motherboard_url mu INNER JOIN motherboard_data md ON mu.model_id = md.model_id INNER JOIN vendor_data vd ON md.vendor_id = vd.vendor_id WHERE ((mu.url_bridge = 'Y') AND (vd.vendor_name in ('ASROCK','ASUS','GIGABYTE','MSI',)) AND (md.chipset in ('X399','A320','B350','B450','X370','X470','B550','CROSSHAIR','ZENITH','TRX40','X299','Z390','H370','B365','B360','H310','Z370','Z270','RAMPAGE','MAXIMUS','X99',)));

  SELECT MAX(mu.url_date_of_bios) AS 'Latest'FROM motherboard_url mu Group By mu.model_id

  SELECT vendor_id FROM dbo.vendor_data where vendor_name ='GIGABYTE';