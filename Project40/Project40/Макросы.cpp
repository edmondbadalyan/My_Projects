#include <iostream>

#define PERIMETER(a, b, c) (a + b + c)
#define POLY_PERIMETER(a, b, c) ((a + b + c) / 2.0)
#define TRIANGLE(a, b, c) ((a + b > c) && (a + c > b) && (b + c > a))
#define DISCRIMINANT(a, b, c) (b * b - 4 * a * c)
#define Korni(a, b, c) (DISCRIMINANT(a, b, c) >= 0)
#define AREA(a, b, c) (0.5 * a * sqrt(pow(b, 2) - pow((pow(b, 2) - pow(c, 2) + pow(a, 2)) / (2 * a), 2)))
