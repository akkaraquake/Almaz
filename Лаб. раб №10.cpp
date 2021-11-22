#include <iostream>
#include <string>
using namespace std;
void tasks(int n) {
	if (n == 1) {
		cout << "Задание №1" << endl;
		int a, b;
		bool f;
		cout << "Введите а и b: ";
		cin >> a >> b;
		cout << "«Справедливы неравенства A > 2 и B <= 3»" << endl;
		f = (a > 2) && (b <= 3);
		cout << "Ответ: " << f << endl;
	}
	else if (n == 2) {
		cout << "Задание №2" << endl;
		int a, b, c;
		bool f;
		cout << "Введите а, b, c: ";
		cin >> a >> b >> c;
		cout << "«Справедливо двойное неравенство A < B < C»" << endl;
		f = (a < b) && (b < c);
		cout << "Ответ: " << f << endl;
	}
	else if (n == 3) {
		cout << "Задание №3" << endl;
		int a;
		bool f;
		cout << "Введите а: ";
		cin >> a;
		cout << "«Данное число является четным двузначным»" << endl;
		f = (a % 2 == 0) && (size((to_string(a))) == 2);
		cout << "Ответ: " << f << endl;
	}
	else if (n == 4) {
		cout << "Задание №4" << endl;
		int a;
		bool f1, f2;
		cout << "Введите трехзначное число а: ";
		cin >> a;
		if (size((to_string(a))) == 3) {
			f1 = (to_string(a)[0] < to_string(a)[1]) && (to_string(a)[1] < to_string(a)[2]);
			f2 = (to_string(a)[0] > to_string(a)[1]) && (to_string(a)[1] > to_string(a)[2]);
			cout << "Ответ: " << (f1 || f2) << endl;
		}
		else
			cout << "Err" << endl;
	}
	else if (n == 5) {
		cout << "Задание №5" << endl;
		int a;
		bool f;
		cout << "Введите четырехзначное число а: ";
		cin >> a;
		if (size((to_string(a))) == 4) {
			f = (to_string(a)[0] == to_string(a)[3]) && (to_string(a)[1] == to_string(a)[2]);
			cout << "Ответ: " << f << endl;
		}
		else
			cout << "Err" << endl;
	}
	else if (n == 6) {
		cout << "Задание №6" << endl;
		int a, b, c;
		bool f;
		cout << "Введите а, b, с: ";
		cin >> a >> b >> c;
		cout << "«Треугольник со сторонами a, b, c является прямоугольным»" << endl;
		if (((a <= b) && (b < c)) || ((a > b) && (a < c))) {
			f = (pow(a, 2) + pow(b, 2) == pow(c, 2));
			cout << "Ответ: " << f << endl;
		}
		else if (((c <= b) && (b < a)) || ((c > b) && (c < a))) {
			f = (pow(c, 2) + pow(b, 2) == pow(a, 2));
			cout << "Ответ: " << f << endl;
		}
		else {
			f = (pow(c, 2) + pow(a, 2) == pow(b, 2));
			cout << "Ответ: " << f << endl;
		}
	}
	else if (n == 7) {
		cout << "Задание №7" << endl;
		int a, b, c;
		bool f;
		cout << "Введите а, b, с: ";
		cin >> a >> b >> c;
		cout << "«Существует треугольник со сторонами a, b, c»" << endl;
		f = (a + b) > c;
		cout << "Ответ: " << f << endl;
	}
	else
		cout << "Такого задания не существует" << endl;
}
int main() {
	setlocale(LC_ALL, "");
	int n, otvet;
	cout << "Введите номер задания: ";
	cin >> n;
	tasks(n);
	cout << "Если хотите продолжить нажмите 1, иначе любую другую кнопку: ";
	cin >> otvet;
	if (otvet == 1)
		main();
	return 0;
}