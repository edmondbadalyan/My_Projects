#include <iostream>

class Date {
private:
    int day;
    int month;
    int year;

public:
    Date(int d, int m, int y) : day(d), month(m), year(y) {}

    // Перегрузка оператора префиксного инкремента (++date)
    Date& operator++() {
        ++day;
        return *this;
    }

    // Перегрузка оператора постфиксного инкремента (date++)
    Date operator++(int) {
        Date temp(day, month, year);
        ++day;
        return temp;
    }

    // Перегрузка оператора префиксного декремента (--date)
    Date& operator--() {
        --day;
        return *this;
    }

    // Перегрузка оператора постфиксного декремента (date--)
    Date operator--(int) {
        Date temp(day, month, year);
        --day;
        return temp;
    }

    // Перегрузка оператора +=
    Date& operator+=(int days) {
        day += days;
        return *this;
    }

    // Перегрузка оператора -=
    Date& operator-=(int days) {
        day -= days;
        return *this;
    }

    // Дополнительные методы для вывода даты
    void displayDate() {
        std::cout << day << "/" << month << "/" << year << std::endl;
    }
};

int main() {
    Date date(5, 6, 2023);
    date.displayDate();  // Выводит: 5/6/2023

    // Примеры использования операторов инкремента и декремента
    ++date;
    date.displayDate();  // Выводит: 6/6/2023

    date++;
    date.displayDate();  // Выводит: 7/6/2023

    --date;
    date.displayDate();  // Выводит: 6/6/2023

    date--;
    date.displayDate();  // Выводит: 5/6/2023

    // Примеры использования операторов += и -=
    date += 3;
    date.displayDate();  // Выводит: 8/6/2023

    date -= 2;
    date.displayDate();  // Выводит: 6/6/2023

    return 0;
}
