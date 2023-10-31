#include <iostream>
using namespace std;

// Функция, которая принимает указатель на массивы и функцию
// для выполнения операции max, min или avg
int Action(int* arrA, int* arrB, int size, int (*operation)(int*, int))
{
    int resultA = operation(arrA, size);
    int resultB = operation(arrB, size);
    return resultA + resultB;
}


int max(int* arr, int size)
{
    int maxVal = arr[0];
    for (int i = 0; i < size; i++)
    {
        if (arr[i] > maxVal)
        {
            maxVal = arr[i];
        }
    }
    return maxVal;
}

int min(int* arr, int size)
{
    int minVal = arr[0];
    for (int i = 0; i < size; i++)
    {
        if (arr[i] < minVal)
        {
            minVal = arr[i];
        }
    }
    return minVal;
}

int avg(int* arr, int size)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += arr[i];
    }
    return sum / size;
}

int main()
{
    const int SIZE = 5;
    int arrA[SIZE] = { 5, 8, 3, 1, 9 };
    int arrB[SIZE] = { 2, 7, 6, 4, 0 };

    int choice;
    cout << "Choose an operation:" << endl;
    cout << "1. Max" << endl;
    cout << "2. Min" << endl;
    cout << "3. Avg" << endl;
    cin >> choice;

    int (*operation)(int*, int);
    if (choice == 1)
    {
        operation = max;
        
    }
    else if (choice == 2)
    {
        operation = min;
    }
    else if (choice == 3)
    {
        operation = avg;
    }
    else
    {
        cout << "Invalid choice!" << endl;
        return 0;
    }
    int result = Action(arrA, arrB, SIZE, operation);
    cout << "Result: " << result << endl;
    

    return 0;
}