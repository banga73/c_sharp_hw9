int SumNum(int num1, int num2)
{
	if (num1 == num2) return num1;
	else if (num1 < num2) return num1 + SumNum(num1+1, num2);
	else return 0;
}
Console.Write("Input number A ");
int UserNum1=int.Parse(Console.ReadLine());
Console.Write("Input number B ");
int UserNum2=int.Parse(Console.ReadLine());
Console.Write(SumNum(UserNum1, UserNum2));