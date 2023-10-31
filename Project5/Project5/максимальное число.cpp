#include <iostream>

int Max_integer(int a, int b) {
	int max;
	if (a > b)
		max = a;
	else
		max = b;

	return max;
}


int main()
{

	int x, y;
	std::cin >> x >> y;

	int max =  Max_integer(x, y);

	std::cout << max;

	return 0;
}