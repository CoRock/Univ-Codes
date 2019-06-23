package _2009;

/**
 * 문제 3. 다음 프로그램의 출력을 쓰시오.
 */
class Bits {
	int x;

	Bits() {
		x = ~0;
	}

	void add(int i) {
		x = x & ~(1 << i);
	}

	public String toString() {
		String s = "";
		for (int i = 0; i < 10; i++) {
			if ((x & 1) == 1) {
				s = s + "1";
			} else {
				s = s + "0";
			}
			x = x >> 1;
		}
		return s;
	}
}

public class Test3 {
	public static void main(String[] args) {
		int data[] = { 1, 2, 3, 4, 5 };
		Bits b = new Bits();

		for (int i = 0; i < 5; i++) {
			b.add(data[i]);
		}
		System.out.println(b);
	}
}
