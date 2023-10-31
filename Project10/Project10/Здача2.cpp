#include <iostream>
using namespace std;
unsigned digit_sum_rec(unsigned number, unsigned sum = 0) {

	if (0 == number) return sum;
	return digit_sum_rec(number / 10, sum + number % 10);
}

unsigned digit_sum(unsigned number, unsigned sum = 0) {

	while (number) {
		sum += number % 10;
		number /= 10;
	}
	return sum;
}

int  main() {
	
	int a;
	cin >> a;
	digit_sum(a);
	cout << digit_sum(a);

	

	return 0;
}