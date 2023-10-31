#include <iostream>
#include <string>

using namespace std;

struct Car {
    float length;
    float clearance;
    float engineVolume;
    float enginePower;
    float wheelDiameter;
    string color;
    string transmissionType;
};

void setValues(Car& car, float length, float clearance, float engineVolume, float enginePower, float wheelDiameter, string color, string transmissionType) {
    car.length = length;
    car.clearance = clearance;
    car.engineVolume = engineVolume;
    car.enginePower = enginePower;
    car.wheelDiameter = wheelDiameter;
    car.color = color;
    car.transmissionType = transmissionType;
}

void displayValues(Car car) {
    cout << "Length: " << car.length << endl;
    cout << "Clearance: " << car.clearance << endl;
    cout << "Engine volume: " << car.engineVolume << endl;
    cout << "Engine power: " << car.enginePower << endl;
    cout << "Wheel diameter: " << car.wheelDiameter << endl;
    cout << "Color: " << car.color << endl;
    cout << "Transmission type: " << car.transmissionType << endl;
}

bool findCarByEnginePower(Car car, float enginePower) {
    return car.enginePower == enginePower;
}

int main() {
    Car Mersedes;
    setValues(Mersedes, 4.5, 0.2, 2.5, 200, 16, "Red", "Automatic");
    displayValues(Mersedes);
    if (findCarByEnginePower(Mersedes, 200)) {
        cout << "Found car with engine power of 200" << endl;
    }
    else {
        cout << "No car found with engine power of 200" << endl;
    }
    return 0;
}
