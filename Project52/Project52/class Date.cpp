#include <iostream>

class Date {
private:
    int day;
    int month;
    int year;

public:
    Date(int d, int m, int y) : day(d), month(m), year(y) {}

    // ���������� ��������� ����������� ���������� (++date)
    Date& operator++() {
        ++day;
        return *this;
    }

    // ���������� ��������� ������������ ���������� (date++)
    Date operator++(int) {
        Date temp(day, month, year);
        ++day;
        return temp;
    }

    // ���������� ��������� ����������� ���������� (--date)
    Date& operator--() {
        --day;
        return *this;
    }

    // ���������� ��������� ������������ ���������� (date--)
    Date operator--(int) {
        Date temp(day, month, year);
        --day;
        return temp;
    }

    // ���������� ��������� +=
    Date& operator+=(int days) {
        day += days;
        return *this;
    }

    // ���������� ��������� -=
    Date& operator-=(int days) {
        day -= days;
        return *this;
    }

    // �������������� ������ ��� ������ ����
    void displayDate() {
        std::cout << day << "/" << month << "/" << year << std::endl;
    }
};

int main() {
    Date date(5, 6, 2023);
    date.displayDate();  // �������: 5/6/2023

    // ������� ������������� ���������� ���������� � ����������
    ++date;
    date.displayDate();  // �������: 6/6/2023

    date++;
    date.displayDate();  // �������: 7/6/2023

    --date;
    date.displayDate();  // �������: 6/6/2023

    date--;
    date.displayDate();  // �������: 5/6/2023

    // ������� ������������� ���������� += � -=
    date += 3;
    date.displayDate();  // �������: 8/6/2023

    date -= 2;
    date.displayDate();  // �������: 6/6/2023

    return 0;
}
