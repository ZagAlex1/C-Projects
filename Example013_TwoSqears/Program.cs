﻿Console.Clear();

int[,] pic = new int[,]
{
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0},
    {0,0,1,0,0,1,1,1,1,1,1,0,0,1,0,0},
    {0,0,1,0,0,1,0,0,0,0,1,0,0,1,0,0},
    {0,0,1,0,0,1,0,0,0,0,1,0,0,1,0,0},
    {0,0,1,0,0,1,0,0,0,0,1,0,0,1,0,0},
    {0,0,1,0,0,1,0,0,0,0,1,0,0,1,0,0},
    {0,0,1,0,0,1,1,1,1,1,1,0,0,1,0,0},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0},
    {0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};

void PrintImage(int[,] image)
{
  for (int rows = 0; rows < image.GetLength(0); rows++)
  {
    for (int columns = 0; columns < image.GetLength(1); columns++)
    {
      if (image[rows, columns] == 0)
        System.Console.Write($" ");
      else
        System.Console.Write($"+");
    }
    System.Console.WriteLine();
  }
}

void FillImage(int row, int col)
{
  if (pic[row, col] == 0)
  {
    pic[row, col] = 1;
    FillImage(row - 1, col);
    FillImage(row, col - 1);
    FillImage(row + 1, col);
    FillImage(row, col + 1);
  }
}

PrintImage(pic);
FillImage(6,4);
PrintImage(pic);