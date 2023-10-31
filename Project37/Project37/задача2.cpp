#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <ctype.h>

int main() {
    FILE* input_file = fopen("input.txt", "r");
    if (input_file == nullptr) {
        printf("������ �������� ����� input.txt\n");
        
    }

    FILE* output_file = fopen("output.txt", "w");
    if (output_file == nullptr) {
        printf("������ �������� ����� output.txt\n");
        
    }

    int character_count = 0;
    int line_count = 1; // �������� � 1, �.�. ������ ������ ��� ����
    int vowel_count = 0;
    int consonant_count = 0;
    int digit_count = 0;
    char c;

    while ((c = getc(input_file)) != EOF) { // ��������� ������� �� �������� �����, ���� �� ��������� ����� �����
        character_count++;
        if (c == '\n') { // ���� ������ �������� �������� ����� ������
            line_count++;
        }
        else if (isalpha(c)) { // ���� ������ �������� ������
            if (tolower(c) == 'a' || tolower(c) == 'e' || tolower(c) == 'i' || tolower(c) == 'o' || tolower(c) == 'u' || tolower(c) == 'y') {
                vowel_count++;
            }
            else {
                consonant_count++;
            }
        }
        else if (isdigit(c)) { // ���� ������ �������� ������
            digit_count++;
        }
    }



    fprintf(output_file, "���������� ��������: %d\n", character_count);
    fprintf(output_file, "���������� �����: %d\n", line_count);
    fprintf(output_file, "���������� ������� ����: %d\n", vowel_count);
    fprintf(output_file, "���������� ��������� ����: %d\n", consonant_count);
    fprintf(output_file, "���������� ����: %d\n", digit_count);

    fclose(input_file); // �������� �������� �����
    fclose(output_file); // �������� ��������� �����

    return 0;
}
