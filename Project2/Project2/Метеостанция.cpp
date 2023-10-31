#include <iostream>
using namespace std;
int main() {

	int temperature[7][3] = { { +1,+0,+1 },{+1, +2, +1},{ +0, +1, +0},{ +0, +0, -1},{ -2, -1, -2},{ +0, +1, +3},{ +2, +1, +0}};

	for (int i = 0; i < 7; ++i) {
		for (int j = 0; j < 3; ++j) {

			std::cout << temperature[i][j] << " ";
		}
		cout << endl;
	}
	





	return 0;
}