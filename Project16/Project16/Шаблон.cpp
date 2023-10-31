#include <iostream>


template <typename T1, typename T2>
int partition(T1 arr[], int const L, int const R, T2 const key) {

    unsigned l = L, r = R;
    while (l <= r) {
        while (arr[l] < key) ++l;
        while (key < arr[r]) --r;
        if (l <= r) {
            auto tmp = arr[l];
            arr[l] = arr[r];
            arr[r] = tmp;
            ++l;
            --r;
        }
    }
    if (l > R) l = R; // TO ENSURE THE BOUNDARIES
    return l;
}


template <typename T3>
void print_arr(T3 arr[], unsigned const L, unsigned const R) {
    for (unsigned idx = L; idx != R; ++idx)
        std::cout << arr[idx] << " ";
    std::cout << std::endl; 
}

template <typename T4>
void quick_sort(T4 arr[], unsigned const L, unsigned const R) {
    if (L >= R) return;
    int c = partition(arr, L, R, arr[(L + R + 1) / 2]);
    quick_sort(arr, L, c - 1);;
    quick_sort(arr, c, R);
}

int main() {
    
    float arr[10] = { 1, 3, 5, 2, 9.8, 0, 8, 6, 7, 4 };
    print_arr(arr, 0, 10);

    quick_sort(arr, 0, 10 - 1);

    print_arr(arr, 0, 10);

    return 0;
}