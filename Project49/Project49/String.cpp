#include <iostream>
#include <cstring>

class String {
private:
    static int count; 
    char* str;
    int length;

public:
    String() : String(80) {} 

    String(int size) : str(new char[size]), length(size) {
        count++;
    }

    String(const char* s) : str(new char[strlen(s) + 1]), length(strlen(s)) {
        strcpy(str, s);
        count++;
    }

    ~String() {
        delete[] str;
        count--;
    }

    void input() {
        std::cout << "write string: ";
        std::cin.getline(str, length);
    }

    void display() {
        std::cout << "string: " << str << std::endl;
    }

    static int getCount() {
        return count;
    }
};

int String::count = 0;

int main() {
    String s1; // ������������ ����������� �� ���������
    s1.input();
    s1.display();

    String s2(50); // ������������ ����������� � ��������� �������
    s2.input();
    s2.display();

    String s3("Hello, world!"); // ������������ ����������� � ��������� ������
    s3.display();

    std::cout << "string count: " << String::getCount() << std::endl;

    return 0;
}
