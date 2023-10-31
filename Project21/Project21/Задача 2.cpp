#include <iostream>
using namespace std;
int main() {

	int arr[5] = { 1,2,3,4,5 };
	int* ptr = arr;

	for (int i = 0; i < 5/2; i++) {
		int temp = ptr[i];
		ptr[i] = ptr[5 - i - 1];
		ptr[5 - i - 1] = temp;
	}

	for (int i = 0; i < 5; i++) {
		std::cout << ptr[i] << " ";
	}
	std::cout << std::endl;



	return 0;
}