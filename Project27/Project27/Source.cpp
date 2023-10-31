#include <iostream>

const int ROWS = 3;
const int COLS = 3;

int main() {
    int arr[ROWS][COLS] = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };

    // Создаем новый массив с одним дополнительным столбцом
    int newArr[ROWS][COLS + 1];

    // Копируем все элементы из исходного массива в новый массив
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            newArr[i][j] = arr[i][j];
        }
    }

    // Добавляем новый столбец в конец каждой строки
    for (int i = 0; i < ROWS; i++) {
        newArr[i][COLS] = 0;
    }

    // Выводим результат на экран
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS + 1; j++) {
            std::cout << newArr[i][j] << " ";
        }
        std::cout << std::endl;
    }

    return 0;
}


/*#include <iostream>
using namespace std;

const int ROWS = 3;
const int COLS = 4;

int main() {
    int arr[ROWS][COLS] = { {1,2,3,4}, {5,6,7,8}, {9,10,11,12} };

    // Строка, которую нужно добавить
    int newRow[COLS] = { 13, 14, 15, 16 };

    // Двумерный массив для хранения новых строк
    int newArr[ROWS + 1][COLS];

    // Копируем новую строку в начало нового массива
    for (int i = 0; i < COLS; i++) {
        newArr[0][i] = newRow[i];
    }

    // Копируем существующие строки в новый массив, начиная со второй строки
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            newArr[i+1][j] = arr[i][j];
        }
    }

    // Выводим результат
    for (int i = 0; i < ROWS + 1; i++) {
        for (int j = 0; j < COLS; j++) {
            cout << newArr[i][j] << " ";
        }
        cout << endl;
    }

    return 0;
}*/






