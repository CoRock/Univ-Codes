package _2005;

/**
 * 2005 자바 프로그래밍 기말 고사 문제
 * 1. 다음 프로그램의 출력을 쓰시오.
 */
class Stack {
	private int[] s;
	private int top;

	private void initialize() {
		s = new int[10];
		for (int i = 0; i < 10; i++)
			s[i] = 0;
	}

	Stack() {
		initialize();
		top = -1;
	}

	void push(int x) {
		top++;
		top++;
		s[top - 1] = x;
	}

	void pop() {
		top--;
	}

	void print() {
		for (int i = 0; i < 10; i++) {
			System.out.println("s[" + i + "] = " + s[i]);
		}
	}
}

public class Test1 {
	public static void main(String args[]) {
		int data[] = { 1, 2, 3, 4, 5 };
		Stack p = new Stack();
		p.push(data[0]);
		p.push(data[1]);
		p.push(data[2]);
		p.pop();
		p.pop();
		p.push(data[3]);
		p.push(data[4]);
		p.print();
	}
}
