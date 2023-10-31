#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <ctype.h>

int main() {
    FILE* input_file = fopen("input.txt", "r");
    if (input_file == nullptr) {
        printf("Ошибка открытия файла input.txt\n");
        
    }

    FILE* output_file = fopen("output.txt", "w");
    if (output_file == nullptr) {
        printf("Ошибка открытия файла output.txt\n");
        
    }

    int character_count = 0;
    int line_count = 1; // начинаем с 1, т.к. первая строка уже есть
    int vowel_count = 0;
    int consonant_count = 0;
    int digit_count = 0;
    char c;

    while ((c = getc(input_file)) != EOF) { // считываем символы из входного файла, пока не достигнем конца файла
        character_count++;
        if (c == '\n') { // если символ является символом новой строки
            line_count++;
        }
        else if (isalpha(c)) { // если символ является буквой
            if (tolower(c) == 'a' || tolower(c) == 'e' || tolower(c) == 'i' || tolower(c) == 'o' || tolower(c) == 'u' || tolower(c) == 'y') {
                vowel_count++;
            }
            else {
                consonant_count++;
            }
        }
        else if (isdigit(c)) { // если символ является цифрой
            digit_count++;
        }
    }



    fprintf(output_file, "Количество символов: %d\n", character_count);
    fprintf(output_file, "Количество строк: %d\n", line_count);
    fprintf(output_file, "Количество гласных букв: %d\n", vowel_count);
    fprintf(output_file, "Количество согласных букв: %d\n", consonant_count);
    fprintf(output_file, "Количество цифр: %d\n", digit_count);

    fclose(input_file); // закрытие входного файла
    fclose(output_file); // закрытие выходного файла

    return 0;
}
