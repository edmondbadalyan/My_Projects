#include <iostream>
#include <map>

int main() {
    std::map<int, int> our_map;

    // Добавление элементов в our_map
    our_map[1] = 10;
    our_map[2] = 20;
    our_map[3] = 30;

    // Итератор для перебора элементов
    std::map<int, int>::iterator iter = our_map.begin();

    // Перебираем элементы и выводим их на экран
    while (iter != our_map.end()) {
        std::cout << "Key: " << iter->first << ", Value: " << iter->second << std::endl;
        ++iter; // Переходим к следующему элементу
    }

    return 0;
}
