int[] array = new int[10];

FillArray(array);
ReadArray(array);
Console.WriteLine();
Console.WriteLine(FindIndex(array, 6));

int FindIndex(int[] array, int value)
{
  int index = -1;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == value)
    {
      index = i;
      break;
    }
  }
  return index;
}

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(1, 10);
  }
}

void ReadArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
}

