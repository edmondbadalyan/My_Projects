#include <iostream>

class Fraction {
private:
    int numerator;
    int denominator;

    // ������� ��� ���������� ����������� ������ ��������
    int gcd(int a, int b) {
        if (b == 0)
            return a;
        return gcd(b, a % b);
    }

    // ������� ��� ���������� �����
    void reduce() {
        int commonDivisor = gcd(numerator, denominator);
        numerator /= commonDivisor;
        denominator /= commonDivisor;
    }

public:
    // ����������� � �����������
    Fraction(int num, int denom) : numerator(num), denominator(denom) {
        reduce();
    }

    // ����������� �� ���������
    Fraction() : Fraction(0, 1) {}

    // ����� �� ����� �����
    void print() const {
        std::cout << numerator << "/" << denominator << std::endl;
    }

    // �������� ���� ������
    Fraction add(const Fraction& other) const {
        int newDenom = denominator * other.denominator;
        int newNum = numerator * other.denominator + other.numerator * denominator;
        return Fraction(newNum, newDenom);
    }

    // ��������� ���� ������
    Fraction subtract(const Fraction& other) const {
        int newDenom = denominator * other.denominator;
        int newNum = numerator * other.denominator - other.numerator * denominator;
        return Fraction(newNum, newDenom);
    }

    // ��������� ���� ������
    Fraction multiply(const Fraction& other) const {
        int newNum = numerator * other.numerator;
        int newDenom = denominator * other.denominator;
        return Fraction(newNum, newDenom);
    }

    // �������� ����� � ����� ������
    Fraction add(int number) const {
        return add(Fraction(number, 1));
    }

    // ��������� ����� �� ������ �����
    Fraction subtract(int number) const {
        return subtract(Fraction(number, 1));
    }

    // ��������� ����� �� ����� �����
    Fraction multiply(int number) const {
        return multiply(Fraction(number, 1));
    }
};

int main() {
    Fraction f1(1, 2);
    Fraction f2(3, 4);

    // �������� ���� ������
    Fraction sum = f1.add(f2);
    sum.print();  // �����: 5/4

    // ��������� ���� ������
    Fraction diff = f1.subtract(f2);
    diff.print();  // �����: -1/4

    // ��������� ���� ������
    Fraction product = f1.multiply(f2);
    product.print();  // �����: 3/8

    // �������� ����� � ����� ������
    Fraction sumWithInt = f1.add(2);
    sumWithInt.print();  // �����: 5/2

    // ��������� ����� �� ������ �����
    Fraction diffFromInt = f1.subtract(2);
    diffFromInt.print();  // �����: -3/2

    // ��������� ����� �� ����� �����
    Fraction productWithInt = f1.multiply(3);
    productWithInt.print();  // �����: 3/2

    return 0;
}
