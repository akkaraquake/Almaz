#include <iostream>
using namespace std;
void tasks(int N) {
	if (N == 1) {
		cout << "Задание №1\n" << "Введите A и B через пробел и нажмите Enter: ";
		double A, B;
		cin >> A >> B;
		cout << "A = " << B << ", " << "B = " << A << endl;
	}
	else if (N == 2) {
		cout << "Задание №2\n" << "Введите A, B и C через пробел и нажмите Enter: ";
		double A, B, C;
		cin >> A >> B >> C;
		cout << "A = " << C << ", " << "B = " << A << ", " << "C = " << B << endl;
	}
	else if (N == 3) {
		cout << "Задание №3\n" << "Введите A, B и C через пробел и нажмите Enter: ";
		double A, B, C;
		cin >> A >> B >> C;
		A, B, C = B, C, A;
		cout << "A = " << A << ", " << "B = " << B << ", " << "C = " << C << endl;
	}
	else if (N == 4) {
		cout << "Задание №4\n" << "Введите x: ";
		double x, y;
		cin >> x;
		y = 3 * pow(x, 6) - 6 * pow(x, 2) - 7;
		cout << "y = " << y << endl;
	}
	else if (N == 5) {
		cout << "Задание №5\n" << "Введите x: ";
		double x, y;
		cin >> x;
		y = 4 * pow(x - 3, 6) - 7 * pow(x - 3, 3) + 2;
		cout << "y = " << y << endl;
	}
	else if (N == 6) {
		cout << "Задание №6\n" << "Введите A: ";
		double A;
		cin >> A;
		int k = 2;
		cout << "A^8 = " << pow(A, k) * pow(A, k) * pow(A, k) * pow(A, k) << endl;
	}
	else if (N == 7) {
		cout << "Задание №7\n" << "Введите A: ";
		double A, A15;
		cin >> A;
		int k = 3;
		A15 = pow(A, k) * pow(A, k) * pow(A, k) * pow(A, k) * pow(A, k) * 1;
		cout << "A^15 = " << A15 << endl;
	}
}
int main() {
	setlocale(LC_ALL, "");

	int N;
	cout << "Лабораторная работа №6\n" << "Введите номер задания: ";
	cin >> N;
	tasks(N);
	cout << "Если хотите решить другое задание, напишите 1, иначе - 0 и нажмите Enter: ";
	int otvet;
	cin >> otvet;
	if (otvet == 1)
		main();
	return 0;
}