#include <iostream>
using namespace std;

unsigned mod(unsigned number, unsigned divisor) {

	while (number > divisor)
		number -= divisor;
	cout << number;
	return number;
	
}



unsigned mod_rec(unsigned number, unsigned divisor) {

	if (number > divisor) {
		number -= divisor;
		cout << number;
	}
	return mod_rec(number, divisor);
}


int main() {

	int a;
	int b;
	cin >> a >> b;
	mod_rec(a, b);

	return 0;
}