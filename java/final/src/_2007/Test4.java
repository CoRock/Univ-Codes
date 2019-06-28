package _2007;

/**
 * 문제 4. 다음 프로그램의 출력을 쓰시오.
 */
public class Test4 {
	static class TNode {
		TNode lc;
		int data;
		TNode rc;

		TNode(TNode l, int x, TNode r) {
			lc = l;
			data = x;
			rc = r;
		}

		void traverse(int n) {
			if (n < 0)
				return;
			data++;
			if (rc != null)
				rc.traverse(n - 1);
		}
	}

	public static void main(String args[]) {
		int key[] = { 1, 2, 3, 4, 5 };

		TNode t1 = new TNode(null, key[1], null);
		TNode t0 = new TNode(t1, key[0], null);
		TNode t3 = new TNode(null, key[3], t0);
		TNode t4 = new TNode(null, key[4], t0);
		TNode t2 = new TNode(t3, key[2], t4);

		t0.rc = t2;

		t0.rc.lc.traverse(5);
		System.out.println("result = " + t2.data);
	}
}
