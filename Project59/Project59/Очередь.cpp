#include <iostream>
#include <queue>
#include <string>
#include <ctime>
using namespace std;
// Структура, представляющая запрос на печать
struct PrintRequest {
    string user; // Имя пользователя
    int priority;     // Приоритет запроса
    time_t timestamp; // Время запроса

    // Конструктор
    PrintRequest(const string& user, int priority)
        : user(user), priority(priority), timestamp(time(nullptr)) {}
};

// Функция для сравнения запросов на печать по приоритету
struct ComparePrintRequest {
    bool operator()(const PrintRequest& r1, const PrintRequest& r2) {
        return r1.priority < r2.priority;
    }
};

int main() {
    priority_queue<PrintRequest, vector<PrintRequest>, ComparePrintRequest> printQueue;
    queue<PrintRequest> printStats;

    // Добавление запросов на печать в очередь
    printQueue.push(PrintRequest("User_1", 1));
    printQueue.push(PrintRequest("User_2", 2));
    printQueue.push(PrintRequest("User_3", 3));

    // Печать запросов из очереди
    while (!printQueue.empty()) {
        PrintRequest request = printQueue.top();
        printQueue.pop();

        // Вывод информации о печати
        std::cout << "print for user: " << request.user << " Priority: " << request.priority << "\n";

        // Добавление статистики печати в отдельную очередь
        printStats.push(request);
    }

    // Вывод статистики печати на экран
    std::cout << "\nPrint statistic:\n";
    while (!printStats.empty()) {
        PrintRequest stats = printStats.front();
        printStats.pop();

        // Вывод информации о статистике печати
        std::cout << "user: " << stats.user << " Priority: " << stats.priority ;
    }

    return 0;
}
