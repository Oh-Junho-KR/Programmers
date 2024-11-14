class Video {
    public String solution(String video_len, String pos, String op_start, String op_end, String[] commands) {
        String answer = "";
        long lVideoLen = 0;
        long lPos = 0;
        long lStart = 0;
        long lEnd = 0;

        lVideoLen = fnGetTime(video_len);
        lPos = fnGetTime(pos);
        lStart = fnGetTime(op_start);
        lEnd = fnGetTime(op_end);
        
        for (int i = 0; i < commands.length; i++){
            if (lPos >= lStart && lPos <= lEnd) {
                lPos = lEnd;
            }
            
            if (commands[i].equals("next")) {
                lPos += 10;
            } else {
                lPos -= 10;
            }
            
            if (lPos < 0){
                lPos = 0;
            }
            
            if (lPos > lVideoLen){
                lPos = lVideoLen;
            }
            
            if (lPos >= lStart && lPos <= lEnd) {
                lPos = lEnd;
            }
        }
        
        answer = fnGetTimeString(lPos);
        
        return answer;
    }
    
    private long fnGetTime(String sTime){
        long lResult = 0;
        String[] arrTime = sTime.split(":");
        lResult = Integer.parseInt(arrTime[0]) * 60 + Integer.parseInt(arrTime[1]);
        return lResult;
    }
    
    private String fnGetTimeString(long lTime){
        String sResult = "";
        String sMin = String.valueOf(lTime / 60);
        String sSec = String.valueOf(Integer.parseInt(String.valueOf(lTime)) % 60);
        sMin = sMin.length() == 1 ? "0" + sMin : sMin;
        sSec = sSec.length() == 1 ? "0" + sSec : sSec;
        sResult = sMin + ":" + sSec;
        return sResult;
    }
}
