#include <iostream>
#include <map>

int main() {
    std::map<int, int> our_map;

    // ���������� ��������� � our_map
    our_map[1] = 10;
    our_map[2] = 20;
    our_map[3] = 30;

    // �������� ��� �������� ���������
    std::map<int, int>::iterator iter = our_map.begin();

    // ���������� �������� � ������� �� �� �����
    while (iter != our_map.end()) {
        std::cout << "Key: " << iter->first << ", Value: " << iter->second << std::endl;
        ++iter; // ��������� � ���������� ��������
    }

    return 0;
}
