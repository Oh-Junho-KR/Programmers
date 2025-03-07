public class BinaryConversion {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		BinaryConversion Bc = new BinaryConversion();
		int[] arrRst = Bc.solution(("110010101001"));
		System.out.println(arrRst[0] + "," + arrRst[1]);
	}

	public int[] solution(String s) {
        int[] answer = new int[] {0, 0};
        String sTmp = s; // 변경 전
        String sRst = null; // 변경 후

        // s == "1" 경우 return
        if (s.length() == 1) {
        	return answer;
        }
        
        // 반복
        while(true) {
        	// 변환 후 회차 추가 및 제거 길이 추가
        	sRst = getBinaryString(sTmp);
        	answer[0]++;
        	answer[1] += getRemoveZero(sTmp);
        	
        	if (sRst.length() == 1) {
        		break;
        	}
        	
        	sTmp = sRst;
        }
        
        return answer;
    }
	
	private int getRemoveZero(String s) {
		int nCnt = 0;
		for (int i = 0; i < s.length(); i++) {
        	if (s.charAt(i) == '0') {
        		nCnt++;
        	}
        }
		
		return nCnt;
	}
	
	private String getBinaryString(String s) {
		String sBinary = null;
		int nCnt = 0;
		for (int i = 0; i < s.length(); i++) {
        	if (s.charAt(i) == '0') {
        		nCnt++;
        	}
        }
		
		sBinary = Integer.toBinaryString(s.length() - nCnt);
		
		return sBinary;
	}
}
