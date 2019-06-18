package _2019;

/**
 * 문제 4. 다음 프로그램의 출력을 쓰시오.
 */
public class Test4 {
	static String foo(String s) {
		int i, j;

		i = s.indexOf('*');
		j = s.lastIndexOf('*');
		return s.substring(i + 1, j);
	}

	public static void main(String args[]) {
		int key[] = { 1, 2, 3, 4, 5 };

		String ss = "";
		String s[] = new String[5];

		for (int i = 0; i < 5; i++) {
			s[i] = "";
			for (int j = 0; j < key[4 - i]; j++) {
				s[i] = s[i] + key[4 - i];
			}
			ss = ss + s[i] + "*";
		}
		ss = foo(ss);
		ss = foo(ss);
		int i = ss.indexOf('*');
		ss = ss.substring(i - 1, i + 2);
		int x = ss.charAt(0) - '0';
		int y = ss.charAt(2) - '0';
		ss = ss + " = " + (x * y - 1);
		System.out.println(ss);
	}
}
