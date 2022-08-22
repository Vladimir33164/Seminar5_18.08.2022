//Задача 33: Задайте массив. Напишите программу, которая 
//определяет, присутствует ли заданное число в массиве.

//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

/*int[] testArray = {-2,-1,0,1,2};
int SearchElement = Convert.ToInt32(Console.ReadLine());
bool foundRezult = false; //false - element not found
for(int i = 0; i < testArray.Length; i++)
{

    if(testArray[i] == SearchElement) //Console.WriteLine("Найден");
    //else Console.WriteLine("Не найден");
    {
        foundRezult = true;
        break;
    }
}
if(foundRezult) Console.WriteLine($"Элемент {SearchElement} присутствует");
//foundRezult == true (истина); !foundRezult == False (ложь). ЗАПОМНИТЬ!!!
else Console.WriteLine($"Элемент {SearchElement} отсутствует");
*/

int[] testArray = {-2,-1,0,1,2};
int SearchElement = Convert.ToInt32(Console.ReadLine());
string foundRezult = "не найден"; //решение через string
for(int i = 0; i < testArray.Length; i++)
{

    if(testArray[i] == SearchElement)
    {
        foundRezult = "найден";
        break;
    }
}
Console.WriteLine($"Элемент {SearchElement}: {foundRezult}");
/*if(foundRezult == "найден") Console.WriteLine($"Элемент {SearchElement} присутствует");
else Console.WriteLine($"Элемент {SearchElement} отсутствует");
*/
//bool testNumber = false
//if (testNumber) System.Console.WriteLine("true"); Истина!!!
//if (testNumber) System.Console.WriteLine("false");
