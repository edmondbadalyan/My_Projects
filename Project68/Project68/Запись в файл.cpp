#include<iostream>
#include<fstream>
#include <windows.h>
#include<string>
using namespace std;
int main()
{
    SetConsoleOutputCP(1251);

    ofstream input_data("input_data.txt");
    ofstream result_data("result_data.txt");

    int num1, num2, result;
    cout << "������� ������ �����: ";
    cin >> num1;
    cout << "������� ������ �����: ";
    cin >> num2;

    input_data << "First number: " << num1 << "\n" << "Second number: " << num2 << endl;

    result = num1 + num2;
    result_data << "Result: " << result << endl;

    input_data.close();
    result_data.close();

    cout << "���� ������ � ���������� ���� �������� � ��������������� �����.\n";

    ifstream input_file("input_data.txt");
    string line;
    while (getline(input_file, line)) {
        cout << line << endl;
    }
    input_file.close();

    return 0;
}
