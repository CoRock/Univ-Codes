package _2007;

/**
 * 문제 2. 다음 프로그램의 출력을 쓰시오.
 */
class Hello {
	Eden home;
	int x;

	Hello(Eden e) {
		home = e;
	}

	public void say() {
		x = home.key[0];
	}

	public void talk() {
		x = home.key[1];
	}

	public void print() {
		System.out.println(x);
	}
}

class World extends Hello {
	Hello h;
	int x;

	World(Eden e, Hello x) {
		super(e);
		h = x;
	}

	public void say() {
		super.say();
		x = home.key[2];
	}

	public void talk() {
		h.x = home.key[3];
		x = home.key[4];
		say();
	}
}

class Eden {
	int key[];

	Eden(int x[]) {
		key = x;
	}

	void ok() {
		Hello h = new Hello(this);
		h.say();
		h.talk();
		Hello w = new World(this, h);
		w.say();
		w.talk();
		h.print();
		w.print();
	}
}

public class Test2 {
	public static void main(String args[]) {
		int key[] = { 1, 2, 3, 4, 5 };
		Eden x = new Eden(key);
		x.ok();
	}
}
