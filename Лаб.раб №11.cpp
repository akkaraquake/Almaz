#include <iostream>
#include <string>
using namespace std;
void tasks(int n) {
	if (n == 1) {
		cout << "Задание №1" << endl;
		int a, b;
		cout << "Введите а и b: ";
		cin >> a >> b;
		if (a != b) {
			if (a > b) {
				b = a;
				cout << "a = " << a << ", b = " << b << endl;
			}
			else {
				a = b;
				cout << "a = " << a << ", b = " << b << endl;
			}
		}
		else {
			a = 0;
			b = 0;
			cout << "a = " << a << ", b = " << b << endl;
		}
	}
	else if (n == 2) {
		cout << "Задание №2" << endl;
		int a, b, c, mx, md, mn, s;
		cout << "Введите а, b, c: ";
		cin >> a >> b >> c;
		mx = max(max(a, b), c);
		mn = min(min(a, b), c);
		md = a + b + c - mx - mn;
		s = mx + md;
		cout << "Сумма наибольших чисел = " << s << endl;
	}
	else if (n == 3) {
		cout << "Задание №3" << endl;
		int Ax, Ay, Bx, By, Cx, Cy;
		double d1, d2;
		cout << "Введите координаты точек А,B и С: ";
		cin >> Ax >> Ay >> Bx >> By >> Cx >> Cy;
		d1 = sqrt(pow(Bx - Ax, 2) + pow(By - Ay, 2));
		d2 = sqrt(pow(Cx - Ax, 2) + pow(Cy - Ay, 2));
		if (d1 < d2)
			cout << "Точка В расположена ближе к точке А, расстояние = " << d1 << endl;
		else 
			cout << "Точка C расположена ближе к точке А, расстояние = " << d2 << endl;
	}
	else if (n == 4) {
		cout << "Задание №4" << endl;
		int x, y;
		cout << "Введите x и y: ";
		cin >> x >> y;
		if ((x == 0) && (y == 0))
			cout << "Err" << endl;
		else if ((x > 0) && (y > 0))
			cout << "Точка расположена в 1-ой четверти" << endl;
		else if ((x < 0) && (y > 0))
			cout << "Точка расположена во 2-ой четверти" << endl;
		else if ((x < 0) && (y < 0))
			cout << "Точка расположена в 3-ой четверти" << endl;
		else
			cout << "Точка расположена в 4-ой четверти" << endl;
	}
	else if (n == 5) {
		cout << "Задание №5" << endl;
		int a;
		cout << "Введите а: ";
		cin >> a;
		if (a == 0) 
			cout << "a - нулевое число" << endl;
		else {
			if (a > 0)
				cout << "a - положительное ";
			else
				cout << "a - отрицательное ";
			if (a % 2 == 0)
				cout << "четное число" << endl;
			else
				cout << "нечетное число" << endl;
		}
	}
	else if (n == 6) {
		cout << "Задание №6" << endl;
		int a;
		cout << "Введите а(1 < a < 1000): ";
		cin >> a;
		if ((a < 1) || (a > 999))
			cout << "Err" << endl;
		else {
			if (a % 2 == 0)
				cout << "a - четное ";
			else
				cout << "a - нечетное ";
			if (size(to_string(a)) == 1)
				cout << "однозначное число" << endl;
			else if (size(to_string(a)) == 2)
				cout << "двузначное число" << endl;
			else
				cout << "трехзначное число" << endl;
		}


	}

}
int main() {
	setlocale(LC_ALL, "");
	cout << "Введите номер задания: ";
	int n, otvet;
	cin >> n;
	tasks(n);
	cout << "Если хотите продолжить, нажмите 1, иначе 0: ";
	cin >> otvet;
	if (otvet == 1) 
		main();
	return 0;
}