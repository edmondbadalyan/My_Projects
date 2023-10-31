#include <iostream>

int main() {

	int  arr[5] = { 4,5,3,2,1 };
	int sum = 0;
	
	for (int idx = 0; idx < 5; ++idx)
	{
		sum = arr[idx] + sum;


	}
	std::cout << sum;




	return 0;
}