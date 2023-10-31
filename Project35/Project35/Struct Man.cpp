#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

const int MAX_PEOPLE = 100; // максимальное количество людей

struct Man {
    string last_name;
    string first_name;
    int age;
    string birth_date;
};

int main() {
    Man people[MAX_PEOPLE]; // массив структур Man
    int n = 0; // количество людей в массиве

    // добавление записи
    people[n].last_name = "Ivanov";
    people[n].first_name = "Ivan";
    people[n].age = 30;
    people[n].birth_date = "01.01.1990";
    n++;

    // вывод информации
    cout << "People sorted by last name:" << endl;
    sort(people, people + n, [](const Man& a, const Man& b) {return a.last_name < b.last_name; });
    for (int i = 0; i < n; i++) {
        cout << people[i].last_name << " " << people[i].first_name << ", " << people[i].age << " years old, born on " << people[i].birth_date << endl;
    }

    // поиск по фамилии
    string last_name_to_find = "Ivanov";
    for (int i = 0; i < n; i++) {
        if (people[i].last_name == last_name_to_find) {
            cout << "Found: " << people[i].last_name << " " << people[i].first_name << endl;
        }
    }

    // изменение записи
    people[0].age = 35;

    // удаление записи
    n--;

    return 0;
}
