#include <iostream>

const int ROWS = 3;
const int COLS = 3;

int main() {
    int arr[ROWS][COLS] = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };

    // ������� ����� ������ � ����� �������������� ��������
    int newArr[ROWS][COLS + 1];

    // �������� ��� �������� �� ��������� ������� � ����� ������
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            newArr[i][j] = arr[i][j];
        }
    }

    // ��������� ����� ������� � ����� ������ ������
    for (int i = 0; i < ROWS; i++) {
        newArr[i][COLS] = 0;
    }

    // ������� ��������� �� �����
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

    // ������, ������� ����� ��������
    int newRow[COLS] = { 13, 14, 15, 16 };

    // ��������� ������ ��� �������� ����� �����
    int newArr[ROWS + 1][COLS];

    // �������� ����� ������ � ������ ������ �������
    for (int i = 0; i < COLS; i++) {
        newArr[0][i] = newRow[i];
    }

    // �������� ������������ ������ � ����� ������, ������� �� ������ ������
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            newArr[i+1][j] = arr[i][j];
        }
    }

    // ������� ���������
    for (int i = 0; i < ROWS + 1; i++) {
        for (int j = 0; j < COLS; j++) {
            cout << newArr[i][j] << " ";
        }
        cout << endl;
    }

    return 0;
}*/






