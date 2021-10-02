#include <iostream>
#include <math.h>
using namespace std;

void task1() {
	cout << "Введите координаты двух точек, т.е введите x1, y1, x2, y2 cоответственно через пробел и нажмите Enter: ";
	double x1, y1, x2, y2, d;
	cin >> x1 >> y1 >> x2 >> y2;
	d = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));
	cout << "Расстояние между двумя точками = " << d << endl;
}
void task2() {
	cout << "Введите координаты точек на числовой оси А, B и С соответственно через пробел и нажмите Enter: ";
	double A, B, C;
	cin >> A >> B >> C;
	cout << "Длина отрезка AC = " << abs(C - A) << endl;
	cout << "Длина отрезка BC = " << abs(C - B) << endl;
	cout << "Сумма отрезков АС и BC = " << abs(C - A) + abs(C - B) << endl;
}
void task3() {
	cout << "Введите координаты точек на числовой оси А, C и B соответственно в порядке возрастания через пробел и нажмите Enter: ";
	double A, B, C;
	cin >> A >> C >> B;
	if ((A < C) && (C < B))
		cout << "Произведение длин отрезков АС и BC = " << (C - A) * (B - C) << endl;
	else {
		cout << "Данные введены неверно!";
		task3();
	}
}
void task4() {
	cout << "Введите координаты двух противоположных вершин прямоугольника, т.е введите такие x1, y1, x2, y2 ";
	cout << "соответственно через пробел, что x1 != x2 и y1 != y2, и нажмите Enter: ";
	double x1, y1, x2, y2, S, P;
	cin >> x1 >> y1 >> x2 >> y2;
	if ((x1 != x2) && (y1 != y2)) {
		S = abs(x2 - x1) * abs(y2 - y1);
		P = 2 * (abs(x2 - x1) + abs(y2 - y1));
		cout << "S = " << S << ", " << "P = " << P << endl;
	}
	else {
		cout << "Данные введены неверно!";
		task4();
	}
}
void task5() {
	cout << "Введите координаты вершин треугольника(x1, y1, x2, y2, x3, y3 cоответственно через пробел и нажмите Enter): ";
	double x1, y1, x2, y2, x3, y3, P, S, a, b, c;
	cin >> x1 >> y1 >> x2 >> y2 >> x3 >> y3;
	if (((x1 == x2) && (x2 == x3)) || ((y1 == y2) && (y2 == y3))) {
		cout << "Введенные координаты не образуют треугольник!";
		task5();
	}
	else {
		a = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));
		b = sqrt(pow(x3 - x2, 2) + pow(y3 - y2, 2));
		c = sqrt(pow(x3 - x1, 2) + pow(y3 - y1, 2));
		P = a + b + c;
		S = sqrt(P / 2 * (P / 2 - a) * (P / 2 - b) * (P / 2 - c));
		cout << "S = " << S << ", " << "P = " << P;
	}
}
int main() {
	setlocale(LC_ALL, "");
	cout << "Лабораторная работа №5\n";
	cout << "Задание №1\n";
	task1();
	cout << "Задание №2\n";
	task2();
	cout << "Задание №3\n";
	task3();
	cout << "Задание №4\n";
	task4();
	cout << "Задание №5\n";
	task5();
	return 0;
}