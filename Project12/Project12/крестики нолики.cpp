
#include <iostream>
using namespace std;

int main() {
    

    enum class Player { X, O };


    Player currentPlayer = Player::X;
    string board[3][3] = { {" ", " ", " "}, {" ", " ", " "}, {" ", " ", " "} };
    int row, col;

    

    // ������� ����
    for (int i = 0; i < 9; i++) {

        // ������ ��������� ����
        cout << "  1 2 3\n";
        for (int j = 0; j < 3; j++) {
            cout << j +1  << " ";
            for (int k = 0; k < 3; k++) {
                cout << board[j][k] << " ";
            }
            cout << endl;
        }

        // ������ ������ ������
        cout << "Player " << (currentPlayer == Player::X ? "X" : "O") << " enter row and column: ";
        cin >> row >> col;

        // �������� ������������ �������� ������
        if (row < 1 || row > 3 || col < 1 || col > 3 || board[row - 1][col - 1] != " ") {
            cout << "Invalid input, try again." << endl;

        }

        // ���������� ����������
        board[row - 1][col - 1] = (currentPlayer == Player::X ? "X" : "O");

        // �������� ��� �������
        if ((board[0][0] == board[0][1] && board[0][1] == board[0][2] && board[0][0] != " ") ||
            (board[1][0] == board[1][1] && board[1][1] == board[1][2] && board[1][0] != " ") ||
            (board[2][0] == board[2][1] && board[2][1] == board[2][2] && board[2][0] != " ") ||
            (board[0][0] == board[1][0] && board[1][0] == board[2][0] && board[0][0] != " ") ||
            (board[0][1] == board[1][1] && board[1][1] == board[2][1] && board[0][1] != " ") ||
            (board[0][2] == board[1][2] && board[1][2] == board[2][2] && board[0][2] != " ") ||
            (board[0][0] == board[1][1] && board[1][1] == board[2][2] && board[0][0] != " ") ||
            (board[0][2] == board[1][1] && board[1][1] == board[2][0] && board[0][2] != " ")) {
            cout << "Player " << (currentPlayer == Player::X ? "X" : "O") << " wins!" << endl;
            break;
        }

        // �������� �� ������� ������
        currentPlayer = (currentPlayer == Player::X ? Player::O : Player::X);

    }
    

	return 0;
}
    