#include <iostream>
int main() {

    const int ROWS = 5;
    const int COLS = 3;
    int arr_2D[ROWS][COLS];
    int max_in_row[ROWS];
    int max_in_col[COLS];

    
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            if (arr_2D[i][j] > max_in_row[i]) {
                max_in_row[i] = arr_2D[i][j];
            }
        }
    }

    
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            if (arr_2D[i][j] > max_in_col[j]) {
                max_in_col[j] = arr_2D[i][j];
            }
        }
    }

    
    
    for (int i = 0; i < ROWS; i++) {
        std::cout << max_in_row[i] << " ";
    }
    std::cout << std::endl;

    
    for (int j = 0; j < COLS; j++) {
        std::cout << max_in_col[j] << " ";
    }
    std::cout << std::endl;

    

    return 0;
}
