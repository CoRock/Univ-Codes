package _2008;

/**
 * 2008 자바 프로그래밍 기말 고사
 * 문제 1. 다음 프로그램의 출력을 쓰시오.
 */
class Bit {
	int data;

	Bit() {
		data = 0;
	}

	void set(int i) {
		data = data | (1 << i);
	}

	void print() {
		for (int i = 0; i < 10; i++) {
			if ((data & (1 << i)) != 0) {
				System.out.print(1);
			} else {
				System.out.print(0);
			}
		}
		System.out.println();
	}
}

public class Test1 {
	public static void main(String args[]) {
		int key[] = { 1, 2, 3, 4, 5 };

		Bit x = new Bit();
		for (int i = 0; i < 5; i++) {
			x.set(key[i]);
		}
		x.print();
	}
}