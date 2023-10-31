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
        cout << "���: " << name << ", ��������������: " << characteristic << endl;
    }
};

class Dog : public Pet {
public:
    Dog(string name, string characteristic) : Pet(name, characteristic) {}

    void ShowCharacteristic() override {
        cout << "������, ���: " << name << ", ��������������: " << characteristic << endl;
    }
};

class Cat : public Pet {
public:
    Cat(string name, string characteristic) : Pet(name, characteristic) {}

    void ShowCharacteristic() override {
        cout << "�����, ���: " << name << ", ��������������: " << characteristic << endl;
    }
};

class Parrot : public Pet {
public:
    Parrot(string name, string characteristic) : Pet(name, characteristic) {}

    void ShowCharacteristic() override {
        cout << "�������, ���: " << name << ", ��������������: " << characteristic << endl;
    }
};

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    Dog dog("����", "�����������");
    Cat cat("������", "�����������");
    Parrot parrot("����", "���������");

    dog.ShowCharacteristic();
    cat.ShowCharacteristic();
    parrot.ShowCharacteristic();

    return 0;
}
