//Задача 31: Задайте массив из 12 элементов, заполненный 
//случайными числами из промежутка [-9, 9]. Найдите сумму 
//отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
//положительных чисел равна 29, сумма отрицательных равна -20.

int[] array = new int[12]; //массив 12 элементов -> array [0,0,0,.....0]
int ResultNegative = 0; //сумма отрицательных чисел
int ResultPositive = 0;//сумма положительных чисел

int index = 0; //точка старта цикла
int length = array.Length; //колличество элементов array.Length = 12.
//for(int index = 0; index < 0; index++);
//i = index.
while (index < length) // i < array.Length
{
    array[index] = new Random().Next(-9,10); //промежуток массива [-9,10]
    if(array[index] < 0) ResultNegative += array[index]; //отрицательные числа
    else ResultPositive += array[index]; //положительные числа (т.е. if >= 0, 0 + 1 = 1, -1 + 0 = -1)
    index++;
}
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"sumPositive: {ResultPositive}, sumNegative: {ResultNegative}");
