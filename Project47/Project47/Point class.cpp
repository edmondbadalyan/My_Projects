#include <iostream>
#include <fstream>
using namespace std;
class Point {
private:
    double x;
    double y;
    double z;

public:
    
    Point() : x(0.0), y(0.0), z(0.0) {}

    
    void setX(double value) {
        x = value;

    }

    double getX() const {
        return x;
    }

    void setY(double value) {
        y = value;
    }

    double getY() const {
        return y;
    }

    void setZ(double value) {
        z = value;
    }

    double getZ() const {
        return z;
    }

    // Функция для ввода данных о точке
    void inputPointData() {
        cout << "input x: ";
        cin >> x;

        cout << "input y: ";
        cin >> y;

        cout << "input z: ";
        cin >> z;
    }

    // Функция для вывода данных о точке
    void printPointData() const {
        cout << "Point info: (" << x << ", " << y << ", " << z << ")" << endl;
    }

    // Функция для сохранения данных в файл
    void saveToFile(const string& filename) const {
        ofstream file(filename);
        if (file.is_open()) {
            file << x << endl;
            file << y << endl;
            file << z << endl;
            file.close();
            cout << "File saved: " << filename << endl;
        }
        else {
            cout << "cannot open file: " << filename << endl;
        }
    }

    // Функция для загрузки данных из файла
    void loadFromFile(const string& filename) {
        ifstream file(filename);
        if (file.is_open()) {
            file >> x;
            file >> y;
            file >> z;
            file.close();
            std::cout << "data uploaded to file: " << filename << endl;
        }
        else {
            cout << "cannot open file: " << filename << endl;
        }
    }
};

int main() {
    Point point;

    
    point.inputPointData();

    cout << "\nPoint data:\n";
    
    point.printPointData();

    // Сохранение данных в файл
    point.saveToFile("point.txt");

    // Обнуляем координаты точки
    point.setX(0.0);
    point.setY(0.0);
    point.setZ(0.0);

    
    point.loadFromFile("point.txt");

    cout << "\ndownloaded point data:\n";
    // Вывод данных о точке после загрузки
    point.printPointData();

    return 0;
}
