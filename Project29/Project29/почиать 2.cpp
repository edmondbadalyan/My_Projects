#include <iostream>

const int ROW_SIZE = 3;
const int COL_SIZE = 4;

void addColumn(int arr[][COL_SIZE], int colIndex, int val) {
    for (int i = 0; i < ROW_SIZE; i++) {
        for (int j = COL_SIZE - 1; j > colIndex; j--) {
            arr[i][j] = arr[i][j-1];
        }
        arr[i][colIndex] = val;
    }
}

int main() {
    int arr[ROW_SIZE][COL_SIZE] = { {1,2,3,4}, {5,6,7,8}, {9,10,11,12} };

    std::cout << "Before adding column:\n";
    for (int i = 0; i < ROW_SIZE; i++) {
        for (int j = 0; j < COL_SIZE; j++) {
            std::cout << arr[i][j] << " ";
        }
        std::cout << "\n";
    }

    addColumn(arr, 2, 0);

    std::cout << "After adding column:\n";
    for (int i = 0; i < ROW_SIZE; i++) {
        for (int j = 0; j < COL_SIZE + 1; j++) {
            std::cout << arr[i][j] << " ";
        }
        std::cout << "\n";
    }

/*const int ROWS = 3;
const int COLS = 4;

void addColumn(int arr[][COLS], int pos) {
    
    for (int i = 0; i < ROWS; i++) {
        for (int j = COLS - 1; j > pos; j--) {
            arr[i][j] = arr[i][j - 1];
        }
        arr[i][pos] = 0; // or any default value
    }
}

int main() {
    int arr[ROWS][COLS] = { {1,2,3,4}, {5,6,7,8}, {9,10,11,12} };

    cout << "Before adding a column:\n";
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            cout << arr[i][j] << " ";
        }
        cout << endl;
    }

    addColumn(arr, 2);

    cout << "After adding a column at position 2:\n";
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            cout << arr[i][j] << " ";
        }
        cout << endl;
    }
    */
    return 0;
}