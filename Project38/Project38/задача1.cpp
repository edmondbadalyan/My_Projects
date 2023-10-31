#include <iostream>
#include <fstream>
#include <string>
#include <filesystem>  // ��� ������ � �������� ��������
using namespace std;

void findAndReplace(const string& path, const string& search, const string& replace) {
    int count = 0;  // ������� ��������� �����
    // ����������� �� ���� ��������� � ����� � �� ���������
    for (const auto& entry : filesysten::recursive_directory_iterator(path)) {
        // ���� ������� �������� ������
        if (entry.is_regular_file()) {
            ifstream file(entry.path().string());  // ��������� ���� ��� ������
            string line;
            string file_contents;
            // ������ ���� ���������
            while (getline(file, line)) {
                size_t pos = line.find(search);  // ���� ��������� ������� ������
                while (pos != string::npos) {
                    ++count;  // ����������� ������� ��������� �����
                    line.replace(pos, search.length(), replace);  // �������� ��������� ������ �� ������
                    pos = line.find(search, pos + replace.length());  // ���������� ������ ����� � ������
                }
                file_contents += line + '\n';  // ��������� ����������� ������ � ����� ���������� �����
            }
            // ���� ���� ������� ��������� ������� ������
            if (count > 0) {
                cout << "Found " << count << " occurrences of \"" << search << "\" in file " << entry.path() << endl;
                ofstream outfile(entry.path().string());  // ��������� ���� ��� ������
                outfile << file_contents;  // ���������� ����� ���������� � ����
            }
            count = 0;  // ���������� �������
        }
    }
}

int main() {
    string path, search, replace;
    // �������� ����, ������� ������ � ������, �� ������� ����� ��������, �� ������������
    cout << "Enter path: ";
    getline(cin, path);
    cout << "Enter search string: ";
    getline(cin, search);
    cout << "Enter replace string: ";
    getline(cin, replace);
    // �������� ������� ������ � ������
    findAndReplace(path, search, replace);
    return 0;
}
