void addColumn(int** array, int numRows, int numCols, int* columnData, int colPos)
{
    // ������� ����� ������ � �������������� ��������
    int** newArray = new int* [numRows];

    for (int i = 0; i < numRows; i++)
    {
        newArray[i] = new int[numCols + 1];

        // �������� ������ �� ������� �������
        for (int j = 0; j < colPos; j++)
        {
            newArray[i][j] = array[i][j];
        }

        // ��������� ����� �������
        newArray[i][colPos] = columnData[i];

        // �������� ���������� ����� ������� �������
        for (int j = colPos + 1; j < numCols + 1; j++)
        {
            newArray[i][j] = array[i][j - 1];
        }

        // ����������� ������, ������� ������ ��������
        delete[] array[i];
    }

    delete[] array;

    // ����������� ����� ������ ����� ����������
    array = newArray;
}
��� ������� ��������� ��������� �� ���������� ������(array), ���������� �����(numRows) � ��������(numCols), ������ ��� ������������ �������(columnData) � �������, �� ������� ����� �������� ����� �������(colPos).

������� ������� ����� ������(newArray) � �������������� ��������, �������� ������ �� ������� ������� � �����, ��������� ����� ������� � ����������� ������, ������� ������ ��������.����� ����� ������ ������������� ��������� �� ������ ������.

������������� ������� ����� ��������� ��� :

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