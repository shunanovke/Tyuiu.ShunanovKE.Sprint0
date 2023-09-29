// Tyuiu.ShunanovKE.Sprint0.Task5.V4.cpp : This file contains the 'main' function.

#include <iostream>
#include "../Tyuiu.ShunanovKE.Sprint0.Task5.V4.Lib/Tyuiu.ShunanovKE.Sprint0.Task5.V4.Lib.cpp"

int main()
{
	setlocale(LC_ALL, "RU");
	ISprint0Task5* d = new Service();
	float a, b, c;
	printf("Введите расстояние до дачи (км): ");
	scanf_s("%f", &a);
	printf("Введите расход бензина (литров на 100 км пробега): ");
	scanf_s("%f", &b);
	printf("Введите цену литра бензина (руб.): ");
	scanf_s("%f", &c);
	std::cout << "Поездка на дачу и обратно обойдется в " << d->Zadacha(a, b, c);

}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
