#include <iostream>
#include <string>
#include <algorithm>
#include <sstream>

using namespace std;

int main() {
    string text; // текст
    getline(cin, text); // считываем текст из стандартного ввода

    string word; // слово, которое нужно найти
    cout << "a word to find: ";
    cin >> word;

    // «адача 1: подсчет количества вхождений заданного слова
    int count = 0;
    size_t pos = text.find(word); // поиск первого вхождени€ слова
    while (pos != string::npos) { // пока находим слово
        count++;
        pos = text.find(word, pos + 1); // ищем следующее вхождение слова
    }
    cout << "Number of occurrences of a word '" << word << "': " << count << endl;

    // «адача 2: подсчет количества символов в тексте
    int charsCount = text.size();
    cout << "count symbols: " << charsCount << endl;

    

    // «адача 4: переворот всего текста
    reverse(text.begin(), text.end());
    cout << " Text reverse: " << text << endl;

    

    return 0;
}
