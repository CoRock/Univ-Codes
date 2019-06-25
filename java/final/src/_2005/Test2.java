package _2005;

/**
 * 문제 2. 다음 프로그램의 출력을 쓰시오.
 */
class List {
	static class Node {
		public Node next;
		public int data;

		public Node(int data) {
			this.next = this;
			this.data = data;
		}
	}

	Node head;

	public List() {
		head = null;
	}

	public void add(int data) {
		Node tmp = new Node(data);
		if (head == null) {
			head = tmp.next;
		} else {
			head.next = tmp;
		}
	}

	public void print(int n) {
		Node tmp = head;
		for (int i = 0; i < n; i++) {
			System.out.println(tmp.data);
			tmp = tmp.next;
		}
	}
}

public class Test2 {
	public static void main(String args[]) {
		int data[] = { 1, 2, 3, 4, 5 };
		List x = new List();
		x.add(data[0]);
		x.add(data[1]);
		x.add(data[2]);
		x.add(data[3]);
		x.add(data[4]);
		x.print(data.length);
	}
}
