string[] array = new string[]{"Python","C#","JavaScript","Solidity","PHP"};

Console.WriteLine("Какая должна быть максимальная длина элемента в новом массиве?");
int necessaryLength = Convert.ToInt32(Console.ReadLine());
int count = 0;

for(int i = 0; i < array.Length;i++)
{
    if(array[i].Length <= necessaryLength) count++;
}

