#include <iostream>
using namespace std;

int* allocate_memory( int size) {
    int *arr = new int[size];
    return arr;
}
void Fill_array(int* arr, int size) {
    for (int i = 0; i < size; ++i) {
        arr[i] = i + 1;
    }
}
void Show_array(int* arr, int size) {
    for (int i = 0; i < size; ++i) {
        cout << arr[i];
    }
}
void Delete_array(int* arr, int size) {
    delete[] arr;
}
void add_element(int* &arr, int &size,int element) {
    int* new_arr = new int[size + 1];

    for (int i = 0; i < size; i++) {
        new_arr[i] = arr[i];
    }    
    new_arr[size] = element;

    arr = new_arr;
    size++;
}
void insert_element_index(int*& arr, int& size, int index, int element) {
    int* newArr = new int[size + 1];
    for (int i = 0; i < index; ++i) {
        newArr[i] = arr[i];
    }
    newArr[index] = element;

    for (int i = index; i < size; ++i) {
        newArr[i+1] = arr[i];
    }
    size++;
    arr = newArr;

}
void delete_element_index(int*& arr, int& size, int index) {
    int* newArr = new int[size - 1];
    for (int i = 0; i < index; ++i) {
        newArr[i] = arr[i];
    }
    for (int i = index + 1; i < size; ++i) {

    }
    arr = newArr;
    size--;
}


int main() {
       

        return 0;
    }


   

