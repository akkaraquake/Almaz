#include <iostream>
using namespace std;
void task1() {
	cout << "Задание №1\n" << "Введите a и b через пробел и нажмите Enter: ";
	double a, b, S, P;
	cin >> a >> b;
	S = a * b;
	P = 2 * (a + b);
	cout << "S = " << S << ", " << "P = " << P << endl;
}
void task2() {
	cout << "Задание №2\n" << "Введите d и нажмите Enter: ";
	double d;
	double L, π = 3.14;
	cin >> d;
	L = π * d;
	cout << "L = " << L << endl;
}
void task3() {
	cout << "Задание №3\n" << "Введите a и b через пробел и нажмите Enter : ";
	double a, b;
	cin >> a >> b;
	cout << "Среднее арифметическое чисел a и b = " << (a + b) / 2 << endl;
}
void task4() {
	double x, y;
	cin >> x >> y;
	if ((x == 0) || (y == 0)) {
		cout << "Было введено нулевое(-ые) число(-а). Пожалуйста, введите ненулевые числа x и y: ";
		task4();
	}
	else {
		cout << "Сумма квадратов x и y = " << pow(x, 2) + pow(y, 2) << endl;
		cout << "Разность квадратов x и y = " << pow(x, 2) - pow(y, 2) << endl;
		cout << "Произведение квадратов x и y = " << pow(x, 2) * pow(y, 2) << endl;
		cout << "Частное квадратов x и y = " << pow(x, 2) / pow(y, 2) << endl;
	}
}
void task5() {
	double x, y;
	cin >> x >> y;
	if ((x == 0) || (y == 0)) {
		cout << "Было введено нулевое(-ые) число(-а). Пожалуйста, введите ненулевые числа x и y: ";
		task5();
	}
	else {
		cout << "Сумма модулей чисел x и y = " << abs(x) + abs(y) << endl;
		cout << "Разность модулей чисел x и y = " << abs(x) - abs(y) << endl;
		cout << "Произведение модулей чисел x и y = " << abs(x) * abs(y) << endl;
		cout << "Частное модулей чисел x и y = " << abs(x) / abs(y) << endl;
	}
}
int main() {
	setlocale(LC_ALL, "");
	cout << "Лабораторная работа №4\n";
	task1();
	task2();
	task3();
	cout << "Задание №4\n" << "Введите ненулевые числа x и y: ";
	task4();
	cout << "Задание №5\n" << "Введите ненулевые числа x и y: ";
	task5();
	return 0;
}