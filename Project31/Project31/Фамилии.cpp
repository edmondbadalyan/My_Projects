#include <iostream>
#include <algorithm>
#include <string>

using namespace std;

int main() {
    string surnames[5];

    // ���� ������� ���������
    for (int i = 0; i < 5; i++) {
        cout << " Student surname " ;
        cin >> surnames[i];
    }

    // ���������� �������
    sort(surnames, surnames + 5);

    // ����� ��������������� �������
    cout << "Sorted surname : ";
    for (int i = 0; i < 5; i++) {
        cout << surnames[i] << " ";
    }

    return 0;
}