Console.Clear();

// string[,] table = new string[2, 5];
// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//   for (int columns = 0; columns < 5; columns++)
//   {
//     System.Console.Write($"-{table[rows, columns]}-");
//   }
//   System.Console.WriteLine();
// }


void PrintArray(int[,] array)
{
  for (int rows = 0; rows < array.GetLength(0); rows++)
  {
    for (int columns = 0; columns < array.GetLength(1); columns++)
    {
      System.Console.Write($"{array[rows, columns]} ");
    }
    System.Console.WriteLine();
  }
}

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0,10);
    }
  }
  PrintArray(array);
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
System.Console.WriteLine();
FillArray(matrix);

