SELECT pr_id, pr_name FROM product
WHERE measure_ms_id=1
UNION
SELECT cat_id, cat_name FROM category
ORDER BY pr_name
LIMIT 10;