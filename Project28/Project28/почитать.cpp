void addColumn(int** array, int numRows, int numCols, int* columnData, int colPos)
{
    // создаем новый массив с дополнительным столбцом
    int** newArray = new int* [numRows];

    for (int i = 0; i < numRows; i++)
    {
        newArray[i] = new int[numCols + 1];

        // копируем данные из старого массива
        for (int j = 0; j < colPos; j++)
        {
            newArray[i][j] = array[i][j];
        }

        // добавляем новый столбец
        newArray[i][colPos] = columnData[i];

        // копируем оставшуюся часть старого массива
        for (int j = colPos + 1; j < numCols + 1; j++)
        {
            newArray[i][j] = array[i][j - 1];
        }

        // освобождаем память, занятую старым массивом
        delete[] array[i];
    }

    delete[] array;

    // присваиваем новый массив нашей переменной
    array = newArray;
}
Эта функция принимает указатель на двухмерный массив(array), количество строк(numRows) и столбцов(numCols), данные для добавляемого столбца(columnData) и позицию, на которую нужно вставить новый столбец(colPos).

Функция создает новый массив(newArray) с дополнительным столбцом, копирует данные из старого массива в новый, добавляет новый столбец и освобождает память, занятую старым массивом.Затем новый массив присваивается указателю на старый массив.

Использование функции может выглядеть так :

int** myArray = new int* [3];

for (int i = 0; i < 3; i++)
{
    myArray[i] = new int[2];

    for (int j = 0; j < 2; j++)
    {
        myArray[i][j] = i * 2 + j;
    }
}

int* newColumn = new int[3];
newColumn[0] = 7;
newColumn[1] = 8;
newColumn[2] = 9;
addColumn(myArray, 3, 2, newColumn, 1);