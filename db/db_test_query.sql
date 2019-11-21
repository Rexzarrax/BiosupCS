Select * FROM motherboard_url mu
INNER JOIN motherboard_data md ON mu.model_id=md.model_id
INNER JOIN vendor_data vd ON md.vendor_id=vd.vendor_id;