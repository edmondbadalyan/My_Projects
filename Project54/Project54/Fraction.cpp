#include "Fraction.h"
using namespace std;

Fraction operator+(const Fraction& f1, const Fraction& f2) {
    int newDenom = f1.denominator * f2.denominator;
    int newNum = f1.numerator * f2.denominator + f2.numerator * f1.denominator;
    return Fraction(newNum, newDenom);
}

Fraction operator-(const Fraction& f1, const Fraction& f2) {
    int newDenom = f1.denominator * f2.denominator;
    int newNum = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
    return Fraction(newNum, newDenom);
}

Fraction operator*(const Fraction& f1, const Fraction& f2) {
    int newNum = f1.numerator * f2.numerator;
    int newDenom = f1.denominator * f2.denominator;
    return Fraction(newNum, newDenom);
}

Fraction operator/(const Fraction& f1, const Fraction& f2) {
    int newNum = f1.numerator * f2.denominator;
    int newDenom = f1.denominator * f2.numerator;
    return Fraction(newNum, newDenom);
}

bool operator==(const Fraction& f1, const Fraction& f2) {
    return (f1.numerator * f2.denominator) == (f2.numerator * f1.denominator);
}

bool operator>(const Fraction& f1, const Fraction& f2) {
    return (f1.numerator * f2.denominator) > (f2.numerator * f1.denominator);
}

bool operator<(const Fraction& f1, const Fraction& f2) {
    return (f1.numerator * f2.denominator) < (f2.numerator * f1.denominator);
}

ostream& operator<<(ostream& os, const Fraction& f) {
    os << f.numerator << "/" << f.denominator;
    return os;
}

istream& operator>>(istream& is, Fraction& f) {
    is >> f.numerator;
    is.ignore(1); // Игнорируем разделитель (/)
    is >> f.denominator;
    return is;
}