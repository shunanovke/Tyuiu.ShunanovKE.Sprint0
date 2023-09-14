// Tyuiu.ShunanovKE.Sprint0.Task7.V4.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main()
{
    setlocale(LC_ALL, "RU");
    std::cout << "Введите шестизначное число: ";
    int x;
    std::cin >> x;
    std::cout << "Введите цифру: ";
    int y;
    std::cin >> y;
    bool p = (x % 10 == y) || ((x/10) % 10 == y) || ((x / 100) % 10 == y) || ((x / 1000) % 10 == y) || 
        ((x / 10000) % 10 == y) || ((x / 100000) == y);
    std::cout << "В числе " << x << " содержится цифра " << y << ": " << std::boolalpha << p;

}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer wind to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
