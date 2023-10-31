#include <iostream>
using namespace std;
/*int* Action(int*& arr, int*& arr2, int& size1, int& size2) {

}*/




int main() {
    int n;
    cin >> n;

    int min_cuts;
    if (n == 1) {
        min_cuts = n;
    }
    else if (n % 2 == 0) {
        min_cuts = n / 2;
    }
    else {
        min_cuts = (n / 2) + 1;
    }

    cout << min_cuts << endl;
  
   /* int n;
    cin >> n; // считываем число N

    int cuts = n - 1; // инициализируем количество разрезов

    // проверяем, можно ли обойтись меньшим числом разрезов
    for (int i = 2; i <= n; i++) {
        if (n % i == 0) {
            cuts = n / i;
            break;
        }
        if (n % i != 0) {
            cuts = 
        }
    }

    cout << cuts << endl; // выводим количество разрезов
    */

	return 0;
}