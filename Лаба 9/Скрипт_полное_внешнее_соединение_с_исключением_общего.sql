SELECT * FROM food FULL JOIN shop_list ON shop_list_lst_id=lst_id 
WHERE shop_list_lst_id IS NULL OR lst_id IS NULL;