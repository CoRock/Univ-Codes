package _2019;

/**
 * 문제 2. 다음 프로그램의 출력을 쓰시오.
 */
class Stack {
	int s[];
	Stack list;

	Stack() {
		s = null;
		list = null;
	}

	void push(int x) {
		s = new int[2];
		s[0] = s[1] = x;
		if (list == null) {
			list = new Stack();
		} else {
			list.push(x);
		}
	}

	void pop(int x) {
		if (s[1] != 0) {
			s[0] = x;
			s[1] = 0;
		} else if (list != null) {
			list.pop(x);
		}
	}

	void print() {
		if (s != null)
			System.out.print(s[0] + " " + s[1] + " ");
		if (list != null) {
			list.print();
		}
	}
}

class Test2 {
	public static void main(String args[]) {
		int key[] = { 1, 2, 3, 4, 5 };
		Stack stack = new Stack();
		stack.push(key[0]);
		stack.push(key[2]);
		stack.push(key[4]);
		stack.pop(key[1]);
		stack.pop(key[3]);
		stack.print();
	}
}
