#include <iostream>
using namespace std;
void tasks(int n) {
	if (n == 1) {
		cout << "Задание №1" << endl;
		int N;
		cout << "Введите N: ";
		cin >> N;
		cout << "Ответ: " << N - N / 60 * 60 << endl;
	}
	else if (n == 2) {
		cout << "Задание №2" << endl;
		int K;
		cout << "Введите K: ";
		cin >> K;
		cout << "Ответ: " << K % 7 << endl;
	}
	else if (n == 3) {
		cout << "Задание №3" << endl;
		int K, N;
		cout << "Введите K и N: ";
		cin >> K >> N;
		if ((N == 1) && (K % 7 == 0))
			cout << "Ответ: " << 7;
		else
			cout << "Ответ: " << K % 7 + (N-1) << endl;
	}
	else if (n == 4) {
		cout << "Задание №4" << endl;
		int a, b, c, kol, nezanchast;
		cout << "Введите a, b, c: ";
		cin >> a >> b >> c;
		if ((a < c) && (b < c))
			cout << "Данные введены неверно!";
		else {
			kol = (a / c) * (b / c);
			nezanchast = a * b - kol * c * c;
			cout << "Кол-во квадратов = " << kol << ", площадь незанятой части = " << nezanchast << endl;
		}
	}
	else if (n == 5) {
		cout << "Задание №5" << endl;
		int year;
		cout << "Введите год: ";
		cin >> year;
		if (year % 100 == 0)
			cout << "Номер столетия = " << year / 100;
		else
			cout << "Номер столетия = " << year / 100 + 1;
	}

}
int main() {
	setlocale(LC_ALL, "");
	int n, otvet;
	cout << "Введите номер задания: ";
	cin >> n;
	tasks(n);
	cout << "Если хотите продолжить, нажмите 1, иначе любую другую клавишу: ";
	cin >> otvet;
	if (otvet == 1)
		main();
	return 0;
}