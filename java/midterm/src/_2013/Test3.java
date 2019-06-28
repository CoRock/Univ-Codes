package _2013;

/**
 * 문제 3. 다음 프로그램의 출력을 쓰시오.
 */
class Queue {

	static int head;
	static int tail;
	static int s[];

	Queue() {
		head = 0;
		tail = -1;
		s = new int[10];
	}

	void add(int x) {
		tail++;
		s[tail] = x;
		tail++;
	}

	void remove() {
		head = head + 2;
	}

	public String toString() {
		String x = "";
		for (int i = head; i <= tail; i++) {
			x = x + s[i];
		}
		return x;
	}

}

public class Test3 {

	public static void main(String args[]) {
		int key[] = { 1, 2, 3, 4, 5 };
		Queue q1 = new Queue();
		Queue q2 = new Queue();

		q1.add(key[0]);
		q1.add(key[1]);
		q1.remove();
		q2.add(key[2]);
		q2.add(key[3]);
		q2.add(key[4]);
		q2.remove();
		System.out.println(q1);
		System.out.println(q2);
	}

}
