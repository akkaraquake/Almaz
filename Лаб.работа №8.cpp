#include <iostream>
#include <string>
using namespace std;
void tasks(int n) {
	if (n == 1) {
		cout << "Введите размер в байтах: ";
		double a;
		cin >> a;
		cout << "Размер в полных килобайтах - " << ceil(a / 1024) << endl;
	}
	else if (n == 2) {
		cout << "Введите а и b(a > b): ";
		int a, b;
		cin >> a >> b;
		if (a > b)
			cout << "Mакс. возможное кол-во отрезков длины B на отрезке длины A - " << a / b << endl;
		else
			cout << "Error" << endl;
	}
	else if (n == 3) {
		cout << "Введите а и b(a > b): ";
		int a, b;
		cin >> a >> b;
		if (a > b)
			cout << "Длина незанятой части отрезка A - " << a - a / b * b << endl;
		else
			cout << "Error" << endl;
	}
	else if (n == 4) {
		cout << "Введите двузначное число: ";
		int a;
		cin >> a;
		string s = to_string(a);
		if ((s.size() == 2) && (s[1] != '0'))
			cout << s[1] << s[0] << endl;
		else if ((s.size() == 2) && (s[1] == '0'))
			cout << s[0] << endl;
		else
			cout << "Error" << endl;
	}
	else if (n == 5) {
		cout << "Введите трёхзначное число: ";
		int a;
		cin >> a;
		string s = to_string(a);
		if (s.size() == 3)
			cout << s[1] << s[2] << s[0] << endl;
		else
			cout << "Error" << endl;
	}
}

int main() {
	setlocale(LC_ALL, "");
	cout << "Введите номер задания: ";
	int n;
	cin >> n;
	tasks(n);
	cout << "Если хотите продолжить, нажмите 1, иначе любую другую клавишу: ";
	int otvet;
	cin >> otvet;
	if (otvet == 1)
		main();
	return 0;
}