#include <iostream>

int digit_sum(int a) {
	unsigned long long number;
	std::cin >> number;
	unsigned digit_sum = 0;

	while (number) {
		digit_sum += number % 10;

		number /= 10;
	}
	return digit_sum;
}

int main()
{
	int x=0;

	 x = digit_sum(x);

     std::cout << x;

	return 0;
}