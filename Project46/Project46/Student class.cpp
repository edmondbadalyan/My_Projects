#include <iostream>
#include <string>

using namespace std;

class Student {
private:
    string fullName;
    string dateOfBirth;
    string phoneNumber;
    string city;
    string country;
    string schoolName;
    string schoolCity;
    string schoolCountry;
    string groupNumber;

public:
    
    Student() {}

    
    void setFullName(const string& name) {
        fullName = name;
    }

    string getFullName() const {
        return fullName;
    }

    void setDateOfBirth(const string& dob) {
        dateOfBirth = dob;
    }

    string getDateOfBirth() const {
        return dateOfBirth;
    }

    void setPhoneNumber(const string& phone) {
        phoneNumber = phone;
    }

    string getPhoneNumber() const {
        return phoneNumber;
    }

    void setCity(const string& studentCity) {
        city = studentCity;
    }

    string getCity() const {
        return city;
    }

    void setCountry(const string& studentCountry) {
        country = studentCountry;
    }

    string getCountry() const {
        return country;
    }

    void setSchoolName(const string& name) {
        schoolName = name;
    }

    string getSchoolName() const {
        return schoolName;
    }

    void setSchoolCity(const string& schoolCity) {
        this->schoolCity = schoolCity;
    }

    string getSchoolCity() const {
        return schoolCity;
    }

    void setSchoolCountry(const string& schoolCountry) {
        this->schoolCountry = schoolCountry;
    }

    string getSchoolCountry() const {
        return schoolCountry;
    }

    void setGroupNumber(const string& group) {
        groupNumber = group;
    }

    string getGroupNumber() const {
        return groupNumber;
    }

    
    void inputStudentData() {
        cout << "student FIO: ";
        getline(cin, fullName);

        cout << "date of birth: ";
        getline(cin, dateOfBirth);

        cout << "Telephone number: ";
        getline(cin, phoneNumber);

        cout << "City: ";
        getline(cin, city);

        cout << "Country: ";
        getline(cin, country);

        cout << "University name: ";
        getline(cin, schoolName);

        cout << "University city: ";
        getline(cin, schoolCity);

        cout << "University country: ";
        getline(cin, schoolCountry);

        cout << "group number: ";
        getline(cin, groupNumber);
    }

    
    void printStudentData() const {
        cout << "student FIO: " << fullName << endl;
        cout << "date of birth: " << dateOfBirth << endl;
        cout << "Telephone number: " << phoneNumber << endl;
        cout << "City: " << city << endl;
        cout << "Country: " << country << endl;
        cout << "University name: " << schoolName << endl;
        cout << "University city: " << schoolCity << endl;
        cout << "University country: " << schoolCountry << endl;
        cout << "group number: " << groupNumber << endl;
    }
};

int main() {
    Student student;

    
    student.inputStudentData();

    cout << "\nStudent Data:\n";
    
    student.printStudentData();

    return 0;
}
