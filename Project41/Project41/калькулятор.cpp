#include <iostream>
#include <string>

using namespace std;

int calculate(string expr, int& pos) {
    int result = 0;
    int num = 0;
    char op = '+';

    while (pos < expr.size()) {
        char c = expr[pos++];

        if (isdigit(c)) {
            num = num * 10 + c - '0';
        }

        if (c == '(') {
            num = calculate(expr, pos);
        }

        if ((!isdigit(c) && c != ' ') || pos == expr.size()) {
            if (op == '+') {
                result += num;
            }
            else if (op == '-') {
                result -= num;
            }
            else if (op == '*') {
                result *= num;
            }
            else if (op == '/') {
                result /= num;
            }

            num = 0;
            op = c;

            if (c == ')') {
                break;
            }
        }
    }

    return result;
}

int main() {
    string expr;
    getline(cin, expr);

    int pos = 0;
    int result = calculate(expr, pos);

    cout << result << endl;

    return 0;
}
