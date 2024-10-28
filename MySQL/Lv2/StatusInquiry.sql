SELECT  A.BOARD_ID
        , A.WRITER_ID
        , A.TITLE
        , A.PRICE
        , CASE 
            WHEN (A.STATUS = 'SALE') THEN '판매중'
            WHEN (A.STATUS = 'RESERVED') THEN '예약중'
            WHEN (A.STATUS = 'DONE') THEN '거래완료'
        END STATUS
    FROM USED_GOODS_BOARD A
        WHERE A.CREATED_DATE = '2022-10-05'
            ORDER BY A.BOARD_ID DESC
