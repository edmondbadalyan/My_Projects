#include <iostream>
#include <cstring>
#include <ctime>
using namespace std;

struct Elem {
	int TotalPoints;
	int OwnerPoints;
	int OppPoints;
	char Match[10];
	char Name[20];
	char Opponent[20];
	Elem* left, * right, * parent;
};
class Tree {
private:
	Elem* root;
public:
	Tree();
	~Tree();
	void Print(Elem* Node);
	Elem* Search(Elem* Node, char* key);
	Elem* Min(Elem* Node);
	Elem* Max(Elem* Node);
	Elem* Next(Elem* Node);
	Elem* Previous(Elem* Node);
	void Insert(Elem* z);
	void Del(Elem* z = 0);
	Elem* GetRoot();
	Elem* CalculateTotalPoints(Elem* Node);
};
Tree::Tree() {
	root = NULL;
}
Tree::~Tree(){
	Del();
}
void Tree::Print(Elem* Node) {
	if (Node !=0) {
		Print(Node->left);
		cout << Node->Name << Node->Match << Node->Opponent << endl;
		Print(Node->right);
	}
}
Elem* Tree::Search(Elem* Node,char* key) {

	while (Node !=0 && strcmp(key,Node->Name)!=0) {
		
		if (strcmp(key, Node->Name) < 0)
			Node = Node->left;
		else
			Node = Node->right;
	}
	return Node;
}
Elem* Tree::Min(Elem* Node) {
	if (Node != 0)
		while (Node->left != 0)
			Node = Node->left;
	return Node;
}
Elem* Tree::Max(Elem* Node) {
	if (Node != 0)
		while (Node->right != 0)
			Node = Node->right;
	return Node;
}
Elem* Tree::Next(Elem* Node) {

	if (Node->right == nullptr)
		return nullptr;
	if (Node->right != nullptr)
		return Min(Node->right);

	Elem* parent = Node->right;
	while (parent != nullptr && Node == parent->right) {

		Node = parent;
		parent = parent->parent;
	}

}
Elem* Tree::Previous(Elem* Node)
{
	Elem* y = 0;
	if (Node != 0)
	{
		if (Node->left != 0)
			return Max(Node->left);
		y = Node->parent;
		while (y != 0 && Node == y->left)
		{
			Node = y;
			y = y->parent;
		}
	}
	return y;
}
Elem* Tree::GetRoot() {
	return root;
}
void Tree::Insert(Elem* z)
{
	z->left = NULL;
	z->right = NULL;
	Elem* y = NULL;
	Elem* Node = root;
	while (Node != 0)
	{
		y = Node;
		if (strcmp(z->Name, Node->Name) < 0)
			Node = Node->left;
		else
			Node = Node->right;
	}
	z->parent = y;
	if (y == 0)
		root = z;
	else if (strcmp(z->Name, y->Name) < 0)
		y->left = z;
	else
		y->right = z;
}
void Tree::Del(Elem* z)
{
	if (z != 0)
	{
		Elem* Node, * y;
		if (z->left == 0 || z->right == 0)
			y = z;
		else
			y = Next(z);
		if (y->left != 0)
			Node = y->left;
		else
			Node = y->right;
		if (Node != 0)
			Node->parent = y->parent;
		if (y->parent == 0)
			root = Node;
		else if (y == y->parent->left)
			y->parent->left = Node;
		else
			y->parent->right = Node;
		if (y != z)
		{
			strcpy_s(z->Name, y->Name);
			strcpy_s(z->Opponent, y->Opponent);
			strcpy_s(z->Match, y->Match);
			z->OppPoints = y->OppPoints;
			z->OwnerPoints = y->OwnerPoints;
		}
		delete y;
	}
	else
	{
		while (root != 0)
			Del(root);
	}
}
Elem* Tree::CalculateTotalPoints(Elem* Node)
{
	if (Node == nullptr)
		return 0;

	int leftPoints = CalculateTotalPoints(Node->left);
	int rightPoints = CalculateTotalPoints(Node->right);

	Node->TotalPoints = Node->OwnerPoints + leftPoints + rightPoints;

	return Node->TotalPoints;
}
void Tree::Print(Elem* Node)
{
	if (Node != nullptr)
	{
		Print(Node->left);

		cout << Node->Name << " Total Points: " << CalculateTotalPoints(Node) << endl;

		Print(Node->right);
	}
}




int main() {





	return 0;
}