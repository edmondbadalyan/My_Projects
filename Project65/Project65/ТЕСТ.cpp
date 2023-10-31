#include <iostream>
#include <map>
#include <vector>
#include <string>
#include <sstream>
#include <iomanip>
#include <windows.h>
using namespace std;
class User {
private:
    map<string, string> database;
    string username, password;
public:
    User() {}
    User(string& u,string& p) : database(map<string, string>()),username(u),password(p) {}

    bool registerUser() {
        cout << "Enter Username: ";
        cin >> username;
        cout << "Enter Password: ";
        cin >> password;

        if (username.length() < 5 || username.length() > 10) {
            cout << "Username must be between 5 and 10 characters.";
        }
        if (password.length() < 5 || password.length() > 10) {
            cout << "Password must be between 5 and 10 characters.";

        }
        cout << endl;

        if (database.count(username) == 0) {
            database[username] = password;
            return true;
        }
        else {
            cout << "Username is already taken. Try another one" << endl;
            return false;
        }
    }

    bool loginUser() {
       
        cout << "Enter Username: ";
        cin >> username;
        cout << "Enter Password: ";
        cin >> password;

        if (database.count(username) == 0) {
            cout << "No user found" << endl;
            return false;
        }
        else {
            if (database[username] == password) {
                cout << "Logged in" << endl;
                return true;
            }
            else {
                cout << "Incorrect password" << endl;
                return false;
            }
        }
    }
};
class Test {
private:
    string testName;
    vector<string> testQuestions;
    vector<string> testAnswers;
public:
    Test(string name) : testName(name) {}

    void AddQuestion(string question, string answer) {
        testQuestions.push_back(question);
        testAnswers.push_back(answer);
    }

    void ViewTest() {
        cout << "Test: " << testName << endl;
        for (int i = 0; i < testQuestions.size(); i++) {
            cout << testQuestions[i] << endl;
        }
        for (int i = 0; i < testAnswers.size(); i++) {
            cout << testAnswers[i] << endl;
        }
    }
};

class Admin : public User {
private:
    vector<string> categories;
    vector<Test> tests;
public:
    void AddCategory(string category) {
        categories.push_back(category);
    }

    void ViewCategories() {
        cout << "Categories: " << endl;
        for (int i = 0; i < categories.size(); i++) {
            cout << categories[i] << endl;
        }
    }

    void AddTest(Test test) {
        tests.push_back(test);
    }

    void ViewTests() {
        for (int i = 0; i < tests.size(); i++) {
            tests[i].ViewTest();
        }
    }
};

int main() {
   
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    User user;
    Admin admin;
    string testName, question, answer, category;

    // Регистрация и Логин
    if (!user.registerUser()) {
        return 1;
    }
    if (!user.loginUser()) {
        return 1;
    }

    // Создание теста админом
    cout << "Enter Test Name: ";
    cin >> testName;
    Test test(testName);

    // Создание категории админом
    int numCategories;
    cout << "Enter the number of categories: ";
    cin >> numCategories;

    for (int i = 0; i < numCategories; i++) {
        cout << "Enter Category " << (i + 1) << ": ";
        cin >> category;
        admin.AddCategory(category);
    }

    int numQuestions;
    cout << "Enter the number of questions: ";
    cin >> numQuestions;

    for (int i = 0; i < numQuestions; i++) {
        cout << "Enter Question " << (i + 1) << ": ";
        cin.ignore();
        getline(cin, question);

        cout << "Enter Answer " << (i + 1) << ": ";
        cin.ignore();
        getline(cin, answer);

        test.AddQuestion(question, answer);
    }
    admin.AddTest(test);

    // Вывод тестов и категорий
    admin.ViewTests();

    admin.ViewCategories();

    return 0;
}




