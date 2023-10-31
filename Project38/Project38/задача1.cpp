#include <iostream>
#include <fstream>
#include <string>
#include <filesystem>  // для работы с файловой системой
using namespace std;

void findAndReplace(const string& path, const string& search, const string& replace) {
    int count = 0;  // счетчик найденных строк
    // итерируемся по всем элементам в папке и ее подпапках
    for (const auto& entry : filesysten::recursive_directory_iterator(path)) {
        // если элемент является файлом
        if (entry.is_regular_file()) {
            ifstream file(entry.path().string());  // открываем файл для чтения
            string line;
            string file_contents;
            // читаем файл построчно
            while (getline(file, line)) {
                size_t pos = line.find(search);  // ищем вхождение искомой строки
                while (pos != string::npos) {
                    ++count;  // увеличиваем счетчик найденных строк
                    line.replace(pos, search.length(), replace);  // заменяем найденную строку на другую
                    pos = line.find(search, pos + replace.length());  // продолжаем искать далее в строке
                }
                file_contents += line + '\n';  // добавляем обновленную строку в новое содержимое файла
            }
            // если были найдены вхождения искомой строки
            if (count > 0) {
                cout << "Found " << count << " occurrences of \"" << search << "\" in file " << entry.path() << endl;
                ofstream outfile(entry.path().string());  // открываем файл для записи
                outfile << file_contents;  // записываем новое содержимое в файл
            }
            count = 0;  // сбрасываем счетчик
        }
    }
}

int main() {
    string path, search, replace;
    // получаем путь, искомую строку и строку, на которую нужно заменить, от пользователя
    cout << "Enter path: ";
    getline(cin, path);
    cout << "Enter search string: ";
    getline(cin, search);
    cout << "Enter replace string: ";
    getline(cin, replace);
    // вызываем функцию поиска и замены
    findAndReplace(path, search, replace);
    return 0;
}
