string ListNum(int num)
{
	if (num > 1) 
	{
		string str = num.ToString() + ", " +  ListNum(num - 1);
		return str;
	}
	else return "1";	
}
Console.Write("Input number A ");
int UserNum=int.Parse(Console.ReadLine());
Console.Write(ListNum(UserNum));