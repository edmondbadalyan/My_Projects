#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main() {
    // Открываем два файла
    ifstream file1("file1.txt");
    ifstream file2("file2.txt");

    // Проверяем, что файлы успешно открылись
    if (!file1.is_open() || !file2.is_open()) {
        cout << "Error in opening\n";
        
    }

    // Считываем строки поочередно из обоих файлов
    string line1, line2;
    int line_number = 0;
    bool mismatch_found = false;
    while (getline(file1, line1) && getline(file2, line2)) {
        if (line1 != line2) {
            // Если строки не совпадают, выводим их на экран
            cout << "String didnt match " << line_number << "\n";
            cout << "file 1: " << line1 << "\n";
            cout << "file 2: " << line2 << "\n";
            mismatch_found = true;
        }
        line_number++;
    }

 
    // Закрываем файлы
    file1.close();
    file2.close();

    return 0;
}

