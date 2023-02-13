int[] array = { 1, 12, 18, 4, 51, 61, 17, 18 };
int findIndex = 18;

for (int i = 0; i < array.Length; i++)
{
  if (array[i] == findIndex)
  {
    Console.WriteLine(i);
    break;
  }
}
