#include <iostream>
#include <cstring>

class Person {
private:
    char* name;

public:
    Person(const char* name) {
        this->name = new char[strlen(name) + 1];
        strcpy(this->name, name);
    }

    // Конструктор копирования
    Person(const Person& other) {
        name = new char[strlen(other.name) + 1];
        strcpy(name, other.name);
    }

    ~Person() {
        delete[] name;
    }

    const char* getName() const {
        return name;
    }
};

class Apartment {
private:
    Person** residents;
    int numResidents;

public:
    Apartment();

    Apartment(int capacity) {
        residents = new Person * [capacity];
        numResidents = 0;
    }

    ~Apartment() {
        for (int i = 0; i < numResidents; ++i) {
            delete residents[i];
        }
        delete[] residents;
    }

    void addResident(const char* name) {
        residents[numResidents] = new Person(name);
        ++numResidents;
    }

    void printResidents() const {
        for (int i = 0; i < numResidents; ++i) {
            std::cout << residents[i]->getName() << std::endl;
        }
    }
};

class House {
private:
    Apartment* apartments;
    int numApartments;

public:
    House(int numApartments) {
        apartments = new Apartment[numApartments];
        this->numApartments = numApartments;
    }

    ~House() {
        delete[] apartments;
    }

    void addResident(int apartmentIndex, const char* name) {
        if (apartmentIndex >= 0 && apartmentIndex < numApartments) {
            apartments[apartmentIndex].addResident(name);
        }
    }

    void printResidents(int apartmentIndex) const {
        if (apartmentIndex >= 0 && apartmentIndex < numApartments) {
            std::cout << "Residents of apartment " << apartmentIndex << ":" << std::endl;
            apartments[apartmentIndex].printResidents();
        }
    }
};

int main() {
    House house(3);

    // Добавление жителей
    house.addResident(0, "John Smith");
    house.addResident(0, "Alice Johnson");
    house.addResident(1, "Michael Davis");
    house.addResident(2, "Emily Wilson");
    house.addResident(2, "David Brown");

    // Вывод жителей каждой квартиры
    house.printResidents(0);
    house.printResidents(1);
    house.printResidents(2);

    return 0;
}
