/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

int[] createArrayFromUserNumbers(string numbers)
{
    int[] resultArray = Array.ConvertAll(numbers.Split(','), int.Parse);
    return resultArray; 
}

int findElementsGreaterThanZero(int[] incomingArray)
{
    int count = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if(incomingArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите числа через запятую: ");
string userNumber = Convert.ToString(Console.ReadLine());
int[] currentArray = createArrayFromUserNumbers(userNumber);
int elementsGreaterThanZero = findElementsGreaterThanZero(currentArray);
Console.WriteLine($"Среди введенных чисел больше нуля: {elementsGreaterThanZero}");
