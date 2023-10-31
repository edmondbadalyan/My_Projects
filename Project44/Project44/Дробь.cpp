#include <iostream>

class Fraction {
private:
    int numerator;
    int denominator;

public:
    // Конструктор
    Fraction(int num, int denom) : numerator(num), denominator(denom) {}

    // Сеттеры и геттеры для numerator
    void setNumerator(int num) {
        numerator = num;
    }

    int getNumerator() const {
        return numerator;
    }

    // Сеттеры и геттеры для denominator
    void setDenominator(int denom) {
        denominator = denom;
    }

    int getDenominator() const {
        return denominator;
    }

    
    Fraction add(const Fraction& other) const {
        int resultNum = numerator * other.denominator + other.numerator * denominator;
        int resultDenom = denominator * other.denominator;

        Fraction result(resultNum, resultDenom);
        return result;
    }

    Fraction subtract(const Fraction& other) const {
        int resultNum = numerator * other.denominator - other.numerator * denominator;
        int resultDenom = denominator * other.denominator;

        Fraction result(resultNum, resultDenom);
        return result;
    }

    Fraction multiply(const Fraction& other) const {
        int resultNum = numerator * other.numerator;
        int resultDenom = denominator * other.denominator;

        Fraction result(resultNum, resultDenom);
        return result;
    }

    Fraction divide(const Fraction& other) const {
        int resultNum = numerator * other.denominator;
        int resultDenom = denominator * other.numerator;

        Fraction result(resultNum, resultDenom);
        return result;
    }

    void printFraction() const {
        std::cout << numerator << "/" << denominator << std::endl;
    }
};

int main() {
    Fraction fraction1(1,2);
    Fraction fraction2(3,4);

    
    Fraction sum = fraction1.add(fraction2);
    Fraction difference = fraction1.subtract(fraction2);
    Fraction product = fraction1.multiply(fraction2);
    Fraction quotient = fraction1.divide(fraction2);

    std::cout << "Sum: ";
    sum.printFraction();

    std::cout << "Difference: ";
    difference.printFraction();

    std::cout << "Product: ";
    product.printFraction();

    std::cout << "Quotient: ";
    quotient.printFraction();

    return 0;
}
