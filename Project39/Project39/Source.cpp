#include <iostream>
using namespace std;

struct Cylinder {
    double radius;
    double height;

    double getVolume() {
        return 3.14159 * radius * radius * height;
    }

    double getArea() {
        return 2 * 3.14159 * radius * (radius + height);
    }
};

int main() {
    Cylinder c;
    cout << "Enter the radius of the cylinder: ";
    cin >> c.radius;
    cout << "Enter the height of the cylinder: ";
    cin >> c.height;

    int choice;
    cout << "Enter 1 to find the volume, or 2 to find the surface area: ";
    cin >> choice;

    switch (choice) {
    case 1:
        cout << "The volume of the cylinder is " << c.getVolume() << endl;
        break;
    case 2:
        cout << "The surface area of the cylinder is " << c.getArea() << endl;
        break;
    default:
        cout << "Invalid choice" << endl;
    }

    return 0;
}
