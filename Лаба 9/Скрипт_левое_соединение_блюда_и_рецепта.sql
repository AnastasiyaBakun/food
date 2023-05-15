SELECT ml_id, recipe_rp_id, ml_name, rp_name, rp_cooking FROM meal LEFT JOIN recipe ON ml_id = rp_id
ORDER BY recipe_rp_id
LIMIT 15;