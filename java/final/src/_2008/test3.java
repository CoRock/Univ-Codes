package _2008;

/**
 * 문제 3. 다음 프로그램의 출력을 쓰시오.
 */
class Animal {
	static int data[] = { 1, 2, 3, 4, 5 };

	void f(Animal x) {
		System.out.println(data[0]);
	}
}

class Bear extends Animal {
}

class Panda extends Bear {
	void f(Animal x) {
		if (x != null)
			x.f(null);
		System.out.println(data[1]);
		super.f(null);
		System.out.println(data[2]);
	}
}

class Tiger extends Animal {
	void f(Animal x) {
		System.out.println(data[3]);
		super.f(null);
		System.out.println(data[4]);
		if (x != null)
			x.f(null);
	}
}

class Test3 {
	public static void main(String args[]) {
		Animal a = new Animal();
		Animal b = new Bear();
		Animal c = new Panda();
		Animal d = new Tiger();

		a.f(b);
		b.f(c);
		c.f(d);
	}
}