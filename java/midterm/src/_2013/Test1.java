package _2013;

/**
 * 2013 자바 프로그래밍 중간고사 문제
 * 1. 다음 프로그램의 출력을 쓰시오.
 */
public class Test1 {

	static String babo(String s) {
		int len = s.length();

		if (len == 1) {
			return s;
		}

		char a = s.charAt(0);
		char b = s.charAt(len - 1);

		String p;
		if (a > b) {
			p = s.substring(1, len - 1) + a;
		} else {
			p = s.substring(1);
		}
		return babo(p);
	}

	public static void main(String args[]) {
		int key[] = { 1, 2, 3, 4, 5 };
		String s;

		s = "";

		for (int i = 0; i < 5; i++) {
			s = s + key[i];
		}
		System.out.println(babo(s));
	}
	
}
