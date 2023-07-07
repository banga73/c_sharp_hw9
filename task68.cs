int Akkerman(int m, int n)
{
	if (m == 0) return n + 1;
	else if (n == 0) return Akkerman(m - 1, 1);
	else return Akkerman(m - 1, Akkerman(m, n - 1));
}
		
Console.Write("Input number A ");
int UserNum1=int.Parse(Console.ReadLine());
Console.Write("Input number B ");
int UserNum2=int.Parse(Console.ReadLine());
Console.Write(Akkerman(UserNum1, UserNum2));