package _2007;

/**
 * 문제 3. 다음 프로그램의 출력을 쓰시오.
 */
class Queue {
	protected int[] s;
	protected int end;

	Queue() {
		s = new int[10];
		end = -1;
	}

	void enter(int x) {
		end++;
		s[end] = x;
	}

	int leave() {
		end--;
		return s[end + 1];
	}

	void pr() {
		System.out.println("hello");
	}
}

class Stack extends Queue {
	private int front;

	Stack() {
		super();
		front = 0;
	}

	void enter(int x) {
		super.enter(x);
		front++;
		s[front] = x;
	}

	int leave() {
		end++;
		s[end] = s[end] - 1;
		return super.leave();
	}

	void pr() {
		System.out.println(s[end] + " " + s[front]);
	}
}

public class Test3 {
	public static void main(String args[]) {
		int key[] = { 1, 2, 3, 4, 5 };

		Queue a = new Stack();
		for (int i = 0; i < 5; i++)
			a.enter(key[i]);
		for (int i = 0; i < 5; i++)
			a.leave();
		a.pr();
	}
}
