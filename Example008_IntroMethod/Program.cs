int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 45;
int b2 = 5000;
int c2 = 29;
int a3 = 345;
int b3 = 210;
int c3 = 3900;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

Console.WriteLine(Max(max1, max2, max3));

int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result;
}
