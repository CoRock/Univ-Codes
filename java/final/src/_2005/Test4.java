package _2005;

/**
 * 문제 4. 다음 프로그램의 출력을 쓰시오.
 */
class Node {
	int val;
	Node left;
	Node right;

	Node(int x) {
		val = x;
		left = this;
		right = this;
	}

	void traverse() {
		System.out.println(val);
		if (left == null)
			return;
		if (right != null)
			right.traverse();
	}
}

public class Test4 {
	public static void main(String args[]) {
		int data[] = { 1, 2, 3, 4, 5 };
		Node t1 = new Node(data[0]);
		Node t2 = new Node(data[1]);
		Node t3 = new Node(data[2]);
		Node t4 = new Node(data[3]);
		Node t5 = new Node(data[4]);
		t1.right = t4;
		t3.right = t5;
		t4.right = t2;
		t5.right = t1;
		t2.right = null;
		t2.left = null;
		t4.left = null;
		t5.traverse();
	}
}
