#include <iostream>

class Fraction {
private:
    int numerator;
    int denominator;

    // Функция для нахождения наибольшего общего делителя
    int gcd(int a, int b) {
        if (b == 0)
            return a;
        return gcd(b, a % b);
    }

    // Функция для сокращения дроби
    void reduce() {
        int commonDivisor = gcd(numerator, denominator);
        numerator /= commonDivisor;
        denominator /= commonDivisor;
    }

public:
    // Конструктор с параметрами
    Fraction(int num, int denom) : numerator(num), denominator(denom) {
        reduce();
    }

    // Конструктор по умолчанию
    Fraction() : Fraction(0, 1) {}

    // Вывод на экран дроби
    void print() const {
        std::cout << numerator << "/" << denominator << std::endl;
    }

    // Сложение двух дробей
    Fraction add(const Fraction& other) const {
        int newDenom = denominator * other.denominator;
        int newNum = numerator * other.denominator + other.numerator * denominator;
        return Fraction(newNum, newDenom);
    }

    // Вычитание двух дробей
    Fraction subtract(const Fraction& other) const {
        int newDenom = denominator * other.denominator;
        int newNum = numerator * other.denominator - other.numerator * denominator;
        return Fraction(newNum, newDenom);
    }

    // Умножение двух дробей
    Fraction multiply(const Fraction& other) const {
        int newNum = numerator * other.numerator;
        int newDenom = denominator * other.denominator;
        return Fraction(newNum, newDenom);
    }

    // Сложение дроби с целым числом
    Fraction add(int number) const {
        return add(Fraction(number, 1));
    }

    // Вычитание дроби из целого числа
    Fraction subtract(int number) const {
        return subtract(Fraction(number, 1));
    }

    // Умножение дроби на целое число
    Fraction multiply(int number) const {
        return multiply(Fraction(number, 1));
    }
};

int main() {
    Fraction f1(1, 2);
    Fraction f2(3, 4);

    // Сложение двух дробей
    Fraction sum = f1.add(f2);
    sum.print();  // Вывод: 5/4

    // Вычитание двух дробей
    Fraction diff = f1.subtract(f2);
    diff.print();  // Вывод: -1/4

    // Умножение двух дробей
    Fraction product = f1.multiply(f2);
    product.print();  // Вывод: 3/8

    // Сложение дроби с целым числом
    Fraction sumWithInt = f1.add(2);
    sumWithInt.print();  // Вывод: 5/2

    // Вычитание дроби из целого числа
    Fraction diffFromInt = f1.subtract(2);
    diffFromInt.print();  // Вывод: -3/2

    // Умножение дроби на целое число
    Fraction productWithInt = f1.multiply(3);
    productWithInt.print();  // Вывод: 3/2

    return 0;
}
