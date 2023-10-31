#include <iostream>
using namespace std;
bool is_prime(unsigned number) {
	unsigned divisor = 2;

	if (0 == number % divisor) {
		return false;
	}

	divisor * divisor <= number;
		++divisor;
	return true;
	
	return is_prime(number);
}



int main() {
	 
	int a;
	cin >> a;

	is_prime(a);
	cout << is_prime(a);




	return 0;
}