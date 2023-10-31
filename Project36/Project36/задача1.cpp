#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main() {
    // ��������� ��� �����
    ifstream file1("file1.txt");
    ifstream file2("file2.txt");

    // ���������, ��� ����� ������� ���������
    if (!file1.is_open() || !file2.is_open()) {
        cout << "Error in opening\n";
        
    }

    // ��������� ������ ���������� �� ����� ������
    string line1, line2;
    int line_number = 0;
    bool mismatch_found = false;
    while (getline(file1, line1) && getline(file2, line2)) {
        if (line1 != line2) {
            // ���� ������ �� ���������, ������� �� �� �����
            cout << "String didnt match " << line_number << "\n";
            cout << "file 1: " << line1 << "\n";
            cout << "file 2: " << line2 << "\n";
            mismatch_found = true;
        }
        line_number++;
    }

 
    // ��������� �����
    file1.close();
    file2.close();

    return 0;
}

