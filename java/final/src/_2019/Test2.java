package _2019;

/**
 * 문제 2. 다음 프로그램의 출력을 쓰시오.
 */
class Test2 {
	static void fill(int x[][], int i, int j, int k, int dir) {

		if (x[i][j] > 0)
			return;

		x[i][j] = k;
		k++;
		if (dir == 0)
			j++;
		else if (dir == 1)
			i++;
		else if (dir == 2)
			j--;
		else if (dir == 3)
			i--;

		if (x[i][j] > 0) {
			dir = (dir + 1) % 4;
			if (dir == 0) {
				i++;
				j++;
			} else if (dir == 1) {
				j--;
				i++;
			} else if (dir == 2) {
				i--;
				j--;
			} else if (dir == 3) {
				j++;
				i--;
			}
		}

		fill(x, i, j, k, dir);
	}

	public static void main(String args[]) {
		int data[] = { 1, 2, 3, 4, 5 };
		int n = data.length + 2;
		int x[][] = new int[n][n];

		for (int i = 0; i < x.length; i++)
			for (int j = 0; j < x[0].length; j++)
				if (i == 0 || j == 0 || i == n - 1 || j == n - 1)
					x[i][j] = 1;
		fill(x, 1, 1, data[0], 0);
		for (int i = 1; i < x.length - 1; i++) {
			for (int j = 1; j < x[0].length - 1; j++)
				System.out.printf("%3d", x[i][j]);
			System.out.println();
		}
	}
}
