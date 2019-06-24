package _2007;

/**
 * 2007 자바 프로그래밍 기말 고사 문제
 * 1. 다음 프로그램의 출력을 쓰시오.
 */
public class Test1 {
	static class Node {
		int num;
		Node next;

		Node(int x) {
			num = x;
			next = this;
		}
	}

	public static void main(String args[]) {
		int key[] = { 1, 2, 3, 4, 5 };
		Node h, p, q;
		int i;

		h = new Node(key[0]);
		p = h;
		for (i = 1; i < 5; i++) {
			q = new Node(key[i]);
			q.next = p.next;
			p = q;
		}
		p = h;
		for (i = 0; i < 5; i++) {
			System.out.print(p.num + " ");
			p = p.next;
		}
	}
}
