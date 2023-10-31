#include<iostream>
#include<string>
#include <windows.h>
using namespace std;

class Pet {
protected:
    string name;
    string characteristic;
public:
    Pet(string name, string characteristic) : name(name), characteristic(characteristic) {}

    virtual void ShowCharacteristic() {
        cout << "Имя: " << name << ", Характеристика: " << characteristic << endl;
    }
};

class Dog : public Pet {
public:
    Dog(string name, string characteristic) : Pet(name, characteristic) {}

    void ShowCharacteristic() override {
        cout << "Собака, Имя: " << name << ", Характеристика: " << characteristic << endl;
    }
};

class Cat : public Pet {
public:
    Cat(string name, string characteristic) : Pet(name, characteristic) {}

    void ShowCharacteristic() override {
        cout << "Кошка, Имя: " << name << ", Характеристика: " << characteristic << endl;
    }
};

class Parrot : public Pet {
public:
    Parrot(string name, string characteristic) : Pet(name, characteristic) {}

    void ShowCharacteristic() override {
        cout << "Попугай, Имя: " << name << ", Характеристика: " << characteristic << endl;
    }
};

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    Dog dog("Рекс", "Дружелюбный");
    Cat cat("Мурзик", "Независимый");
    Parrot parrot("Кеша", "Говорящий");

    dog.ShowCharacteristic();
    cat.ShowCharacteristic();
    parrot.ShowCharacteristic();

    return 0;
}
