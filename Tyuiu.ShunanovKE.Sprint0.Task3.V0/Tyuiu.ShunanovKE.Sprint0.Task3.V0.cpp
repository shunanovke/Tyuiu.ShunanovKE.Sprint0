
#include <iostream>
#include "../Tyuiu.ShunanovKE.Sprint0.Task3.V0.Lib/Tyuiu.ShunanovKE.Sprint0.Task3.V0.Lib.cpp"

//Не нашел нигде архив для своей библиотеки

int main()
{
    ISprint0Task3V0* date = new Service1();
    std::cout << "ShunanovKE\n";
    std::cout << "P = a+b+c\n";
    std::cout << "a = 10\n b = 11\n c = 5\n";
    std::cout << "Rezult = " << date->Add(10,11,5);
    std::cout << std:: endl;
}

