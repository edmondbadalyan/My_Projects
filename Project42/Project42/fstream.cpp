#include <iostream>
#include <fstream>
#include <string>
using namespace std;


int main() {


	ofstream file;

	file.open("PRIEVT.txt");
	

	file << "hello world!" << endl;
	file << "This is example for you Edmond!" << endl;

	file.close();

	ifstream file2;
	file2.open("PRIEVT.txt");


	string line;

	while (getline(file2, line)) {
		cout << line;
	}

	file2.close();



	return 0;
}