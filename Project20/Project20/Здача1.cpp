#include <iostream>
using namespace std;

int main() {

    const int SIZE = 5;
    int arr1[SIZE] = { 35, 76, 106, 457, 7989 };
    int arr2[SIZE];

    int* dest_ptr = arr2;
    int* src_ptr = arr1;

    for (int i = 0; i < SIZE; i++) {
        *dest_ptr = *src_ptr;
        dest_ptr++;
        src_ptr++;
    }
    dest_ptr = arr2;
    std::cout << "arr2: ";
    for (int i = 0; i < SIZE; i++) {
        std::cout << *dest_ptr << " ";
        dest_ptr++;
    }
    cout << endl;


    return 0;
}