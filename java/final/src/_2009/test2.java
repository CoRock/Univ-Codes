package _2009;

/**
 * 문제 2. 다음 프로그램의 출력을 쓰시오.
 */
public class Test2 {
	public static void main(String[] args) {
		int data[] = { 1, 2, 3, 4, 5 };
		int x[][];

		x = new int[5][];
		for (int i = 0; i < 5; i++) {
			x[i] = new int[10 - data[i]];
		}
		for (int i = 0; i < x.length; i++) {
			for (int j = 0; j < x[i].length; j++) {
				x[i][j] = data[i];
			}
		}
		for (int i = 0; i < x.length; i++) {
			for (int j = 0; j < x[i].length; j++) {
				System.out.print(x[i][j] + " ");
			}
			System.out.println();
		}
	}
}
