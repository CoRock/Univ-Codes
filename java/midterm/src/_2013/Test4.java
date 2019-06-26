package _2013;

/**
 * 문제 4. 다음 프로그램의 출력을 쓰시오.
 */
class Array2D {

	int s[][];

	Array2D(int x[]) {
		s = new int[x.length][];

		for (int i = 0; i < x.length; i++) {
			s[i] = new int[10 - x[i]];
		}
	}

	void doIt() {
		for (int i = 0; i < s.length; i++) {
			for (int j = 0; j < s[i].length; j++) {
				s[i][j] = j + 1;
			}
			s[i][0] = s[i][0] - s[i][0];
		}
		int x = -1;
		int y = -1;
		for (int i = 0; i < s.length; i++) {
			if (s[i].length > x) {
				x = s[i].length;
				y = i;
			}
		}
		for (int i = 0; i < s.length; i++) {
			s[i] = s[y];
		}
	}

	void print() {
		for (int i = 0; i < s.length; i++) {
			for (int j = 0; j < s[i].length; j++) {
				System.out.print(s[i][j]);
			}
			System.out.println();
		}
	}

}

public class Test4 {

	public static void main(String args[]) {
		int key[] = { 1, 2, 3, 4, 5 };
		Array2D x = new Array2D(key);

		x.doIt();
		x.print();
	}

}
