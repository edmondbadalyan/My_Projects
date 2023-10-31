#pragma once
#include <iostream>
using namespace std;
class Fraction {
private:
    int numerator;
    int denominator;

public:
    Fraction() : numerator(0), denominator(1) {}

    Fraction(int numerator, int denominator) : numerator(numerator), denominator(denominator) {}

    friend Fraction operator+(const Fraction& f1, const Fraction& f2);
    friend Fraction operator-(const Fraction& f1, const Fraction& f2);
    friend Fraction operator*(const Fraction& f1, const Fraction& f2);
    friend Fraction operator/(const Fraction& f1, const Fraction& f2);
    friend bool operator==(const Fraction& f1, const Fraction& f2);
    friend bool operator>(const Fraction& f1, const Fraction& f2);
    friend bool operator<(const Fraction& f1, const Fraction& f2);

    friend ostream& operator<<(ostream& os, const Fraction& f);
    friend istream& operator>>(istream& is, Fraction& f);
};

