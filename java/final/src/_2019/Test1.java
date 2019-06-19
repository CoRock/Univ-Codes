package _2019;

/** 
 * 2019 자바 프로그래밍 기말 고사
 * 문제 1. 다음 프로그램의 출력을 쓰시오.
 */
import java.util.*;

class Test1 {
	public static void main(String args[]) {
		int data[] = { 1, 2, 3, 4, 5 };
		Stack<Object> x = new Stack<Object>();
		Stack<Object> y = new Stack<Object>();
		Stack<Object> z = new Stack<Object>();

		x.push(data[0]);

		for (int i = 0; i < data[1]; i++) {
			y.push(data[1]);
		}

		x.push(data[2]);
		z.push(data[3]);
		z.push(data[4]);
		x.push(z);
		x.push(y);
		z.pop();
		x.pop();

		System.out.println(x);
	}
}
