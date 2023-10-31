#include <iostream>
#include <cstring>
using namespace std;


class Point {

private:
	double x;
	double y;

public:
	Point(double XX, double YY) : x{ XX }, y{ YY } {};
	void display() const {
		cout << x << y;
	}
	bool is_equal(const Point& point1, const Point& point2) {

		return (point1.x == point2.x && );
	}



};