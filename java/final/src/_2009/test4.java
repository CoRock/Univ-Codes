package _2009;

/**
 * 문제 4. 다음 프로그램의 출력을 쓰시오.
 */
class ListNode {
	int value;
	ListNode next;

	ListNode(int v, ListNode n) {
		value = v;
		next = n;
	}
}

class List {
	int n;
	ListNode head;

	List() {
		n = 0;
		head = new ListNode(0, null);
	}

	void append(int x) {
		for (int i = 0; i < x; i++) {
			head = new ListNode(x, head);
		}
		n = n + x;
	}

	public String toString() {
		String s = "";
		for (int i = 0; i < n; i++) {
			s = s + head.value;
			head = head.next;
		}
		return s;
	}
}

class Test4 {
	public static void main(String[] args) {
		int data[] = { 1, 2, 3, 4, 5 };
		List l = new List();

		for (int i = 0; i < 5; i++) {
			l.append(data[i]);
		}
		System.out.println(l);
	}
}
