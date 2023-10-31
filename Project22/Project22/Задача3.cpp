#include <iostream>
using namespace std;

int main() {
	const int size = 5;

	int arr[size] = { 1,2,3,4,5 };
	int* ptr = arr;
	int arr2[5];
	int* ptr2 = arr2;

	for (int i = 0; i < size/2; ++i) {
		int temp = ptr[i];
		ptr[i] = ptr[size - i - 1];
		ptr[size - i - 1] = temp;
		
	}

	for (int i = 0; i < size; ++i) {
		ptr2[i] = ptr[i];
		cout << ptr2[i];
	}
	



	return 0;

}