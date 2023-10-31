#include <iostream>
using namespace std;

const int MAX_SIZE = 100;

class CharStack {
private:
	char stackArray[MAX_SIZE];
	int top;
public:
	CharStack() { 
		top = 0;
		stackArray[0];
	}
	bool isEmpty() {
		return top == 0;
	}
	bool isFull() {
		return top == MAX_SIZE - 1;
	}
	void push(char c) {
		if (!isFull()) {
			top++;
			stackArray[top] = c;
		}
		else {
			cout << "Stack overflow" << endl;
		}
	}
	void pop() {
		if (!isEmpty()) {
			top--;
		}
		else {
			cout << "Stack underflow" << endl;
		}
	}
	int size() {
		return top;
	}
	char TopValue() {
		if (!isEmpty()) {
			return stackArray[top];
		}
		else {
			cout << "stack is empty " << endl;
			return '\0';
		}
	}

	void clear() {
		top = 0;
	}
	
	
};

int main() {

	CharStack stack;

	cout << " stack is empty: " << (stack.isEmpty() ? "Yes" : "No") << endl;

	stack.push('E');
	stack.push('d');
	stack.push('m');
	stack.push('o');
	stack.push('n');
	stack.push('d');

	cout << "stack size: " << stack.size() << endl;
	cout << "stack top value: " << stack.TopValue() << endl;

	stack.clear();

	cout << "stack after clear: " << stack.size() << endl;




	return 0;
}