package _2005;

/**
 * 문제 3. 다음 프로그램의 출력을 쓰시오.
 */
class Human {
	static int weight = 0;
	int w;

	Human() {
		w = 0;
	}

	void eat(int x) {
		weight++;
		w = x;
	}

	void print() {
		System.out.println(weight + "," + w);
	}
}

class Male extends Human {
	Male() {
		super();
	}

	void eat(int x) {
		super.eat(x);
		w = w - x;
	}
}

class Female extends Human {
	Female() {
		super();
	}

	void eat(int x) {
		super.eat(x);
		w = -1;
	}
}

public class Test3 {
	public static void main(String args[]) {
		int data[] = { 1, 2, 3, 4, 5 };
		Human x = new Human();
		Human y = new Male();
		Human z = new Female();
		x.eat(data[0]);
		y.eat(data[1]);
		z.eat(data[2]);
		y.eat(data[3]);
		z.eat(data[4]);
		x.print();
		y.print();
		z.print();
	}
}
