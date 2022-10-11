//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

using static System.Console;

WriteLine("Введите числа через запятую: ");
int[] numbers = StrToNum(ReadLine()!);
PrintArray(numbers);
SumNumbers(numbers);



int[] StrToNum(string input) {
    int step = 1;
    for(int i = 0; i < input.Length; i++) {
        
        if (input[i] == ',') {
            step++;
        }
    }

    int[] numb = new int [step];
    int index = 0;
    for(int i = 0; i < input.Length; i++) {
        string temp = "";

        while(input[i] != ',') {
            if (i != input.Length - 1) {
                temp += input[i].ToString();
                i++;
            }
            else {
                temp += input[i].ToString();
                break;
            }
        }
        numb[index] = Convert.ToInt32(temp);
        index++;
    }
    return numb;
}

void SumNumbers(int[] sum) {
    int count = 0;
    for(int i = 0; i < sum.Length; i++) {
        if (sum[i] > 0) {
            count++;
        }
    }
    WriteLine($"Значения больше 0 = {count}");
}


void PrintArray(int[] numbers) {
    Write("[");
    for(int i = 0; i < numbers.Length; i++) {
        Write(numbers[i] + " ");
    }
    WriteLine("]");
}
