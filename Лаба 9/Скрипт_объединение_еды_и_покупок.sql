SELECT fd_id, shop_list_lst_id FROM food
WHERE fd_amount>50
UNION ALL
SELECT lst_id, product_pr_id FROM shop_list
WHERE lst_bought=true
ORDER BY fd_id
LIMIT 10;