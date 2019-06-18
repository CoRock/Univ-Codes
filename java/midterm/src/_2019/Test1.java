package _2019;

/** 
 * 2019 자바 프로그래밍 중간고사
 * 문제 1. 다음 프로그램의 출력을 쓰시오.
 */
public class Test1 {
	static void sort(int data[], int left, int right) {
		if (left < right) {
			int p = (left + right) / 2;
			int tmp = data[0];
			data[0] = data[p];
			data[p] = tmp;
			sort(data, left, p - 1);
			sort(data, p + 1, right);
		}
	}

	public static void main(String args[]) {
		int key[] = { 1, 2, 3, 4, 5 };

		sort(key, 0, 4);
		for (int i = 0; i < 5; i++) {
			System.out.print(key[i] + " ");
		}
		System.out.println();
	}
}
