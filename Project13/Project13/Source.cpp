#include <iostream>

using namespace std;



int main() {
	const int size = 5;
	int arr[size] = { 1,2,3,4,5 };
	int* ptr;
	ptr = &arr[0];

	for (int i = 0; i < size; ++i)
	{
		
		cout << ptr[2];
		
		break;


	}
	



	return 0;
}