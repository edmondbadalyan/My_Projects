#include <iostream>
#include <fstream>
#include <string>

class Contact {
private:
    char* name;
    std::string homePhone;
    std::string workPhone;
    std::string mobilePhone;
    std::string additionalInfo;

public:
    Contact(const char* name, const std::string& homePhone, const std::string& workPhone,
        const std::string& mobilePhone, const std::string& additionalInfo)
        : homePhone(homePhone), workPhone(workPhone), mobilePhone(mobilePhone), additionalInfo(additionalInfo) {
        // Динамическое выделение памяти для ФИО и копирование имени
        int nameLength = strlen(name) + 1;
        this->name = new char[nameLength];
        strncpy_s(this->name, nameLength, name, nameLength - 1);
    }

    ~Contact() {
        delete[] name;  // Освобождение памяти для ФИО
    }

    const char* getName() const {
        return name;
    }

    void display() const {
        std::cout << "Name: " << name << std::endl;
        std::cout << "Home Phone: " << homePhone << std::endl;
        std::cout << "Work Phone: " << workPhone << std::endl;
        std::cout << "Mobile Phone: " << mobilePhone << std::endl;
        std::cout << "Additional Info: " << additionalInfo << std::endl;
    }
};

class PhoneBook {
private:
    static const int MAX_CONTACTS = 100;
    Contact* contacts[MAX_CONTACTS];
    int numContacts;

public:
    PhoneBook() : numContacts(0) {}

    void addContact(const char* name, const std::string& homePhone, const std::string& workPhone,
        const std::string& mobilePhone, const std::string& additionalInfo) {
        if (numContacts >= MAX_CONTACTS) {
            std::cout << "Phone book is full. Cannot add more contacts." << std::endl;
            return;
        }

        Contact* newContact = new Contact(name, homePhone, workPhone, mobilePhone, additionalInfo);
        contacts[numContacts] = newContact;
        numContacts++;
        std::cout << "Contact added successfully." << std::endl;
    }

    void removeContact(const char* name) {
        for (int i = 0; i < numContacts; i++) {
            if (strcmp(contacts[i]->getName(), name) == 0) {
                delete contacts[i];
                contacts[i] = contacts[numContacts - 1];
                numContacts--;
                std::cout << "Contact removed successfully." << std::endl;
                return;
            }
        }

        std::cout << "Contact not found." << std::endl;
    }

    void searchContact(const char* name) const {
        for (int i = 0; i < numContacts; i++) {
            if (strcmp(contacts[i]->getName(), name) == 0) {
                contacts[i]->display();
                return;
            }
        }

        std::cout << "Contact not found." << std::endl;
    }

    void displayAllContacts() const {
        if (numContacts == 0) {
            std::cout << "Phone book is empty." << std::endl;
            return;
        }

        for (int i = 0; i < numContacts; i++) {
            contacts[i]->display();
            std::cout << std::endl;
        }
    }

    void saveToFile(const std::string& filename) const {
        std::ofstream file(filename);

        if (!file.is_open()) {
            std::cout << "Failed to open the file." << std::endl;
            return;
        }

        for (int i = 0; i < numContacts; i++) {
            file << contacts[i]->getName() << std::endl;
            file << contacts[i]->getName() << std::endl;
            file << contacts[i]->getName() << std::endl;
            file << contacts[i]->getName() << std::endl;
            file << contacts[i]->getName() << std::endl;
            file << std::endl;
        }

        file.close();
        std::cout << "Contacts saved to file successfully." << std::endl;
    }

    void loadFromFile(const std::string& filename) {
        std::ifstream file(filename);

        if (!file.is_open()) {
            std::cout << "Failed to open the file." << std::endl;
            return;
        }

        char name[100];
        std::string homePhone;
        std::string workPhone;
        std::string mobilePhone;
        std::string additionalInfo;

        while (!file.eof()) {
            file.getline(name, 100);
            file >> homePhone;
            file >> workPhone;
            file >> mobilePhone;
            file >> additionalInfo;

            addContact(name, homePhone, workPhone, mobilePhone, additionalInfo);

            // Очистка буфера после чтения строки
            file.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
        }

        file.close();
        std::cout << "Contacts loaded from file successfully." << std::endl;
    }
};

int main() {
    PhoneBook phoneBook;
    int choice;

    do {
        std::cout << "Phone Book Menu:" << std::endl;
        std::cout << "1. Add Contact" << std::endl;
        std::cout << "2. Remove Contact" << std::endl;
        std::cout << "3. Search Contact" << std::endl;
        std::cout << "4. Display All Contacts" << std::endl;
        std::cout << "5. Save Contacts to File" << std::endl;
        std::cout << "6. Load Contacts from File" << std::endl;
        std::cout << "0. Exit" << std::endl;
        std::cout << "Enter your choice: ";
        std::cin >> choice;

        switch (choice) {
        case 1: {
            char name[100];
            std::string homePhone;
            std::string workPhone;
            std::string mobilePhone;
            std::string additionalInfo;

            std::cout << "Enter name: ";
            std::cin.ignore();
            std::cin.getline(name, 100);
            std::cout << "Enter home phone: ";
            std::cin >> homePhone;
            std::cout << "Enter work phone: ";
            std::cin >> workPhone;
            std::cout << "Enter mobile phone: ";
            std::cin >> mobilePhone;
            std::cout << "Enter additional info: ";
            std::cin.ignore();
            std::getline(std::cin, additionalInfo);

            phoneBook.addContact(name, homePhone, workPhone, mobilePhone, additionalInfo);
            break;
        }
        case 2: {
            char name[100];
            std::cout << "Enter name: ";
            std::cin.ignore();
            std::cin.getline(name, 100);
            phoneBook.removeContact(name);
            break;
        }
        case 3: {
            char name[100];
            std::cout << "Enter name: ";
            std::cin.ignore();
            std::cin.getline(name, 100);
            phoneBook.searchContact(name);
            break;
        }
        case 4:
            phoneBook.displayAllContacts();
            break;
        case 5: {
            std::string filename;
            std::cout << "Enter filename: ";
            std::cin >> filename;
            phoneBook.saveToFile(filename);
            break;
        }
        case 6: {
            std::string filename;
            std::cout << "Enter filename: ";
            std::cin >> filename;
            phoneBook.loadFromFile(filename);
            break;
        }
        case 0:
            std::cout << "Exiting..." << std::endl;
            break;
        default:
            std::cout << "Invalid choice. Please try again." << std::endl;
        }

        std::cout << std::endl;
    } while (choice != 0);

    return 0;
}
