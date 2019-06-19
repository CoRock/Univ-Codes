package _2019;

/**
 * 문제 3. 다음 프로그램의 출력을 쓰시오.
 */
class Tree {
	TreeNode root;

	Tree(int x[]) {
		root = new TreeNode(x[0]);
		root.add(1, new TreeNode(x[1]));
		root.add(2, new TreeNode(x[2]));
		root.add(3, new TreeNode(x[3]));
		root.add(4, new TreeNode(x[4]));
	}

	void traverse() {
		root.traverse();
	}
}

class TreeNode {
	int val;
	TreeNode child[];

	TreeNode(int n) {
		val = n;
		child = new TreeNode[3];
	}

	void add(int i, TreeNode node) {
		if (i == 1) {
			child[0] = node;
		} else if (i == 2) {
			child[0].child[1] = node;
		} else if (i == 3) {
			child[0].child[2] = node;
		} else if (i == 4) {
			child[1] = node;
		}
	}

	void traverse() {
		System.out.println(val);
		if (child[0] == null)
			return;
		child[0].traverse();
		if (child[1] == null)
			return;
		child[1].traverse();
		if (child[2] == null)
			return;
		child[2].traverse();
	}
}

class Test3 {
	public static void main(String args[]) {
		int data[] = { 1, 2, 3, 4, 5 };
		Tree tree = new Tree(data);
		tree.traverse();
	}
}
