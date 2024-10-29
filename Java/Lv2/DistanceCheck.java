public class DistanceCheck {
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String[][] arrPlace = new String[][] {
			{"POOOP", "OXXOX", "OPXPX", "OOXOX", "POXXP"},
			{"POOPX", "OXPXP", "PXXXO", "OXXXO", "OOOPP"},
			{"PXOPX", "OXOXP", "OXPOX", "OXXOP", "PXPOX"},
			{"OOOXX", "XOOOX", "OOOXX", "OXOOX", "OOOOO"},
			{"PXPXP", "XPXPX", "PXPXP", "XPXPX", "PXPXP"}
		};
		
		DistanceCheck dc = new DistanceCheck();
		int[] arrRst = dc.solution(arrPlace);
		
		for (int i = 0; i < arrRst.length; i++) {
			System.out.println(arrRst[i]);
		}
	}

	public int[] solution(String[][] places) {
        int[] answer = new int[places.length]; // 대기실 개수만큼 생성
        
        for (int i = 0; i < places.length; i++) {
        	boolean bDistancing = true; // 거리두기 상태
        	answer[i] = 1; // 거리두기 1로 초기화
        	for (int j = 0; j < places[i].length; j++) {
        		for (int k = 0; k < places[i][j].length(); k++) {
        			if (places[i][j].charAt(k) == 'P') {
        				// 수평으로 체크
        				if (!getCheckHorizontal(places, i, j, k)) {
        					System.out.println("수평 " + i + ", " + j + ", " + k);
        					answer[i] = 0;
        					bDistancing = false;
        					break;
        				}
        				
        				// 수직으로 체크
        				if (!getCheckVertical(places, i, j, k)) {
        					System.out.println("수직 " + i + ", " + j + ", " + k);
        					answer[i] = 0;
        					bDistancing = false;
        					break;
        				}
        				
        				// 대각선으로 체크
        				if (!getCheckDiagonal(places, i, j, k)) {
        					System.out.println("대각 " + i + ", " + j + ", " + k);
        					answer[i] = 0;
        					bDistancing = false;
        					break;
        				}
        			}
        		}
        		
        		if (!bDistancing) {
        			break;
        		}
        	}
        }
        
        return answer;
    }
	
	private boolean getCheckHorizontal(String[][] places, int nRow, int nCol, int nIdx) {
		if (nIdx - 1 >= 0) {
			if (places[nRow][nCol].charAt(nIdx - 1) == 'P') {
				return false;
			}
		}
		
		if (nIdx + 1 < places[nRow][nCol].length()) {
			if (places[nRow][nCol].charAt(nIdx + 1) == 'P') {
				return false;
			}
		}
		
		if (nIdx - 2 >= 0) {
			if (places[nRow][nCol].charAt(nIdx - 2) == 'P') {
				if (places[nRow][nCol].charAt(nIdx - 1) != 'X') {
					return false;
				}
			}
		}
		
		if (nIdx + 2 < places[nRow][nCol].length()) {
			if (places[nRow][nCol].charAt(nIdx + 2) == 'P') {
				if (places[nRow][nCol].charAt(nIdx + 1) != 'X') {
					return false;
				}
			}
		}
		
		return true;
	}
	
	private boolean getCheckVertical(String[][] places, int nRow, int nCol, int nIdx) {
		if (nCol - 1 >= 0) {
			if (places[nRow][nCol - 1].charAt(nIdx) == 'P') {
				return false;
			}
		}
		
		if (nCol + 1 < places[nRow].length) {
			if (places[nRow][nCol + 1].charAt(nIdx) == 'P') {
				return false;
			}
		}
		
		if (nCol - 2 >= 0) {
			if (places[nRow][nCol - 2].charAt(nIdx) == 'P') {
				if (places[nRow][nCol - 1].charAt(nIdx) != 'X') {
					return false;
				}
			}
		}
		
		if (nCol + 2 < places[nRow].length) {
			if (places[nRow][nCol + 2].charAt(nIdx) == 'P') {
				if (places[nRow][nCol + 1].charAt(nIdx) != 'X') {
					return false;
				}
			}
		}
		
		return true;
	}
	
	private boolean getCheckDiagonal(String[][] places, int nRow, int nCol, int nIdx) {
		if (nIdx - 1 >= 0 && nCol - 1 >= 0) {
			if (places[nRow][nCol - 1].charAt(nIdx - 1) == 'P') {
				if (!(places[nRow][nCol].charAt(nIdx - 1) == 'X' && places[nRow][nCol - 1].charAt(nIdx) == 'X')) {
					return false;
				}
			}
		}
		
		if (nIdx - 1 >= 0 && nCol + 1 < places[nRow].length) {
			if (places[nRow][nCol + 1].charAt(nIdx - 1) == 'P') {
				if (!(places[nRow][nCol].charAt(nIdx - 1) == 'X' && places[nRow][nCol + 1].charAt(nIdx) == 'X')) {
					return false;
				}
			}
		}
		
		if (nIdx + 1 < places[nRow][nCol].length() && nCol - 1 >= 0) {
			if (places[nRow][nCol - 1].charAt(nIdx + 1) == 'P') {
				if (!(places[nRow][nCol].charAt(nIdx + 1) == 'X' && places[nRow][nCol - 1].charAt(nIdx) == 'X')) {
					return false;
				}
			}
		}
		
		if (nIdx + 1 < places[nRow][nCol].length() && nCol + 1 < places[nRow].length) {
			if (places[nRow][nCol + 1].charAt(nIdx + 1) == 'P') {
				if (!(places[nRow][nCol].charAt(nIdx + 1) == 'X' && places[nRow][nCol + 1].charAt(nIdx) == 'X')) {
					return false;
				}
			}
		}
		
		return true;
	}
}
