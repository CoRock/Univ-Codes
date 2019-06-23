package _2009;

/**
 * 2009 자바 프로그래밍 기말 고사
 * 문제 1. 다음 프로그램의 출력을 쓰시오.
 */
class Stack {
	int s[];
	int top;

	Stack() {
		top = -1;
		s = new int[1];
	}

	void push(int x) {
		if (top >= s.length - 1) {
			s = new int[s.length * 2];
		}
		top++;
		s[top] = x;
	}

	public String toString() {
		String v = "";
		for (int i = 0; i <= top; i++) {
			v = v + " " + s[i];
		}
		return v;
	}
}

public class Test1 {
	public static void main(String[] args) {
		int data[] = { 1, 2, 3, 4, 5 };
		Stack stack = new Stack();
		for (int i = 0; i < 5; i++) {
			stack.push(data[i]);
		}
		System.out.println(stack);
	}
}
