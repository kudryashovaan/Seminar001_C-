﻿/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
Console.WriteLine("Введите числа через запятую: ");
string str = Console.ReadLine();
string s = "";
int result = 0;
Console.WriteLine();
int count = 0;

for (int i=0; i<str.Length; i++){
    if (char.IsDigit(str[i]) || str[i] == '-'){
        s = s + str[i];       
    } 
    if(str[i] == ','){
       result = Convert.ToInt32(s); 
       s = "";
       if (result > 0){
        count++;
       } 
    }      
}     
    
Console.WriteLine(count + " числа больше 0.");

