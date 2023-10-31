#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

struct Book {
    string title;
    string author;
    string publisher;
    string genre;
};


void editBook(Book& b) {
    cout << "Enter new title (or press enter to skip): ";
    getline(cin, b.title);
    if (b.title == "") {
        cout << "Title not changed." << endl;
        cout << endl;
        return;
    }
    cout << "Enter new author (or press enter to skip): ";
    getline(cin, b.author);
    if (b.author == "") {
        cout << "Author not changed." << endl;
        cout << endl;
        return;
    }
    cout << "Enter new publisher (or press enter to skip): ";
    getline(cin, b.publisher);
    if (b.publisher == "") {
        cout << "Publisher not changed." << endl;
        cout << endl;
        return;
    }
    cout << "Enter new genre (or press enter to skip): ";
    getline(cin, b.genre);
    if (b.genre == "") {
        cout << "Genre not changed." << endl;
        cout << endl;
        return;
    }
    cout << "Book edited successfully." << endl;
    cout << endl;
}

void printBook(const Book& book) {
    cout << "Title: " << book.title << endl;
    cout << "Author: " << book.author << endl;
    cout << "Publisher: " << book.publisher << endl;
    cout << "Genre: " << book.genre << endl;
    cout << endl;
}

void printAllBooks(const Book books[], int n) {
    for (int i = 0; i < n; i++) {
        printBook(books[i]);
    }
}

int findBookByAuthor(const Book books[], int n, const string& author, Book foundBooks[]) {
    int count = 0;
    for (int i = 0; i < n; i++) {
        if (books[i].author == author) {
            foundBooks[count] = books[i];
            count++;
        }
    }
    return count;
}

int findBookByTitle(const Book books[], int n, const string& title, Book foundBooks[]) {
    int count = 0;
    for (int i = 0; i < n; i++) {
        if (books[i].title == title) {
            foundBooks[count] = books[i];
            count++;
        }
    }
    return count;
}

bool compareByTitle(const Book& book1, const Book& book2) {
    return book1.title < book2.title;
}

bool compareByAuthor(const Book& book1, const Book& book2) {
    return book1.author < book2.author;
}

bool compareByPublisher(const Book& book1, const Book& book2) {
    return book1.publisher < book2.publisher;
}

void sortByTitle(Book books[], int n) {
    sort(books, books + n, compareByTitle);
}

void sortByAuthor(Book books[], int n) {
    sort(books, books + n, compareByAuthor);
}

void sortByPublisher(Book books[], int n) {
    sort(books, books + n, compareByPublisher);
}

int main() {
    Book books[10] = {
        {"The Great Gatsby", "F. Scott Fitzgerald", "Charles Scribner's Sons", "Novel"},
        {"To Kill a Mockingbird", "Harper Lee", "J. B. Lippincott & Co.", "Novel"},
        {"1984", "George Orwell", "Secker & Warburg", "Dystopian fiction"},
        {"Brave New World", "Aldous Huxley", "Chatto & Windus", "Dystopian fiction"},
        {"Animal Farm", "George Orwell", "Secker & Warburg", "Satire"},
        {"The Catcher in the Rye", "J. D. Salinger", "Little, Brown and Company", "Novel"},
        {"The Lord of the Rings", "J. R. R. Tolkien", "George Allen & Unwin", "High fantasy"},
        {"The Hobbit", "J. R. R. Tolkien", "George Allen & Unwin", "Children's fantasy"},
        {"Pride and Prejudice", "Jane Austen", "T. Egerton, Whitehall", "Romance novel"},
        {"Wuthering Heights", "Emily Bronte", "Thomas Cautley Newby", "Gothic novel"}
    };

    // Print all books
    printAllBooks(books, 10);




        return 0;
}
