#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

const int MAX_PEOPLE = 100; // ������������ ���������� �����

struct Man {
    string last_name;
    string first_name;
    int age;
    string birth_date;
};

int main() {
    Man people[MAX_PEOPLE]; // ������ �������� Man
    int n = 0; // ���������� ����� � �������

    // ���������� ������
    people[n].last_name = "Ivanov";
    people[n].first_name = "Ivan";
    people[n].age = 30;
    people[n].birth_date = "01.01.1990";
    n++;

    // ����� ����������
    cout << "People sorted by last name:" << endl;
    sort(people, people + n, [](const Man& a, const Man& b) {return a.last_name < b.last_name; });
    for (int i = 0; i < n; i++) {
        cout << people[i].last_name << " " << people[i].first_name << ", " << people[i].age << " years old, born on " << people[i].birth_date << endl;
    }

    // ����� �� �������
    string last_name_to_find = "Ivanov";
    for (int i = 0; i < n; i++) {
        if (people[i].last_name == last_name_to_find) {
            cout << "Found: " << people[i].last_name << " " << people[i].first_name << endl;
        }
    }

    // ��������� ������
    people[0].age = 35;

    // �������� ������
    n--;

    return 0;
}
