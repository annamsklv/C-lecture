//Программа, которая выдает позицию четверки в массиве


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[]col)    //void- метод, который ничего не возвращает
{
    int count = col.Length;
    int position = 0;
    while(position <count)
    {
      Console.WriteLine(col[position]);
      position++;  
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если искомого элемента нет в массиве, программа выдаст -1
    while (index <count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; //прервать, чтобы при наличии нескольких четверок в массиве, выдавалась только пощиция первой четверки
        }
        index++;
    }
    return position;
}
int [] array = new int[10]; //new int[10]- создать новый массив, в котором 10 элементов

FillArray(array);
array[4] = 4; //принудительно добавили четверки в массив, чтобы убедиться, что программа выдает только позицию первой четверки
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
