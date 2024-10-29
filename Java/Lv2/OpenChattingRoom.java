import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class OpenChattingRoom {
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		OpenChattingRoom ocr = new OpenChattingRoom();
		String[] arrRst = ocr.solution(new String[] {"Enter uid1234 Muzi", "Enter uid4567 Prodo","Leave uid1234","Enter uid1234 Prodo","Change uid4567 Ryan"});
		for (int i = 0; i < arrRst.length; i++) {
			System.out.println(arrRst[i]);
		}
	}

	public String[] solution(String[] record) {
        String[] answer = null; // 정답
        StringBuilder sbReturn = new StringBuilder(); // 정답 문자열
        
        List<String> lstTmp = new ArrayList<String>(); // ID Type
        HashMap<String, String> mapInfo = new HashMap<String, String>(); // ID, Name
        
        for (int i = 0; i < record.length; i++) {
            String[] arrRecord = record[i].split(" ");
            String sType = arrRecord[0];
            String sID = arrRecord[1];
            String sName = arrRecord.length > 2 ? arrRecord[2] : null;
            
            // Name이 없으면 Leave로 판단
            if (sName != null) {
                mapInfo.put(sID, sName); // ID에 Name 매칭
            }
            
            lstTmp.add(sID + " " + sType);
        }
        
        for (String tmp : lstTmp) {
            String[] arrAnswer = tmp.split(" ");
            String sID = arrAnswer[0];
            String sType = arrAnswer[1];
            
            // 입장과 퇴장만 결과에 저장
            if (sType.equals("Enter") || sType.equals("Leave")) {
                if (mapInfo.containsKey(sID)) {
                    if (sbReturn.length() > 0) {
                        sbReturn.append(",");
                    }
                    
                    sbReturn.append(mapInfo.get(sID) + (sType.equals("Enter") ? "님이 들어왔습니다." : "님이 나갔습니다."));
                }
            }
        }
        
        answer = sbReturn.toString().split(",");
        
        return answer;
    }
}
