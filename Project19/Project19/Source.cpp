#include <iostream>
using namespace std;

int main() {
	int const size = 5;
	int arr[size] = { 1,2,3,4,5 };

	int* ptr = arr+size-1;

	


	for (int i = 0; i < size; ++i) {
		cout << *ptr;
	}



	return 0;
}