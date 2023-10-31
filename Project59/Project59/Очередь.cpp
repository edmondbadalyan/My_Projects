#include <iostream>
#include <queue>
#include <string>
#include <ctime>
using namespace std;
// ���������, �������������� ������ �� ������
struct PrintRequest {
    string user; // ��� ������������
    int priority;     // ��������� �������
    time_t timestamp; // ����� �������

    // �����������
    PrintRequest(const string& user, int priority)
        : user(user), priority(priority), timestamp(time(nullptr)) {}
};

// ������� ��� ��������� �������� �� ������ �� ����������
struct ComparePrintRequest {
    bool operator()(const PrintRequest& r1, const PrintRequest& r2) {
        return r1.priority < r2.priority;
    }
};

int main() {
    priority_queue<PrintRequest, vector<PrintRequest>, ComparePrintRequest> printQueue;
    queue<PrintRequest> printStats;

    // ���������� �������� �� ������ � �������
    printQueue.push(PrintRequest("User_1", 1));
    printQueue.push(PrintRequest("User_2", 2));
    printQueue.push(PrintRequest("User_3", 3));

    // ������ �������� �� �������
    while (!printQueue.empty()) {
        PrintRequest request = printQueue.top();
        printQueue.pop();

        // ����� ���������� � ������
        std::cout << "print for user: " << request.user << " Priority: " << request.priority << "\n";

        // ���������� ���������� ������ � ��������� �������
        printStats.push(request);
    }

    // ����� ���������� ������ �� �����
    std::cout << "\nPrint statistic:\n";
    while (!printStats.empty()) {
        PrintRequest stats = printStats.front();
        printStats.pop();

        // ����� ���������� � ���������� ������
        std::cout << "user: " << stats.user << " Priority: " << stats.priority ;
    }

    return 0;
}
