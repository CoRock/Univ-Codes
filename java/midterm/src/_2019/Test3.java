package _2019;

/**
 * 문제 3. 다음 프로그램의 출력을 쓰시오.
 */
class MyException extends Exception {
	private static final long serialVersionUID = 1L;

	What w;
	int which;

	MyException(What w, int i) {
		this.w = w;
		which = i;
	}

	public String toString() {
		return "(" + w.what + "," + which + ")";
	}
}

class What {
	int what;

	What() {
		what = 0;
	}

	void hoo(int x, int y) throws MyException {
		what++;
		if (x < 0 || y < 0)
			throw new MyException(this, x);
		what++;
	}

	void foo(int x) throws MyException {
		what++;
		if (x > 0)
			throw new MyException(this, x);
		what++;
	}

	void goo(int x, int y) throws MyException {
		what++;
		if (x < 0 && y < 0)
			throw new MyException(this, x);
		what++;
	}
}

public class Test3 {
	public static void main(String args[]) {
		int key[] = { 1, 2, 3, 4, 5 };
		What w = new What();
		try {
			System.out.println("Hello");
			w.hoo(key[0], key[1]);
			w.foo(key[2]);
			w.goo(key[3], key[4]);
			System.out.println("World");
		} catch (MyException e) {
			System.out.println(e);
		}
	}
}
