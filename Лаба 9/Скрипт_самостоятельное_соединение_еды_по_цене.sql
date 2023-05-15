SELECT FIRST.fd_id, FIRST.fd_cost FROM food FIRST, food SECOND 
WHERE FIRST.fd_cost>SECOND.fd_cost AND SECOND.fd_id=1 
ORDER BY fd_cost;