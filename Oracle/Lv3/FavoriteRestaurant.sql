SELECT RI.FOOD_TYPE
     , RI.REST_ID
     , RI.REST_NAME
     , RI.FAVORITES
  FROM REST_INFO RI
 WHERE RI.FAVORITES = (
                       SELECT MAX(RI2.FAVORITES)
                         FROM REST_INFO RI2
                        WHERE RI.FOOD_TYPE = RI2.FOOD_TYPE
                        GROUP BY RI2.FOOD_TYPE
                      )
 ORDER BY RI.FOOD_TYPE DESC
