#include <iostream>
#include <string>
#include <algorithm>
#include <sstream>

using namespace std;

int main() {
    string text; // �����
    getline(cin, text); // ��������� ����� �� ������������ �����

    string word; // �����, ������� ����� �����
    cout << "a word to find: ";
    cin >> word;

    // ������ 1: ������� ���������� ��������� ��������� �����
    int count = 0;
    size_t pos = text.find(word); // ����� ������� ��������� �����
    while (pos != string::npos) { // ���� ������� �����
        count++;
        pos = text.find(word, pos + 1); // ���� ��������� ��������� �����
    }
    cout << "Number of occurrences of a word '" << word << "': " << count << endl;

    // ������ 2: ������� ���������� �������� � ������
    int charsCount = text.size();
    cout << "count symbols: " << charsCount << endl;

    

    // ������ 4: ��������� ����� ������
    reverse(text.begin(), text.end());
    cout << " Text reverse: " << text << endl;

    

    return 0;
}
