
#include "Fraction.h"


int main() {
    Fraction f1(1, 2);
    Fraction f2(3, 4);

    Fraction sum = f1 + f2;
    std::cout << "Sum: " << sum << std::endl;

    Fraction diff = f1 - f2;
    std::cout << "Difference: " << diff << std::endl;

    Fraction product = f1 * f2;
    std::cout << "Product: " << product << std::endl;

    Fraction quotient = f1 / f2;
    std::cout << "Quotient: " << quotient << std::endl;

    if (f1 == f2) {
        std::cout << "Fractions are equal" << std::endl;
    }
    else {
        std::cout << "Fractions are not equal" << std::endl;
    }

    if (f1 > f2) {
        std::cout << "f1 is greater than f2" << std::endl;
    }
    else {
        std::cout << "f1 is not greater than f2" << std::endl;
    }

    if (f1 < f2) {
        std::cout << "f1 is less than f2" << std::endl;
    }
    else {
        std::cout << "f1 is not less than f2" << std::endl;
    }

    // ¬вод дроби с помощью потока ввода
    Fraction inputFraction;
    std::cout << "Enter a fraction in the format 'numerator/denominator': ";
    std::cin >> inputFraction;
    std::cout << "Entered fraction: " << inputFraction << std::endl;

    return 0;
}
