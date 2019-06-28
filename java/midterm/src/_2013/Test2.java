package _2013;

/**
 * 문제 2. 다음 프로그램의 출력을 쓰시오.
 */
class List {

	int s[];
	List next;

	List(int n, List l) {
		s = new int[n];
		s[n - 1] = n;
		next = l;
	}

	public String toString() {
		String x = "";
		for (int i = 0; i < s.length; i++) {
			x = x + s[i];
		}
		if (next != null) {
			x = x + next.toString();
		}
		return x;
	}

	void link(List l) {
		next = l.next.next;
	}

}

public class Test2 {

	public static void main(String args[]) {
		int key[] = { 1, 2, 3, 4, 5 };

		List a = new List(key[0], null);
		List b = new List(key[1], a);
		List c = new List(key[2], b);
		List d = new List(key[3], c);
		List e = new List(key[4], d);
		e.link(c);
		System.out.println(e);
	}

}
