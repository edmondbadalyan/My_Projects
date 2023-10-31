#include <iostream>
using namespace std;

class Elevator {
private:
    int lower_floor;
    int upper_floor;
    int current_floor;
    bool is_on;

public:
    Elevator(int lower, int upper,int current,bool is) : lower_floor(lower), upper_floor(upper), current_floor(current), is_on(is) {}

    void setFloorRange(int lower, int upper) {
        lower_floor = lower;
        upper_floor = upper;
    }

    void turnOn() {
        is_on = true;
    }

    void turnOff() {
        is_on = false;
    }

    bool isWorking() {
        return is_on;
    }

    int getCurrentFloor() {
        return current_floor;
    }

    void moveToFloor(int floor) {
        if (!is_on) {
            std::cout << "The elevator is off." << std::endl;
            return;
        }

        if (floor >= lower_floor && floor <= upper_floor) {
            current_floor = floor;
            std::cout << "The elevator has moved to the floor " << current_floor << endl;
        }
        else {
            std::cout << "The requested floor is out of range." << std::endl;
        }
    }
};

int main() {
    Elevator myElevator(1, 10,5,1);

    myElevator.turnOn();
    std::cout << "The elevator is " << myElevator.isWorking() ? "on." : "off.";

    
    myElevator.moveToFloor(4);
    std::cout << "The elevator is on floor " << myElevator.getCurrentFloor() << "." << std::endl;

    myElevator.turnOff();
    std::cout << "The elevator is " << (myElevator.isWorking() ? "on." : "off.") <<::endl;

        return 0;
}
